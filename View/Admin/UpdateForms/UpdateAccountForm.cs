using FuelDeliverySystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FuelDeliverySystem.View.Admin.UpdateForms
{
    public partial class UpdateAccountForm : Form
    {
        string connectionString = "server=localhost;port=3306;username=root;password='';database=fueldelivery";
        private Accounts account;
        private int oldId;
        private string oldEmail;
        public UpdateAccountForm(Accounts account)
        {
            InitializeComponent();
            this.account = account;

            this.oldId = account.GetId();
            this.oldEmail = account.GetEmail();
            this.inputId.Text = account.GetId().ToString();
            this.inputFullname.Text = account.GetFullname();
            this.inputEmail.Text = account.GetEmail();
            this.inputPhone.Text = account.GetPhone().ToString();
            this.inputPass.Text = account.GetPassword().ToString();
            this.inputLandmark.Text = account.GetLandmark();
            this.inputStreet.Text = account.GetStreet();
            this.inputTown.Text = account.GetTown();
            this.inputProvince.Text = account.GetProvince();
            this.inputZipcode.Text = account.GetZipcode().ToString();
            this.acctypeCombobox.Text = account.GetAcctype();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            inputPass.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void inputZipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inputId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inputPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

            string query = "UPDATE accounts SET ID = @id, Fullname = @fullname, Phone = @phone, Email = @email, " +
                "Password = @password, AccountType = @accType WHERE ID = @oldID; " +
                "UPDATE user_location SET id = @id, email = @email, landmark = @landmark, street = @street, town = @town, " +
                "province = @province, zipcode = @zipcode WHERE email = @oldEmail;";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@oldID", this.oldId);
            command.Parameters.AddWithValue("@oldEmail", this.oldEmail);
            command.Parameters.AddWithValue("@id", this.inputId.Text);
            command.Parameters.AddWithValue("@fullname", this.inputFullname.Text);
            command.Parameters.AddWithValue("@email", this.inputEmail.Text);
            command.Parameters.AddWithValue("@phone", this.inputPhone.Text);
            command.Parameters.AddWithValue("@password", this.inputPass.Text);
            command.Parameters.AddWithValue("@accType", this.acctypeCombobox.Text);
            command.Parameters.AddWithValue("@landmark", this.inputLandmark.Text);
            command.Parameters.AddWithValue("@street", this.inputStreet.Text);
            command.Parameters.AddWithValue("@town", this.inputTown.Text);
            command.Parameters.AddWithValue("@province", this.inputProvince.Text);
            command.Parameters.AddWithValue("@zipcode", this.inputZipcode.Text);

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
