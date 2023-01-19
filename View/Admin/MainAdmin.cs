using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelDeliverySystem
{
    public partial class MainAdmin : Form
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void allordersBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = allordersBtn.Height;
            SidePanel.Top = allordersBtn.Top;
            allordersBtn.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            allproductsBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            allaccountBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            homeBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            allOrdersTab1.BringToFront();
        }

        private void allproductsBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = allproductsBtn.Height;
            SidePanel.Top = allproductsBtn.Top;
            allproductsBtn.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            allordersBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            allaccountBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            homeBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            allProductsTab1.BringToFront();
        }

        private void allaccountBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = allaccountBtn.Height;
            SidePanel.Top = allaccountBtn.Top;
            allaccountBtn.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            allordersBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            allproductsBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            homeBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            allAccounts1.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = homeBtn.Height;
            SidePanel.Top = homeBtn.Top;
            allaccountBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            allordersBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            allproductsBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            homeBtn.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            homeTab1.BringToFront();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to continue?", "Logout Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Login a = new Login();
                a.Show();
                this.Hide();
            }
            else
            {
                // do nothing
            }
        }
    }
}
