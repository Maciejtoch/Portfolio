using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektprogramowanie
{
    public partial class ShowCarsForm : Form
    {
        private CarDealership dealership;

        public ShowCarsForm()
        {
            InitializeComponent();
            dealership = new CarDealership();
            ShowAvailableCars();
        }

        private void ShowAvailableCars()
        {
            List<Car> availableCars = dealership.GetAvailableCars();
            availableCarsListBox.Items.Clear();
            foreach (Car car in availableCars)
            {
                string customItem = $" {car.Brand}   |||   {car.Model}   |||   {car.Year}   |||   {car.Price:C}";
                availableCarsListBox.Items.Add(customItem);
            }
        }

        private void btnExitShowCars_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToMenuShowCars_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.GetInstance().Show();
        }

        private void btnSellCar_Click_1(object sender, EventArgs e)
        {
            if (availableCarsListBox.SelectedItem != null)
            {
                int selectedIndex = availableCarsListBox.SelectedIndex;
                List<Car> availableCars = dealership.GetAvailableCars();

                if (selectedIndex >= 0 && selectedIndex < availableCars.Count)
                {
                    Car selectedCar = availableCars[selectedIndex];
                    dealership.SellCar(selectedCar);                  
                    ShowAvailableCars();
                }
                else
                {
                    MessageBox.Show("Invalid selection.");
                }
            }
            else
            {
                MessageBox.Show("Please select a car to sell.");
            }
        }
    }
}
