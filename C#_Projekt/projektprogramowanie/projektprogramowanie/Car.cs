using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektprogramowanie
{
    public interface ISell
    {
        double Price { get; }
    }

    public class Car : ISell
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Car(string brand, string model, int year, double price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Year} {Brand} {Model}, Price: {Price:C}";
        }
    }

    public class CarDealership
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public CarDealership()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "komis";
            uid = "root";
            password = "Supernoob234";
            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        public void AddCarToInventory(Car car)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO inventory (brand, model, year, price) VALUES (@brand, @model, @year, @price)";
                cmd.Parameters.AddWithValue("@brand", car.Brand);
                cmd.Parameters.AddWithValue("@model", car.Model);
                cmd.Parameters.AddWithValue("@year", car.Year);
                cmd.Parameters.AddWithValue("@price", car.Price);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public List<Car> GetAvailableCars()
        {
            List<Car> cars = new List<Car>();
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM inventory";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string brand = reader["brand"].ToString();
                        string model = reader["model"].ToString();
                        int year = Convert.ToInt32(reader["year"]);
                        double price = Convert.ToDouble(reader["price"]);
                        cars.Add(new Car(brand, model, year, price));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            return cars;
        }

        public void SellCar(Car car)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM inventory WHERE brand = @brand AND model = @model AND year = @year AND price = @price";
                cmd.Parameters.AddWithValue("@brand", car.Brand);
                cmd.Parameters.AddWithValue("@model", car.Model);
                cmd.Parameters.AddWithValue("@year", car.Year);
                cmd.Parameters.AddWithValue("@price", car.Price);
                cmd.ExecuteNonQuery();              
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public bool Login(string username, string password)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM logincredentials WHERE username=@username";
                cmd.Parameters.AddWithValue("@username", username);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string dbPassword = reader["password"].ToString();
                        if (dbPassword == password)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        reader.Close();
                        cmd.CommandText = "INSERT INTO logincredentials (username, password) VALUES (@username, @password)";
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                 
            }
        }
      
    }
}
