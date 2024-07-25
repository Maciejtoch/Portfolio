import pyodbc
import requests
import datetime
import os
import tkinter as tk
from tkinter import messagebox
from gtts import gTTS
from PIL import Image, ImageTk
import openmeteo_requests
import requests_cache
from retry_requests import retry

server = os.getenv('DB_SERVER', '.database.windows.net')
database = os.getenv('DB_DATABASE', 'TaskDatabase')
username = os.getenv('DB_USERNAME', '')
password = os.getenv('DB_PASSWORD', '')
driver = '{ODBC Driver 17 for SQL Server}'

try:
    conn = pyodbc.connect(f'DRIVER={driver};SERVER={server};PORT=1433;DATABASE={database};UID={username};PWD={password}')
    cursor = conn.cursor()
except pyodbc.Error as e:
    print(f"Error connecting to database: {e}")
    exit(1)

def add_task():
    title = title_entry.get()
    description = desc_entry.get()
    date = date_entry.get()
    
    try:
        cursor.execute("INSERT INTO Tasks (TaskName, TaskDescription, DueDate) VALUES (?, ?, ?)", (title, description, date))
        conn.commit()
        messagebox.showinfo("Success", "Task added successfully.")
        title_entry.delete(0, tk.END)
        desc_entry.delete(0, tk.END)
        date_entry.delete(0, tk.END)
    except pyodbc.Error as e:
        messagebox.showerror("Database Error", f"Failed to add task: {e}")

def read_tasks():
    today = datetime.date.today()
    try:
        cursor.execute("SELECT TaskName, TaskDescription FROM Tasks WHERE DueDate = ?", today)
        rows = cursor.fetchall()
        
        if rows:
            tasks = "\n".join([f"Title: {row[0]}, Description: {row[1]}" for row in rows])
            tts = gTTS(text=f"Tasks for today: {tasks}", lang='en')
            tts.save("tasks.mp3")
            os.system("start tasks.mp3")
            
            task_label.config(text=tasks)
        else:
            task_label.config(text="No tasks for today.")
            tts = gTTS(text="No tasks for today.", lang='en')
            tts.save("tasks.mp3")
            os.system("start tasks.mp3")
    except pyodbc.Error as e:
        messagebox.showerror("Database Error", f"Failed to read tasks: {e}")

cache_session = requests_cache.CachedSession('.cache', expire_after=3600)
retry_session = retry(cache_session, retries=5, backoff_factor=0.2)
openmeteo = openmeteo_requests.Client(session=retry_session)

def check_weather():
    try:
        url = "https://api.open-meteo.com/v1/dwd-icon"
        params = {
            "latitude": 52.52,
            "longitude": 13.41,
            "hourly": ["temperature_2m", "relative_humidity_2m", "apparent_temperature", "rain", "snowfall", "surface_pressure", "wind_speed_10m"],
            "forecast_days": 1
        }
        responses = openmeteo.weather_api(url, params=params)
    
        response = responses[0]
        
        temp = response.Hourly().Variables(0).ValuesAsNumpy()[0] 
        humidity = response.Hourly().Variables(1).ValuesAsNumpy()[0] 
        apparent_temp = response.Hourly().Variables(2).ValuesAsNumpy()[0]  
        precipitation = response.Hourly().Variables(3).ValuesAsNumpy()[0]  
        snowfall = response.Hourly().Variables(4).ValuesAsNumpy()[0]  
        pressure = response.Hourly().Variables(5).ValuesAsNumpy()[0]  
        wind_speed = response.Hourly().Variables(6).ValuesAsNumpy()[0]  
        
        weather_text = f"Temperature: {temp:.2f}°C\nHumidity: {humidity}%\nApparent Temperature: {apparent_temp:.2f}°C\nPrecipitation: {precipitation}mm\nSnowfall: {snowfall}mm\nPressure: {pressure}hPa\nWind Speed: {wind_speed}m/s"
        
        weather_label.config(text=weather_text)
    except Exception as e:
        weather_label.config(text=f"Failed to get weather data: {e}")

root = tk.Tk()
root.title("Task Manager & Weather Checker")

tk.Label(root, text="Title:").grid(row=0, column=0)
title_entry = tk.Entry(root)
title_entry.grid(row=0, column=1)

tk.Label(root, text="Description:").grid(row=1, column=0)
desc_entry = tk.Entry(root)
desc_entry.grid(row=1, column=1)

tk.Label(root, text="Date (YYYY-MM-DD):").grid(row=2, column=0)
date_entry = tk.Entry(root)
date_entry.grid(row=2, column=1)

add_task_btn = tk.Button(root, text="Add Task", command=add_task)
add_task_btn.grid(row=3, column=0, columnspan=2)

read_task_btn = tk.Button(root, text="Read Tasks for Today", command=read_tasks)
read_task_btn.grid(row=4, column=0, columnspan=2)

task_label = tk.Label(root, text="", wraplength=400, justify=tk.LEFT)
task_label.grid(row=5, column=0, columnspan=2)

check_weather_btn = tk.Button(root, text="Check Weather", command=check_weather)
check_weather_btn.grid(row=6, column=0, columnspan=2)

weather_label = tk.Label(root, text="", wraplength=400, justify=tk.LEFT)
weather_label.grid(row=7, column=0, columnspan=2)

root.mainloop()

conn.close()
