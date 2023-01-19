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
    public partial class Register : Form
    {
        string connectionString = "server=localhost;port=3306;username=root;password='';database=fueldelivery";
        public Register()
        {
            InitializeComponent();
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

        private async void registerBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string fullname = inputFullname.Text;
            string phonenumber = inputPhone.Text;
            string email = inputEmail.Text;
            string password = inputPass.Text;
            string conpassword = inputConpass.Text;
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";


            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(phonenumber) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(conpassword))
            {
                error.Text = "Fill in all Inputs";

                await Task.Delay(5000);
                error.Text = "";
            }
            else if (!password.Equals(conpassword))
            {
                MessageBox.Show("Passwords didn't match", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
            {
                error.Text = "Invalid email";
            }
            else
            {
                string query = "INSERT INTO accounts (Fullname, Phone, Email, Password, AccountType) " +
                    "VALUES (@fullname, @phonenumber, @email, @password, @type); " +
                    "INSERT INTO user_location (email) VALUES (@email);";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@fullname", fullname);
                command.Parameters.AddWithValue("@phonenumber", phonenumber);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@type", "user");

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    error.Text = "Registered!";
                    inputFullname.Text = "";
                    inputPhone.Text = "";
                    inputEmail.Text = "";
                    inputPass.Text = "";
                    inputConpass.Text = "";

                    await Task.Delay(5000);
                    error.Text = "";
                }

                else
                {
                    error.Text = "FAILED!";
                    inputFullname.Text = "";
                    inputPhone.Text = "";
                    inputEmail.Text = "";
                    inputPass.Text = "";
                    inputConpass.Text = "";

                    await Task.Delay(5000);
                    error.Text = "";
                }

                connection.Close();
            }
        }

        private void signinHref_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void inputPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            inputPass.UseSystemPasswordChar = !showPass.Checked;
        }

        private void showConPass_CheckedChanged(object sender, EventArgs e)
        {
            inputConpass.UseSystemPasswordChar = !showConPass.Checked;
        }
    }
}
