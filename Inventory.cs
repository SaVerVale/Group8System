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
using System.Drawing; // Make sure to include the System.Drawing namespace for working with images.
using System.IO;


namespace Group8Sytem
{
    public partial class Inventory : UserControl
    {
        private DataTable? originalDataTable;

        public Inventory()
        {
            InitializeComponent();
            originalDataTable = new DataTable();
            PopulateDataGrid();
        }

        public void PopulateDataGrid()
        {
            try
            {
                DbConnect dbConnector = new DbConnect();
                originalDataTable = dbConnector.GetComputerPartsData(); // Store the original DataTable

                dataGridInventory.CellClick += DataGridInventory_CellClick;

                // Create a copy of the originalDataTable to be used as a working copy
                DataTable dataSource = originalDataTable.Copy();
                dataGridInventory.DataSource = dataSource;

                AddButtonColumn("Add", "ButtonColumn1", "Plus", Color.Green);
                AddButtonColumn("Subtract", "ButtonColumn2", "Subtract", Color.Red);
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., show an error message.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SetDataGridDataSource(DataTable dataSource)
        {
            dataGridInventory.DataSource = dataSource;
        }


        private void AddButtonColumn(string headerText, string name, string text, Color buttonColor)
        {
            // Create a new button column
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = headerText;
            buttonColumn.Name = name;
            buttonColumn.Text = text;
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dataGridInventory.Columns.Add(buttonColumn);

            // Handle the CellFormatting event to set the button color
            dataGridInventory.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridInventory.Columns[name].Index)
                {
                    // Set the button color
                    e.CellStyle.BackColor = buttonColor;
                    e.CellStyle.ForeColor = buttonColor; // Customize the text color as needed
                }
            };
        }

        private void DataGridInventory_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Add null check to handle possible null references
            if (originalDataTable != null && e.RowIndex >= 0 && sender is DataGridView dataGridView)
            {
                int countColumnIndex = GetColumnIndexByName("Quantity");
                if (countColumnIndex != -1)
                {
                    if (e.ColumnIndex == dataGridView.Columns["ButtonColumn1"].Index)
                    {
                        // "Add" button clicked
                        DataGridViewCell countCell = dataGridView.Rows[e.RowIndex].Cells[countColumnIndex];
                        if (countCell.Value != null && int.TryParse(countCell.Value.ToString(), out int currentCount))
                        {
                            dataGridView.Rows[e.RowIndex].Cells[countColumnIndex].Value = (currentCount + 1).ToString();
                        }
                    }
                    else if (e.ColumnIndex == dataGridView.Columns["ButtonColumn2"].Index)
                    {
                        // "Subtract" button clicked
                        DataGridViewCell countCell = dataGridView.Rows[e.RowIndex].Cells[countColumnIndex];
                        if (countCell.Value != null && int.TryParse(countCell.Value.ToString(), out int currentCount) && currentCount > 0)
                        {
                            dataGridView.Rows[e.RowIndex].Cells[countColumnIndex].Value = (currentCount - 1).ToString();
                        }
                    }
                }
            }
        }

        private int GetColumnIndexByName(string columnName)
        {
            foreach (DataGridViewColumn column in dataGridInventory.Columns)
            {
                if (column.Name == columnName)
                    return column.Index;
            }
            return -1; // Column not found
        }

        public DataGridView GetDataGridInventory()
        {
            return dataGridInventory;
        }
        /*
                private void btnSaveClick(object sender, EventArgs e)
                {
                    try
                    {
                        // Create a DataTable to store the changes made in the DataGridView
                        DataTable updatedDataTable = ((DataTable)dataGridInventory.DataSource).GetChanges();

                        if (updatedDataTable != null)
                        {
                            // Filter out added rows from the updatedDataTable
                            var modifiedRows = updatedDataTable.Rows.Cast<DataRow>()
                                .Where(r => r.RowState != DataRowState.Added)
                                .ToArray();

                            if (modifiedRows.Any())
                            {
                                DbConnect dbConnector = new DbConnect();
                                dbConnector.UpdateComputerPartsData(updatedDataTable);

                                MessageBox.Show("Changes saved successfully!");

                                // Update the modified rows directly in the originalDataTable
                                foreach (DataRow modifiedRow in modifiedRows)
                                {
                                    DataRow originalRow = originalDataTable.Rows.Cast<DataRow>()
                                        .FirstOrDefault(r => r["ID"].Equals(modifiedRow["ID"]));

                                    if (originalRow != null)
                                    {
                                        originalRow.ItemArray = modifiedRow.ItemArray;
                                    }
                                }
                            }
                            else
                            {
                                // No changes were made, show a message to the user
                                MessageBox.Show("No changes to save.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception appropriately, e.g., show an error message.
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
        */

        private void btnSaveClick(object sender, EventArgs e)
        {
            try
            {
                // Get the updated DataTable with changes from the DataGridView
                DataTable updatedDataTable = ((DataTable)dataGridInventory.DataSource).GetChanges();

                if (updatedDataTable != null)
                {
                    // Filter out added rows from the updatedDataTable
                    var modifiedRows = updatedDataTable.Rows.Cast<DataRow>()
                        .Where(r => r.RowState != DataRowState.Added)
                        .ToArray();

                    if (modifiedRows.Any())
                    {
                        // Create a new DataTable to store the changes for history
                        DataTable changesForHistory = updatedDataTable.Clone();
                        changesForHistory.Clear();

                        // Update the modified rows directly in the originalDataTable
                        foreach (DataRow modifiedRow in modifiedRows)
                        {
                            DataRow originalRow = originalDataTable.Rows.Cast<DataRow>()
                                .FirstOrDefault(r => r["ID"].Equals(modifiedRow["ID"]));

                            if (originalRow != null)
                            {
                                originalRow.ItemArray = modifiedRow.ItemArray;

                                // Add the modifiedRow to the changesForHistory DataTable
                                changesForHistory.ImportRow(modifiedRow);
                            }
                        }

                        // Update the database with the changes
                        DbConnect dbConnector = new DbConnect();
                        dbConnector.UpdateComputerPartsData(changesForHistory, GlobalData.LoggedInUsername);

                        MessageBox.Show("Changes saved successfully!");
                    }
                    else
                    {
                        // No changes were made, show a message to the user
                        MessageBox.Show("No changes to save.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., show an error message.
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnCancelClick(object sender, EventArgs e)
        {
            // Revert the table to the original count values
            if (originalDataTable != null)
            {
                try
                {
                    DataTable dataSource = ((DataTable)dataGridInventory.DataSource);
                    dataSource.Clear();
                    dataSource.Merge(originalDataTable);
                    dataGridInventory.Refresh(); // Refresh the DataGridView to display the original data
                }
                catch (Exception ex)
                {
                    // Handle the exception appropriately, e.g., show an error message.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnAddClick(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the content of the text fields
                string name = txtName.Text;
                string category = txtCategory.Text;
                string manufacturer = txtManufacturer.Text;
                string specifications = txtSpecifications.Text;
                int quantity = int.Parse(txtQuantity.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                if (price == Math.Floor(price)) // Check if the number has no decimal part
                {
                    txtPrice.Text += ".00"; // Add ".00" to the input text
                    price = decimal.Parse(txtPrice.Text); // Parse the updated text
                }

                // Save the data to the database
                DbConnect dbConnector = new DbConnect();
                dbConnector.AddComputerPart(name, category, manufacturer, specifications, quantity, price, GlobalData.LoggedInUsername);

                // Refresh the DataGridView to display the updated data
                PopulateDataGrid();

                // Show a message to the user indicating success
                MessageBox.Show("Item added successfully!");
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., show an error message.
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dataGridInventoryClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridInventory.Rows[e.RowIndex];

                // Populate the text fields with the data from the selected row
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtCategory.Text = selectedRow.Cells["Category"].Value.ToString();
                txtManufacturer.Text = selectedRow.Cells["Manufacturer"].Value.ToString();
                txtSpecifications.Text = selectedRow.Cells["Specifications"].Value.ToString();
                txtQuantity.Text = selectedRow.Cells["Quantity"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
            }
        }

        private void btnUpdateClick(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the content of the text fields
                int selectedRowIndex = dataGridInventory.CurrentCell.RowIndex;
                int id = int.Parse(dataGridInventory.Rows[selectedRowIndex].Cells["ID"].Value.ToString());
                string name = txtName.Text;
                string category = txtCategory.Text;
                string manufacturer = txtManufacturer.Text;
                string specifications = txtSpecifications.Text;
                int quantity = int.Parse(txtQuantity.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                if (price == Math.Floor(price)) // Check if the number has no decimal part
                {
                    txtPrice.Text += ".00"; // Add ".00" to the input text
                    price = decimal.Parse(txtPrice.Text); // Parse the updated text
                }

                // Update the selected row in the DataGridView
                DataGridViewRow selectedRow = dataGridInventory.Rows[selectedRowIndex];
                selectedRow.Cells["Name"].Value = name;
                selectedRow.Cells["Category"].Value = category;
                selectedRow.Cells["Manufacturer"].Value = manufacturer;
                selectedRow.Cells["Specifications"].Value = specifications;
                selectedRow.Cells["Quantity"].Value = quantity;
                selectedRow.Cells["Price"].Value = price;

                // Update the corresponding record in the database
                DbConnect dbConnector = new DbConnect();
                dbConnector.UpdateComputerPart(id, name, category, manufacturer, specifications, quantity, price, GlobalData.LoggedInUsername);

                // Show a message to the user indicating success
                MessageBox.Show("Item updated successfully!");
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., show an error message.
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void DeleteSelectedRow(int rowIndex)
        {
            if (originalDataTable != null && rowIndex >= 0)
            {
                try
                {
                    // Get the ID of the selected row to delete from the database
                    int id = int.Parse(dataGridInventory.Rows[rowIndex].Cells["ID"].Value.ToString());
                        
                    // Delete the corresponding record from the database
                    DbConnect dbConnector = new DbConnect();
                    dbConnector.DeleteComputerPart(id, GlobalData.LoggedInUsername);

                    // Remove the selected row from the DataGridView
                    dataGridInventory.Rows.RemoveAt(rowIndex);

                    // Show a message to the user indicating success
                    MessageBox.Show("Item deleted successfully!");
                }
                catch (Exception ex)
                {
                    // Handle the exception appropriately, e.g., show an error message.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dataGridInventory.CurrentCell.RowIndex;
                if (selectedRowIndex >= 0)
                {
                    // Call the method to delete the selected row from the DataGridView and the database
                    DeleteSelectedRow(selectedRowIndex);
                }
                else
                {
                    // Show a message to the user that no row is selected
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., show an error message.
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}