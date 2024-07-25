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
    public partial class AddCarForm : Form
    {
        private CarDealership dealership;

        public AddCarForm()
        {
            InitializeComponent();
            dealership = new CarDealership();
        }

        private void ResetTextBoxes()
        {
            brandTextBox.Text = "";
            modelTextBox.Text = "";
            yearTextBox.Text = "";
            priceTextBox.Text = "";
        }

        private void btnExitAddCar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToMenuAddCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.GetInstance().Show();
        }

        private void btnAddCarOnline_Click_1(object sender, EventArgs e)
        {
            try
            {
                string brand = brandTextBox.Text;
                string model = modelTextBox.Text;
                int year = Convert.ToInt32(yearTextBox.Text);
                double price = Convert.ToDouble(priceTextBox.Text);
                Car newCar = new Car(brand, model, year, price);
                dealership.AddCarToInventory(newCar);
                MessageBox.Show("Car added successfully!");
                ResetTextBoxes();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for year and price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                yearTextBox.Text = "";
                priceTextBox.Text = "";               
            }
        }
    }
}
