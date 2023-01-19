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

namespace FuelDeliverySystem.View.Admin.NewForms
{
    public partial class NewProductForm : Form
    {
        string connectionString = "server=localhost;port=3306;username=root;password='';database=fueldelivery";
        public NewProductForm()
        {
            InitializeComponent();
        }

        private void inputDiesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void inputUnleaded_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void inputPremium_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string company = inputCompany.Text;
            string location = inputLocation.Text;
            string diesel = inputDiesel.Text;
            string premium = inputPremium.Text;
            string unleaded = inputUnleaded.Text;
            string status = statusCombobox.Text;

            if (string.IsNullOrEmpty(company) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(diesel) ||
                string.IsNullOrEmpty(premium) || string.IsNullOrEmpty(unleaded) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Kindly fill in all inputs", "Empty Input/s", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string query = "INSERT INTO gas_stations (Company, Location, Diesel, Unleaded, Premium, Status) " +
                        "VALUES (@company, @location, @diesel, @premium, @unleaded, @status)";

                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@company", company);
                command.Parameters.AddWithValue("@location", location);
                command.Parameters.AddWithValue("@diesel", diesel);
                command.Parameters.AddWithValue("@premium", premium);
                command.Parameters.AddWithValue("@unleaded", unleaded);
                command.Parameters.AddWithValue("@status", status);

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
    }
}
