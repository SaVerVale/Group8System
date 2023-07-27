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

                string query = "SELECT ID, Name, Category, Manufacturer, Specifications,Quantity, Price FROM computer_parts;";
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
                builder.DataAdapter = new MySqlDataAdapter("SELECT ID, Name, Category, Manufacturer, Specifications, Quantity, Price FROM computer_parts", GetConnection());

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
        public void AddComputerPart(string name, string category, string manufacturer, string specifications, int quantity, decimal price)
        {
            try
            {
                OpenConnection();

                string query = "INSERT INTO computer_parts (Name, Category, Manufacturer, Specifications, Quantity, Price) " +
                               "VALUES (@Name, @Category, @Manufacturer, @Specifications, @Quantity, @Price);";

                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Manufacturer", manufacturer);
                cmd.Parameters.AddWithValue("@Specifications", specifications);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Price", price);

                cmd.ExecuteNonQuery();
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
        public void UpdateComputerPart(int id, string name, string category, string manufacturer, string specifications, int quantity, decimal price)
        {
            try
            {
                OpenConnection();

                string query = "UPDATE computer_parts SET Name = @Name, Category = @Category, Manufacturer = @Manufacturer, " +
                               "Specifications = @Specifications, Quantity = @Quantity, Price = @Price WHERE ID = @ID;";

                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Manufacturer", manufacturer);
                cmd.Parameters.AddWithValue("@Specifications", specifications);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Price", price);

                cmd.ExecuteNonQuery();
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
        public void DeleteComputerPart(int id)
        {
            try
            {
                OpenConnection();

                string query = "DELETE FROM computer_parts WHERE ID = @ID;";

                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@ID", id);

                cmd.ExecuteNonQuery();
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
