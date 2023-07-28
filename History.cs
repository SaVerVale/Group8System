using Kape;
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

namespace Group8Sytem
{
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
            DisplayHistory();
        }

        private void DisplayHistory()
        {
            try
            {
                // Get the historical data
                DbConnect dbConnector = new DbConnect();
                DataTable historyData = dbConnector.GetHistoryData();

                // Populate the DataGridView or any other control with the historical data
                dataGridViewHistory.DataSource = historyData;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., show an error message.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
