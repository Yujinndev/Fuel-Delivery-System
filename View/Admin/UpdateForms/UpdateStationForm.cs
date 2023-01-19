using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuelDeliverySystem.Model;
using MySql.Data.MySqlClient;

namespace FuelDeliverySystem.View.Admin.UpdateForms
{
    public partial class UpdateStationForm : Form
    {
        string connectionString = "server=localhost;port=3306;username=root;password='';database=fueldelivery";
        private Stations station;
        private int oldId;
        public UpdateStationForm(Stations station)
        {
            InitializeComponent();
            this.station = station;

            this.oldId = station.GetId();
            this.inputId.Text = station.GetId().ToString();
            this.statusCombobox.Text = station.GetStatus().ToString();
            this.inputCompany.Text = station.GetCompany().ToString();
            this.inputLocation.Text = station.GetLocation().ToString();
            this.inputDiesel.Text = station.GetDieselPrice().ToString();
            this.inputUnleaded.Text = station.GetUnleadedPrice().ToString();
            this.inputPremium.Text = station.GetPremiumPrice().ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "UPDATE gas_stations SET ID = @id, Company = @company, Location = @location," +
                "Diesel = @diesel, Unleaded = @unleaded, Premium = @premium, Status = @status WHERE ID = @oldID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@oldID", this.oldId);
            command.Parameters.AddWithValue("@id", this.inputId.Text);
            command.Parameters.AddWithValue("@company", this.inputCompany.Text);
            command.Parameters.AddWithValue("@location", this.inputLocation.Text);
            command.Parameters.AddWithValue("@diesel", this.inputDiesel.Text);
            command.Parameters.AddWithValue("@premium", this.inputPremium.Text);
            command.Parameters.AddWithValue("@unleaded", this.inputUnleaded.Text);
            command.Parameters.AddWithValue("@status", this.statusCombobox.Text);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Successfully Updated", "Process done!", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                this.Close();
            }

            else
            {
                MessageBox.Show("Unable to update, try again!");
            }
            connection.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancel updating station?", "Cancel Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                // do nothing
            }
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
    }
}
