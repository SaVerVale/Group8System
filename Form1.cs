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
        }

        // You can now access the dataGridInventory control through the Inventory control
        // For example, you can access its properties or modify its behavior like this:
     

        private void button1_Click(object sender, EventArgs e)
        {
            // Access the logged-in user's information from the SessionManager
            string loggedInUser = SessionManager.LoggedInUsername;
            MessageBox.Show($"Logged-in user: {loggedInUser}");
            recentUpdates1.Visible = true;
            inventory1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            recentUpdates1.Visible = true;
            inventory1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            recentUpdates1.Visible = false;
            inventory1.Visible = true;
        }
    }
}