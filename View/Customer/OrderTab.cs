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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FuelDeliverySystem
{
    public partial class OrderTab : UserControl
    {
        string connectionString = "server=localhost;port=3306;username=root;password='';database=fueldelivery";
        public OrderTab()
        {
            InitializeComponent();
        }

        private void OrderTab_Load(object sender, EventArgs e)
        {
            updateTable.DoWork += new DoWorkEventHandler(updateTable_DoWork);
            updateTable.RunWorkerAsync();
        }

        private void updateTable_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                dataGridView1.Invoke(new Action(() =>
                {
                    string email = Login.Email;

                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();

                    string query = "SELECT Station, Location, Gas, Price, Quantity, Total, Delivery_DateTime, Delivery_Location, Ordered_DateTime, Status FROM transactions WHERE Orderedby = @email";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", email);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].Width = 90;
                    dataGridView1.Columns[1].Width = 150;
                    dataGridView1.Columns[2].Width = 100;
                    dataGridView1.Columns[3].Width = 80;
                    dataGridView1.Columns[4].Width = 80;
                    dataGridView1.Columns[5].Width = 100;
                    dataGridView1.Columns[6].Width = 200;
                    dataGridView1.Columns[7].Width = 350;
                    dataGridView1.Columns[8].Width = 200;
                }));
                Thread.Sleep(10000);
            }
        }
    }
}
