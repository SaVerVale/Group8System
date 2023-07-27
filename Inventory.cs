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

                AddButtonColumn("Add", "ButtonColumn1", "Plus", Color.Green);
                AddButtonColumn("Subtract", "ButtonColumn2", "Subtract", Color.Red);

                dataGridInventory.CellClick += DataGridInventory_CellClick;

            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., show an error message.
                MessageBox.Show("Error: " + ex.Message);
            }
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

        private void DataGridInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int countColumnIndex = GetColumnIndexByName("Count");
                if (countColumnIndex != -1)
                {
                    if (e.ColumnIndex == dataGridInventory.Columns["ButtonColumn1"].Index)
                    {
                        // "Add" button clicked
                        DataGridViewCell countCell = dataGridInventory.Rows[e.RowIndex].Cells[countColumnIndex];
                        if (countCell.Value != null && int.TryParse(countCell.Value.ToString(), out int currentCount))
                        {
                            dataGridInventory.Rows[e.RowIndex].Cells[countColumnIndex].Value = (currentCount + 1).ToString();
                        }
                    }
                    else if (e.ColumnIndex == dataGridInventory.Columns["ButtonColumn2"].Index)
                    {
                        // "Subtract" button clicked
                        DataGridViewCell countCell = dataGridInventory.Rows[e.RowIndex].Cells[countColumnIndex];
                        if (countCell.Value != null && int.TryParse(countCell.Value.ToString(), out int currentCount) && currentCount > 0)
                        {
                            dataGridInventory.Rows[e.RowIndex].Cells[countColumnIndex].Value = (currentCount - 1).ToString();
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



        // Public method to get the dataGridInventory control
        public DataGridView GetDataGridInventory()
        {
            return dataGridInventory;
        }

        private void btnSaveClick(object sender, EventArgs e)
        {
            try
            {
                // Create a DataTable to store the changes made in the DataGridView
                DataTable updatedDataTable = ((DataTable)dataGridInventory.DataSource).GetChanges();

                if (updatedDataTable != null)
                {
                    DbConnect dbConnector = new DbConnect();

                    // Save the changes to the database
                    dbConnector.UpdateComputerPartsData(updatedDataTable);

                    // Optionally, you can display a success message to the user
                    MessageBox.Show("Changes saved successfully!");

                    // Merge the changes back to the original DataTable in the DataGridView
                    ((DataTable)dataGridInventory.DataSource).Merge(updatedDataTable);
                }
                else
                {
                    // No changes were made, show a message to the user
                    MessageBox.Show("No changes to save.");
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
