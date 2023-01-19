using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelDeliverySystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string connectionString = "server=localhost;port=3306;username=root;password='';database=fueldelivery";
        public static string Email { get; set; }

        private async void signinBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            Email = inputEmail.Text;
            string password = inputPass.Text;
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(password))
            {
                error.Text = " Fill in all Inputs";

                await Task.Delay(5000);
                error.Text = "";
            }

            else if (!adminBtn.Checked && !usersBtn.Checked)
            {
                error.Text = "Choose account type";

                await Task.Delay(5000);
                error.Text = "";
            }
            else if (!Regex.IsMatch(Email, pattern, RegexOptions.IgnoreCase))
            {
                error.Text = "Invalid email";
            }
            else
            {
                if (usersBtn.Checked)
                {
                    string query = "SELECT * FROM accounts WHERE Email = @Email AND Password = @password AND AccountType = 'user'";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", Email);
                    command.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        MainUser dashboard = new MainUser();
                        dashboard.Show();
                        this.Hide();
                    }

                    else
                    {
                        error.Text = "Uh oh, No data found";

                        await Task.Delay(5000);
                        error.Text = "";
                    }
                }

                else if (adminBtn.Checked)
                {
                    string query = "SELECT * FROM accounts WHERE Email = @Email AND Password = @password AND AccountType = 'admin'";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", Email);
                    command.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        MainAdmin next = new MainAdmin();
                        next.Show();    
                        this.Hide();
                    }

                    else
                    {
                        error.Text = "Uh oh, No data found";

                        await Task.Delay(5000);
                        error.Text = "";
                    }
                }
            }

            connection.Close();
        }

        private void registerHref_Click(object sender, EventArgs e)
        {
            Register a = new Register();
            a.Show();
            this.Hide();
        }

        private void close_app(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to continue?", "Close App Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                // do nothing
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            inputPass.UseSystemPasswordChar = !showPass.Checked;
        }
    }
}
