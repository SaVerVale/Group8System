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
        }
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

        public void UpdateComputerPartsData(DataTable updatedDataTable)
        {
            try
            {
                OpenConnection();

                // Use MySqlDataAdapter.Update to save the changes back to the database
                MySqlCommandBuilder builder = new MySqlCommandBuilder();
                builder.DataAdapter = new MySqlDataAdapter("SELECT ID, Name, Count, Category, Manufacturer, Specifications, Price FROM computer_parts", GetConnection());

                // Set the UpdateCommand to handle the update operation
                builder.GetUpdateCommand();

                // Apply the changes to the database
                builder.DataAdapter.Update(updatedDataTable);
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
        }
    }
}
