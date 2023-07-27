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
    public partial class Inventory : UserControl
    {
        // Define the public DataGridView control
       // public DataGridView dataGridInventory;

        public Inventory()
        {
            InitializeComponent();
            PopulateDataGrid(); // populate the dataGridInventory
        }

        public void PopulateDataGrid()
        {
            try
            {
                DbConnect dbConnector = new DbConnect();
                DataTable dataTable = dbConnector.GetComputerPartsData();

                dataGridInventory.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., show an error message.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Public method to get the dataGridInventory control
        public DataGridView GetDataGridInventory()
        {
            return dataGridInventory;
        }
    }
}
