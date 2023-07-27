using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kape
{
    public class DbConnect
    {
        private MySqlConnection connection;
        private string connectionString;

        public DbConnect()
        {
            connectionString = "server=localhost;user=root;database=db_inventory_system;";
            connection = new MySqlConnection(connectionString);

        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }s
        public DataTable GetComputerPartsData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                OpenConnection();

                string query = "SELECT ID, Name, Count, Category, Manufacturer, Specifications, Price FROM computer_parts;";
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., show an error message.
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }
    }
}
