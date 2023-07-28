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
        /*
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

        */

        public void UpdateComputerPartsData(DataTable updatedDataTable, string user)
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

                // Console.WriteLine("Number of Rows in updatedDataTable: " + updatedDataTable.Rows.Count);

                // Insert changes into computer_parts_history table if quantity changes
                foreach (DataRow row in updatedDataTable.Rows)
                {
                    using (MySqlCommand insertCommand = new MySqlCommand(
                        "INSERT INTO computer_parts_history (ID, Name, Category, Manufacturer, Specifications, Quantity, Price, User, Action, Datetime) " +
                        "VALUES (@ID, @Name, @Category, @Manufacturer, @Specifications, @Quantity, @Price, @User, @Action, @Datetime)",
                        GetConnection()))
                    {
                        insertCommand.Parameters.AddWithValue("@ID", row["ID"]);
                        insertCommand.Parameters.AddWithValue("@Name", row["Name"]);
                        insertCommand.Parameters.AddWithValue("@Category", row["Category"]);
                        insertCommand.Parameters.AddWithValue("@Manufacturer", row["Manufacturer"]);
                        insertCommand.Parameters.AddWithValue("@Specifications", row["Specifications"]);
                        insertCommand.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                        insertCommand.Parameters.AddWithValue("@Price", row["Price"]);
                        insertCommand.Parameters.AddWithValue("@User", user);

                        int originalQuantity = (int)row["Quantity", DataRowVersion.Original];

                        int updatedQuantity = (int)row["Quantity"];
                        int quantityChange = updatedQuantity - originalQuantity;

                        string actionDescription = quantityChange > 0 ? "ADDED " : "SUBTRACTED ";
                        string changeAction = $"{actionDescription}{Math.Abs(quantityChange)} TO STOCK";

                        insertCommand.Parameters.AddWithValue("@Action", "Changed in stock");
                        insertCommand.Parameters.AddWithValue("@Datetime", DateTime.Now); // Replace with the appropriate timestamp

                        // Only execute the INSERT if quantity has changed


                        insertCommand.ExecuteNonQuery();

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


        //public void UpdateComputerPartsData(DataTable updatedDataTable, DataTable originalDataTable)
        //{
        //    try
        //    {
        //        OpenConnection();

        //        // Use MySqlDataAdapter.Update to save the changes back to the database
        //        MySqlCommandBuilder builder = new MySqlCommandBuilder();
        //        builder.DataAdapter = new MySqlDataAdapter("SELECT ID, Name, Category, Manufacturer, Specifications, Quantity, Price FROM computer_parts", GetConnection());

        //        // Set the UpdateCommand to handle the update operation
        //        builder.GetUpdateCommand();

        //        // Apply the changes to the database
        //        builder.DataAdapter.Update(updatedDataTable);

        //        // Insert changes into computer_parts_history table if quantity changes
        //        foreach (DataRow updatedRow in updatedDataTable.Rows)
        //        {
        //            int id = Convert.ToInt32(updatedRow["ID"]);
        //            DataRow originalRow = originalDataTable.Rows.Find(id);

        //            if (originalRow != null && originalRow["Quantity"] != updatedRow["Quantity"])
        //            {
        //                int originalQuantity = Convert.ToInt32(originalRow["Quantity"]);
        //                int updatedQuantity = Convert.ToInt32(updatedRow["Quantity"]);
        //                int quantityChange = updatedQuantity - originalQuantity;

        //                using (MySqlCommand insertCommand = new MySqlCommand(
        //                    "INSERT INTO computer_parts_history (ID, Name, Category, Manufacturer, Specifications, Quantity, Price, User, Action, Datetime) " +
        //                    "VALUES (@ID, @Name, @Category, @Manufacturer, @Specifications, @Quantity, @Price, @User, @Action, @Datetime)",
        //                    GetConnection()))
        //                {
        //                    insertCommand.Parameters.AddWithValue("@ID", updatedRow["ID"]);
        //                    insertCommand.Parameters.AddWithValue("@Name", updatedRow["Name"]);
        //                    insertCommand.Parameters.AddWithValue("@Category", updatedRow["Category"]);
        //                    insertCommand.Parameters.AddWithValue("@Manufacturer", updatedRow["Manufacturer"]);
        //                    insertCommand.Parameters.AddWithValue("@Specifications", updatedRow["Specifications"]);
        //                    insertCommand.Parameters.AddWithValue("@Quantity", updatedRow["Quantity"]);
        //                    insertCommand.Parameters.AddWithValue("@Price", updatedRow["Price"]);
        //                    insertCommand.Parameters.AddWithValue("@User", "user123");

        //                    string actionDescription = quantityChange > 0 ? "ADDED " : "SUBTRACTED ";
        //                    string changeAction = $"{actionDescription}{Math.Abs(quantityChange)} TO STOCK";

        //                    insertCommand.Parameters.AddWithValue("@Action", changeAction);
        //                    insertCommand.Parameters.AddWithValue("@Datetime", DateTime.Now); // Replace with the appropriate timestamp

        //                    insertCommand.ExecuteNonQuery();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle the exception appropriately, e.g., show an error message.
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}



        //public void AddComputerPart(string name, string category, string manufacturer, string specifications, int quantity, decimal price)
        //{
        //    try
        //    {
        //        OpenConnection();

        //        string query = "INSERT INTO computer_parts (Name, Category, Manufacturer, Specifications, Quantity, Price) " +
        //                       "VALUES (@Name, @Category, @Manufacturer, @Specifications, @Quantity, @Price);";

        //        MySqlCommand cmd = new MySqlCommand(query, GetConnection());
        //        cmd.Parameters.AddWithValue("@Name", name);
        //        cmd.Parameters.AddWithValue("@Category", category);
        //        cmd.Parameters.AddWithValue("@Manufacturer", manufacturer);
        //        cmd.Parameters.AddWithValue("@Specifications", specifications);
        //        cmd.Parameters.AddWithValue("@Quantity", quantity);
        //        cmd.Parameters.AddWithValue("@Price", price);

        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle the exception appropriately, e.g., show an error message.
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}

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


        //public void UpdateComputerPart(int id, string name, string category, string manufacturer, string specifications, int quantity, decimal price)
        //{
        //    try
        //    {
        //        OpenConnection();

        //        string query = "UPDATE computer_parts SET Name = @Name, Category = @Category, Manufacturer = @Manufacturer, " +
        //                       "Specifications = @Specifications, Quantity = @Quantity, Price = @Price WHERE ID = @ID;";

        //        MySqlCommand cmd = new MySqlCommand(query, GetConnection());
        //        cmd.Parameters.AddWithValue("@ID", id);
        //        cmd.Parameters.AddWithValue("@Name", name);
        //        cmd.Parameters.AddWithValue("@Category", category);
        //        cmd.Parameters.AddWithValue("@Manufacturer", manufacturer);
        //        cmd.Parameters.AddWithValue("@Specifications", specifications);
        //        cmd.Parameters.AddWithValue("@Quantity", quantity);
        //        cmd.Parameters.AddWithValue("@Price", price);

        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle the exception appropriately, e.g., show an error message.
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}

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
