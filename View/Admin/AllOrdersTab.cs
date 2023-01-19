using FuelDeliverySystem.Model;
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

namespace FuelDeliverySystem
{                        
    public partial class AllOrdersTab : UserControl
    {
        string connectionString = "server=localhost;port=3306;username=root;password='';database=fueldelivery";
        public AllOrdersTab()
        {
            InitializeComponent();
        }

        private void updateTable_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                dataGridView1.Invoke(new Action(() =>
                {
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();

                    string query = "SELECT * FROM transactions";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns[0].Width = 50;
                    dataGridView1.Columns[1].Width = 200;
                    dataGridView1.Columns[2].Width = 90;
                    dataGridView1.Columns[3].Width = 180;
                    dataGridView1.Columns[4].Width = 100;
                    dataGridView1.Columns[5].Width = 70;
                    dataGridView1.Columns[6].Width = 85;
                    dataGridView1.Columns[7].Width = 80;
                    dataGridView1.Columns[8].Width = 180;
                    dataGridView1.Columns[9].Width = 350;
                    dataGridView1.Columns[10].Width = 180;
                    dataGridView1.Columns[11].Width = 110;
                }));
                Thread.Sleep(5000);
            }
        }

        private void AllOrdersTab_Load_1(object sender, EventArgs e)
        {
            updateTable.DoWork += new DoWorkEventHandler(updateTable_DoWork);
            updateTable.RunWorkerAsync();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Orders updateAccount = new Orders(
                    int.Parse(selectedRow.Cells[0].Value.ToString()),
                    selectedRow.Cells[1].Value.ToString(),
                    selectedRow.Cells[2].Value.ToString(),
                    selectedRow.Cells[3].Value.ToString(),
                    selectedRow.Cells[4].Value.ToString(),
                    double.Parse(selectedRow.Cells[5].Value.ToString()),
                    double.Parse(selectedRow.Cells[6].Value.ToString()),
                    double.Parse(selectedRow.Cells[7].Value.ToString()),
                    selectedRow.Cells[8].Value.ToString(),
                    selectedRow.Cells[9].Value.ToString(),
                    selectedRow.Cells[10].Value.ToString(),
                    selectedRow.Cells[11].Value.ToString()
                );

                UpdateOrderForm update = new UpdateOrderForm(updateAccount);
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
                int id = int.Parse(selectedRow.Cells[0].Value.ToString());

                DialogResult confirm = MessageBox.Show("Are you sure you want to remove this transaction?",
                                            "Confirmation", MessageBoxButtons.OKCancel);

                if (confirm == DialogResult.OK)
                {
                    MySqlConnection con = new MySqlConnection(connectionString);
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("DELETE FROM transactions WHERE ID = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Done deleting transaction", "Process done!", MessageBoxButtons.OK,
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
    }
}
