using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FuelDeliverySystem
{
    public partial class ProductsTab : UserControl
    {
        string connectionString = "server=localhost;port=3306;username=root;password='';database=fueldelivery";
        public ProductsTab()
        {
            InitializeComponent();
        }

        private void dieselBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dieselBtn.Checked)
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "SELECT Company, Location, Diesel, Status FROM gas_stations ORDER BY Diesel ASC";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt); 
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 113;
                dataGridView1.Columns[1].Width = 160;
                dataGridView1.Columns[2].Width = 116;
                dataGridView1.Columns[3].Width = 113;
            }
        }

        private void unleadedBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (unleadedBtn.Checked)
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "SELECT Company, Location, Unleaded, Status FROM gas_stations ORDER BY Unleaded ASC";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 113;
                dataGridView1.Columns[1].Width = 162;
                dataGridView1.Columns[2].Width = 116;
                dataGridView1.Columns[3].Width = 113;
            }
        }

        private void premiumBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (premiumBtn.Checked)
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "SELECT Company, Location, Premium, Status FROM gas_stations ORDER BY Premium ASC";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 113;
                dataGridView1.Columns[1].Width = 160;
                dataGridView1.Columns[2].Width = 116;
                dataGridView1.Columns[3].Width = 113;
            }
        }

        private async void ordernowBtn_Click(object sender, EventArgs e)
        {
            
            string email = Login.Email;
            string userLocation = string.Empty;
            string station = inputStation.Text;
            string location = inputLocation.Text;
            string gas = inputGas.Text;
            string price = inputPrice.Text;
            string quantity = inputQuantity.Text;
            string date = dateTimePicker1.Value.ToString();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT landmark, street, town, province, zipcode FROM user_location WHERE email = @email";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@email", email);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (string.IsNullOrEmpty(reader["landmark"].ToString()) ||
                    string.IsNullOrEmpty(reader["street"].ToString()) ||
                    string.IsNullOrEmpty(reader["town"].ToString()) ||
                    string.IsNullOrEmpty(reader["province"].ToString()) ||
                    string.IsNullOrEmpty(reader["zipcode"].ToString()))
                {
                    MessageBox.Show("You should set your location first on the Account tab", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {

                        userLocation += reader.GetValue(i).ToString();
                        if (i != reader.FieldCount - 1)
                        {
                            userLocation += ", ";
                        }
                    }
                }
            }
            connection.Close();
                   

            if (!dieselBtn.Checked && !unleadedBtn.Checked && !premiumBtn.Checked)
            {
                error.Text = "Please select gas type";
            }
            else if (dataGridView1.SelectedRows.Count == 0)
            {
                error.Text = "Select table row for the Station, Location, Price.";
            }
            else if (string.IsNullOrEmpty(quantity))
            {
                error.Text = "Enter Quantity";
            }
            else if (!dateTimePicker1.Checked)
            {
                error.Text = "Set Date and Time of delivery";
            }
            else
            {
                float value1, value2, result;
                value1 = float.Parse(inputPrice.Text);
                value2 = float.Parse(inputQuantity.Text);
                result = value1 * value2;
                string total = result.ToString();
                DateTime currentTime = DateTime.Now;
                string time = currentTime.ToString("dd/MM/yyyy hh:mm:ss tt");


                MySqlConnection connectionTwo = new MySqlConnection(connectionString);
                connectionTwo.Open();
                string queryTwo = "INSERT INTO transactions (OrderedBy, Station, Location, Gas, Price, Quantity, Total, Delivery_DateTime, Delivery_Location, Ordered_DateTime, Status)" +
                    "VALUES (@email, @station, @location, @gas, @price, @quantity, @total, @deliverdatetime, @userLocation, @orderdatetime, @status)";

                MySqlCommand commandTwo = new MySqlCommand(queryTwo, connectionTwo);
                commandTwo.Parameters.AddWithValue("@email", email);
                commandTwo.Parameters.AddWithValue("@station", station);
                commandTwo.Parameters.AddWithValue("@location", location);
                commandTwo.Parameters.AddWithValue("@gas", gas);
                commandTwo.Parameters.AddWithValue("@price", price);
                commandTwo.Parameters.AddWithValue("@quantity", quantity);
                commandTwo.Parameters.AddWithValue("@total", total);
                commandTwo.Parameters.AddWithValue("@deliverdatetime", date);
                commandTwo.Parameters.AddWithValue("@orderdatetime", time);
                commandTwo.Parameters.AddWithValue("@userLocation", userLocation);
                commandTwo.Parameters.AddWithValue("@status", "Just Ordered");

                int rowsAffected = commandTwo.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    error.Text = "Order Succesful!";
                    foreach (Control c in gasPanel.Controls)
                    {
                        if (c is RadioButton)
                        {
                            ((RadioButton)c).Checked = false;
                        }
                    }
                    dateTimePicker1.Checked = false;
                    inputGas.Text = "";
                    inputStation.Text = "";
                    inputLocation.Text = "";
                    inputPrice.Text = "";
                    inputQuantity.Text = string.Empty;
                    dataGridView1.ClearSelection();

                    await Task.Delay(5000);
                    error.Text = "";
                }
                else
                {
                    error.Text = "FAILED!";

                    await Task.Delay(5000);
                    error.Text = "";
                }
                connection.Close();
            }
        }

        private async void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var checkedButton = gasPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                inputGas.Text = checkedButton.Text;
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    inputStation.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    inputLocation.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    inputPrice.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    error.Text = "Enter Quantity";
                    await Task.Delay(5000);
                    error.Text = " ";
                }
                else
                {
                    error.Text = "Select table row for the Station, Location, Price.";
                    inputStation.Text = "";
                    inputLocation.Text = "";
                    inputPrice.Text = "";
                }
            }
        }

        private void inputQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
