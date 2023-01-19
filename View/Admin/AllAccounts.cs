using FuelDeliverySystem.Model;
using FuelDeliverySystem.View.Admin.NewForms;
using FuelDeliverySystem.View.Admin.UpdateForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelDeliverySystem.View.Admin
{
    public partial class AllAccounts : UserControl
    {
        string connectionString = "server=localhost;port=3306;username=root;password='';database=fueldelivery";
        public AllAccounts()
        {
            InitializeComponent();
        }

        private void AllAccounts_Load(object sender, EventArgs e)
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                dataGridView1.Invoke(new Action(() =>
                {
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();

                    string query = "SELECT accounts.*, user_location.landmark, user_location.street, " +
                    "user_location.town, user_location.province, user_location.zipcode FROM accounts " +
                    "LEFT JOIN user_location ON accounts.Email = user_location.Email";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns[0].Width = 40;
                    dataGridView1.Columns[1].Width = 200;
                    dataGridView1.Columns[2].Width = 160;
                    dataGridView1.Columns[3].Width = 200;
                    dataGridView1.Columns[4].Width = 120;
                    dataGridView1.Columns[5].Width = 130;
                    dataGridView1.Columns[6].Width = 150;
                    dataGridView1.Columns[7].Width = 90;
                    dataGridView1.Columns[8].Width = 100;
                    dataGridView1.Columns[9].Width = 100;
                    dataGridView1.Columns[10].Width = 90;
                }));
                Thread.Sleep(5000);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Accounts updateUser = new Accounts(
                    int.Parse(selectedRow.Cells[0].Value.ToString()),
                    selectedRow.Cells[1].Value.ToString(),
                    selectedRow.Cells[2].Value.ToString(),
                    selectedRow.Cells[3].Value.ToString(),
                    selectedRow.Cells[4].Value.ToString(),
                    selectedRow.Cells[5].Value.ToString(),
                    selectedRow.Cells[6].Value.ToString(),
                    selectedRow.Cells[7].Value.ToString(),
                    selectedRow.Cells[8].Value.ToString(),
                    selectedRow.Cells[9].Value.ToString(),
                    int.Parse(selectedRow.Cells[10].Value.ToString())
                );

                UpdateAccountForm update = new UpdateAccountForm(updateUser);
                update.Show();
            }
            else
            {
                MessageBox.Show("Select a row to continue", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string email = selectedRow.Cells[3].Value.ToString();

                DialogResult confirm = MessageBox.Show("Are you sure you want to remove this account?",
                                            "Confirmation", MessageBoxButtons.OKCancel);

                if (confirm == DialogResult.OK)
                {
                    MySqlConnection con = new MySqlConnection(connectionString);
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("DELETE FROM accounts WHERE Email = @email; " +
                        "DELETE FROM user_location WHERE email = @email", con);
                    cmd.Parameters.AddWithValue("@email", email);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Done deleting account", "Process done!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Unable to delete, try again!");
                    }

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Select a row to continue", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            NewAccountForm addAcc = new NewAccountForm();
            addAcc.Show();
        }
    }
}
