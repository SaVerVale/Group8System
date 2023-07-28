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
using Group8Sytem;
using MySql.Data.MySqlClient;

namespace Kape
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            //  recentUpdates1 = new History();
            //inventory1 = new Inventory();

        }

        // You can now access the dataGridInventory control through the Inventory control
        // For example, you can access its properties or modify its behavior like this:


        private void button1_Click(object sender, EventArgs e)
        {
            recentUpdates1.Visible = true;
            inventory1.Visible = false;
            recentUpdates1.DisplayHistory();
            if (recentUpdates1.Visible)
            {
                recentUpdates1.DisplayHistory();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            recentUpdates1.Visible = false;
            inventory1.Visible = true;
            if (inventory1.Visible) // Check if inventory1 is visible before calling PopulateDataGrid
            {
                inventory1.PopulateDataGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            recentUpdates1.Visible = false;
            inventory1.Visible = true;
            if (inventory1.Visible) // Check if inventory1 is visible before calling PopulateDataGrid
            {
                inventory1.PopulateDataGrid();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow lw = new LoginWindow();
            lw.ShowDialog();
            this.Close();
        }
    }
}