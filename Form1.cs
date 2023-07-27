using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
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