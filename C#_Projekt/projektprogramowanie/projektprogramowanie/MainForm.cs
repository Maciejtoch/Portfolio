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
    public partial class MainForm : Form
    {
        private static MainForm instance;

        private CarDealership dealership;

        private MainForm()
        {
            InitializeComponent();
            dealership = new CarDealership();
        }

        public static MainForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MainForm();
            }
            return instance;
        }

        private void ShowAddCarForm()
        {
            AddCarForm addCarForm = new AddCarForm();
            addCarForm.ShowDialog();
        }

        private void ShowShowCarsForm()
        {
            ShowCarsForm showCarsForm = new ShowCarsForm();
            showCarsForm.ShowDialog();
        }

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnAddCar_Click_1(object sender, EventArgs e)
        {
            ShowAddCarForm();
        }

        private void btnShowCars_Click_1(object sender, EventArgs e)
        {
            ShowShowCarsForm();
        }
    }
}
