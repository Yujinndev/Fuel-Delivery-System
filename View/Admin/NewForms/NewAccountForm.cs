using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FuelDeliverySystem.View.Admin.NewForms
{
    public partial class NewAccountForm : Form
    {
        string connectionString = "server=localhost;port=3306;username=root;password='';database=fueldelivery";
        public NewAccountForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string fullname = inputFullname.Text;
            string phonenumber = inputPhone.Text;
            string email = inputEmail.Text;
            string password = inputPass.Text;
            string accType = acctypeCombobox.Text;
            string landmark = inputLandmark.Text;
            string street = inputStreet.Text;
            string town = inputTown.Text;
            string province = inputProvince.Text;
            string zipcode = inputZipcode.Text;
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(phonenumber) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(accType) || string.IsNullOrEmpty(landmark) ||
                string.IsNullOrEmpty(street) || string.IsNullOrEmpty(town) || string.IsNullOrEmpty(province) ||
                string.IsNullOrEmpty(zipcode))
            {
                MessageBox.Show("Kindly fill in all inputs", "Empty Input/s", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Email Invalid, Kindly enter correct email", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string query = "INSERT INTO accounts (Fullname, Phone, Email, Password, AccountType) " +
                        "VALUES (@fullname, @phone, @email, @password, @accType); " +
                        "INSERT INTO user_location (email, landmark, street, town, province, zipcode) " +
                        "VALUES (@email, @landmark, @street, @town, @province, @zipcode);";

                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@fullname", fullname);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@phone", phonenumber);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@accType", accType);
                command.Parameters.AddWithValue("@landmark", landmark);
                command.Parameters.AddWithValue("@street", street);
                command.Parameters.AddWithValue("@town", town);
                command.Parameters.AddWithValue("@province", province);
                command.Parameters.AddWithValue("@zipcode", zipcode);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Created", "Process done!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Unable to create, try again!");
                }
                connection.Close();
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            inputPass.UseSystemPasswordChar = !showPass.Checked;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancel Adding new account?", "Cancel Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                // do nothing
            }
        }

        private void inputPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inputZipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
