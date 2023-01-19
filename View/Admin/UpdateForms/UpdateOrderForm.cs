using FuelDeliverySystem.Model;
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

namespace FuelDeliverySystem.View.Admin.UpdateForms
{
    public partial class UpdateOrderForm : Form
    {
        string connectionString = "server=localhost;port=3306;username=root;password='';database=fueldelivery";
        private Orders order;
        private int oldId;
        public UpdateOrderForm(Orders order)
        {
            InitializeComponent();
            this.order = order;

            this.oldId = order.GetId();
            this.inputCustomer.Text = order.GetCustomer();
            this.inputDLocation.Text = order.GetDeliveryLocation();
            this.inputDtimedate.Text = order.GetDeliveryDatetime();
            this.inputOtimedate.Text = order.GetOrderedDatetime();
            this.inputSLocation.Text = order.GetLocation();
            this.inputStation.Text = order.GetStation();
            this.inputGastype.Text = order.GetGas();
            this.inputQuantity.Text = order.GetQuantity().ToString();
            this.inputTotal.Text = order.GetTotal().ToString();
            this.statusCombobox.Text = order.GetStatus();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancel updating account?", "Cancel Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                // do nothing
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "UPDATE transactions SET OrderedBy = @customer, Station = @station, Location = @sLocation," +
                "Gas = @gastype, Quantity = @quantity, Total = @total, Delivery_DateTime = @dTime, Delivery_Location = @dLocation," +
                "Status = @status WHERE ID = @oldID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@oldID", this.oldId);
            command.Parameters.AddWithValue("@customer", this.inputCustomer.Text);
            command.Parameters.AddWithValue("@dLocation", this.inputDLocation.Text);
            command.Parameters.AddWithValue("@dTime", this.inputDtimedate.Text);
            command.Parameters.AddWithValue("@sLocation", this.inputSLocation.Text);
            command.Parameters.AddWithValue("@station", this.inputStation.Text);
            command.Parameters.AddWithValue("@gastype", this.inputGastype.Text);
            command.Parameters.AddWithValue("@quantity", this.inputQuantity.Text);
            command.Parameters.AddWithValue("@total", this.inputTotal.Text);
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
    }
}
