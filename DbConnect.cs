using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group8Sytem;
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

        public DataTable GetHistoryData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                OpenConnection();

                string query = "SELECT HistoryID, ID, Name, Category, Manufacturer, Specifications, Quantity, Price, User, Action, Datetime FROM computer_parts_history;";
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


        public void UpdateComputerPartsData(DataTable updatedDataTable, string user)
        {
            try
            {
                OpenConnection();

                foreach (DataRow row in updatedDataTable.Rows)
                {
                    using (MySqlCommand updateCommand = new MySqlCommand("CALL sp_UpdateQuantity(@ID, @Name, @Category, @Manufacturer, @Specifications, @Quantity, @Price, @User, @Action, @Datetime)", GetConnection()))
                    {
                        updateCommand.Parameters.AddWithValue("@ID", row["ID"]);
                        updateCommand.Parameters.AddWithValue("@Name", row["Name"]);
                        updateCommand.Parameters.AddWithValue("@Category", row["Category"]);
                        updateCommand.Parameters.AddWithValue("@Manufacturer", row["Manufacturer"]);
                        updateCommand.Parameters.AddWithValue("@Specifications", row["Specifications"]);
                        updateCommand.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                        updateCommand.Parameters.AddWithValue("@Price", row["Price"]);
                        updateCommand.Parameters.AddWithValue("@User", user);
                        updateCommand.Parameters.AddWithValue("@Action", "Changed in stock");
                        updateCommand.Parameters.AddWithValue("@Datetime", DateTime.Now); 

                        updateCommand.ExecuteNonQuery();
                    }
                }
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




   

        public void AddComputerPart(string name, string category, string manufacturer, string specifications, int quantity, decimal price, string user)
        {
            try
            {
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand("sp_AddComputerPart", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_Name", name);
                cmd.Parameters.AddWithValue("@p_Category", category);
                cmd.Parameters.AddWithValue("@p_Manufacturer", manufacturer);
                cmd.Parameters.AddWithValue("@p_Specifications", specifications);
                cmd.Parameters.AddWithValue("@p_Quantity", quantity);
                cmd.Parameters.AddWithValue("@p_Price", price);
                cmd.Parameters.AddWithValue("@p_User", user);

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


        public void UpdateComputerPart(int id, string name, string category, string manufacturer, string specifications, int quantity, decimal price, string user)
        {
            try
            {
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand("sp_UpdateComputerPart", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_ID", id);
                cmd.Parameters.AddWithValue("p_Name", name);
                cmd.Parameters.AddWithValue("p_Category", category);
                cmd.Parameters.AddWithValue("p_Manufacturer", manufacturer);
                cmd.Parameters.AddWithValue("p_Specifications", specifications);
                cmd.Parameters.AddWithValue("p_Quantity", quantity);
                cmd.Parameters.AddWithValue("p_Price", price);
                cmd.Parameters.AddWithValue("p_User", user);

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


        public void DeleteComputerPart(int id, string user)
        {
            try
            {
                OpenConnection();

                // Use MySqlCommand to call the stored procedure
                MySqlCommand cmd = new MySqlCommand("sp_DeleteComputerPart", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters for the stored procedure
                cmd.Parameters.AddWithValue("p_ID", id);
                cmd.Parameters.AddWithValue("p_User", user);

                // Execute the stored procedure
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
