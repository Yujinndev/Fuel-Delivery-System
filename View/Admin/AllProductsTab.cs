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
using FuelDeliverySystem.Model;
using FuelDeliverySystem.View.Admin.UpdateForms;
using FuelDeliverySystem.View.Admin.NewForms;

namespace FuelDeliverySystem
{
    public partial class AllProductsTab : UserControl
    {
        string connectionString = "server=localhost;port=3306;username=root;password='';database=fueldelivery";
        public AllProductsTab()
        {
            InitializeComponent();
        }
        private void AllProductsTab_Load(object sender, EventArgs e)
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerAsync();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1) { 
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Stations updateUser = new Stations(
                    int.Parse(selectedRow.Cells[0].Value.ToString()),
                    selectedRow.Cells[1].Value.ToString(),
                    selectedRow.Cells[2].Value.ToString(),
                    double.Parse(selectedRow.Cells[3].Value.ToString()),
                    double.Parse(selectedRow.Cells[4].Value.ToString()),
                    double.Parse(selectedRow.Cells[5].Value.ToString()),
                    selectedRow.Cells[6].Value.ToString()
                );

                UpdateStationForm update = new UpdateStationForm(updateUser);
                update.Show();
            }
            else 
            {
                MessageBox.Show("Select a row to continue", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                dataGridView1.Invoke(new Action(() =>
                {
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();

                    string query = "SELECT * FROM gas_stations";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns[0].Width = 40;
                    dataGridView1.Columns[1].Width = 110;
                    dataGridView1.Columns[2].Width = 190;
                    dataGridView1.Columns[3].Width = 80;
                    dataGridView1.Columns[4].Width = 80;
                    dataGridView1.Columns[5].Width = 80;
                    dataGridView1.Columns[6].Width = 100;
                }));
                Thread.Sleep(5000);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int id = int.Parse(selectedRow.Cells[0].Value.ToString());

                DialogResult confirm = MessageBox.Show("Are you sure you want to remove this product?",
                                            "Confirmation", MessageBoxButtons.OKCancel);

                if (confirm == DialogResult.OK)
                {
                    MySqlConnection con = new MySqlConnection(connectionString);
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("DELETE FROM gas_stations WHERE ID = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Done deleting product", "Process done!", MessageBoxButtons.OK,
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
            NewProductForm addProduct = new NewProductForm();
            addProduct.Show();
        }
    }
}
