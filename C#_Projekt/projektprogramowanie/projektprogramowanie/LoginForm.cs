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
    public partial class LoginForm : Form
    {
        private CarDealership dealership;

        public LoginForm()
        {
            InitializeComponent();
            dealership = new CarDealership();
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {           
            Application.Exit();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    if (dealership.Login(username, password))
                    {
                        MessageBox.Show("Login successful!");   
                        this.Hide();
                        MainForm.GetInstance().Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                    }
                }               
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password.");
            } 
            
        }
    }
}
