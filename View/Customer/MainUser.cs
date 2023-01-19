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
    public partial class MainUser : Form
    {
        public MainUser()
        {
            InitializeComponent();
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

        private void accountBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = accountBtn.Height;
            SidePanel.Top = accountBtn.Top;
            accountBtn.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            homeBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            productsBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            ordersBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            accountTab1.BringToFront();
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ordersBtn.Height;
            SidePanel.Top = ordersBtn.Top;
            ordersBtn.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            accountBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            productsBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            homeBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            orderTab1.BringToFront();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = productsBtn.Height;
            SidePanel.Top = productsBtn.Top;
            productsBtn.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            accountBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            homeBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            ordersBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            productsTab1.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = homeBtn.Height;
            SidePanel.Top = homeBtn.Top;
            homeBtn.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            accountBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            productsBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            ordersBtn.Font = new Font("Century Gothic", 14F, FontStyle.Regular);
            homeTab1.BringToFront();
        }
    }
}
