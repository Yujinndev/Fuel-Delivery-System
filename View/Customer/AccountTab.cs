using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FuelDeliverySystem
{
    public partial class AccountTab : UserControl
    {
        string connectionString = "server=localhost;port=3306;username=root;password='';database=fueldelivery";
        public AccountTab()
        {
            InitializeComponent();
        }

        private async void setlocationBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string email = Login.Email;
            string landmark = inputLandmark.Text;
            string street = inputStreet.Text;
            string town = inputTown.Text;
            string province = inputProvince.Text;
            string zipcode = inputZipcode.Text;

            if (string.IsNullOrEmpty(landmark) || string.IsNullOrEmpty(street) || string.IsNullOrEmpty(town) ||
                string.IsNullOrEmpty(province) || string.IsNullOrEmpty(zipcode))
            {
                errorLocation.Text = "Fill in all Inputs";

                await Task.Delay(5000);
                errorLocation.Text = "";
            }
            else
            {
                string query = "UPDATE user_location SET landmark = @landmark, street = @street, town = @town, " +
                                "province = @province, zipcode = @zipcode WHERE email = @email";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@landmark", landmark);
                command.Parameters.AddWithValue("@street", street);
                command.Parameters.AddWithValue("@town", town);
                command.Parameters.AddWithValue("@province", province);
                command.Parameters.AddWithValue("@zipcode", zipcode);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    errorLocation.Text = "Successful!";
                    inputLandmark.Text = "";
                    inputStreet.Text = "";
                    inputTown.Text = "";
                    inputProvince.Text = "";
                    inputZipcode.Text = "";

                    await Task.Delay(5000);
                    errorLocation.Text = "";
                }

                else
                {
                    errorLocation.Text = "Failed!";
                    inputLandmark.Text = "";
                    inputStreet.Text = "";
                    inputTown.Text = "";
                    inputProvince.Text = "";
                    inputZipcode.Text = "";

                    await Task.Delay(5000);
                    errorLocation.Text = "";
                }

                connection.Close();
            }
        }

        private async void updatedetailsBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string emailadd = Login.Email;
            string fullname = inputFullname.Text;
            string phonenumber = inputPhone.Text;
            string email = inputEmail.Text;
            string password = inputPass.Text;
            string conpassword = inputConpass.Text;
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";


            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(phonenumber) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(conpassword))
            {
                detailsError.Text = "Fill in all Inputs";

                await Task.Delay(5000);
                detailsError.Text = "";
            }
            else if (!password.Equals(conpassword))
            {
                MessageBox.Show("Passwords didn't match", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
            {
                detailsError.Text = "Invalid email";
            }
            else
            {
                string query = "UPDATE accounts SET Fullname = @fullname, Phone = @phonenumber, Email = @email, Password = @password WHERE email = @emailAdd;" +
                    "UPDATE user_location SET email = @email WHERE email = @emailAdd;" +
                    "UPDATE transactions SET OrderedBy = @email WHERE OrderedBy = @emailAdd;";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@fullname", fullname);
                command.Parameters.AddWithValue("@phonenumber", phonenumber);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@emailAdd", emailadd);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    detailsError.Text = "Updated!";
                    inputFullname.Text = "";
                    inputPhone.Text = "";
                    inputEmail.Text = "";
                    inputPass.Text = "";
                    inputConpass.Text = "";
                    Login.Email = email;

                    await Task.Delay(5000);
                    detailsError.Text = "";
                }

                else
                {
                    detailsError.Text = "Failed!";
                    inputFullname.Text = "";
                    inputPhone.Text = "";
                    inputEmail.Text = "";
                    inputPass.Text = "";
                    inputConpass.Text = "";

                    await Task.Delay(5000);
                    detailsError.Text = "";
                }

                connection.Close();
            }
        }

        private void inputZipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void inputPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void showConPass_CheckedChanged(object sender, EventArgs e)
        {
            inputConpass.UseSystemPasswordChar = !showConPass.Checked;
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            inputPass.UseSystemPasswordChar = !showPass.Checked;
        }
    }
}
