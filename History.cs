﻿using Kape;
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

        public void DisplayHistory()
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
        private void btnShowAllClick(object sender, EventArgs e)
        {
            try
            {
                DbConnect dbConnector = new DbConnect();
                DataTable dataSource = dbConnector.GetHistoryData();

                dataGridViewHistory.DataSource = dataSource;

                txtSearch.Text = "";
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., show an error message.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtSearchTextChanged(object sender, EventArgs e)
        {
            // Perform the search when the text in the txtSearch text box changes
            string searchKeyword = txtSearch.Text.Trim();

            // Get the original data source from the DataGridView
            DataTable originalDataSource = (DataTable)dataGridViewHistory.DataSource;

            // Create a new DataTable to store the filtered rows
            DataTable filteredDataSource = originalDataSource.Clone();

            // Loop through the original data source and find rows that match the search keyword
            foreach (DataRow row in originalDataSource.Rows)
            {
                // Loop through all columns in the row and check if any cell value contains the search keyword
                bool matchFound = false;
                foreach (DataColumn column in originalDataSource.Columns)
                {
                    string cellValue = row[column.ColumnName].ToString();

                    // Case-insensitive search. Modify this condition if you need a different search behavior.
                    if (cellValue.IndexOf(searchKeyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        matchFound = true;
                        break;
                    }
                }

                if (matchFound)
                {
                    // Add the entire row to the filtered data source if any cell value contains the search keyword
                    filteredDataSource.ImportRow(row);
                }
            }

            // Set the filtered data source as the data source for the DataGridView
            dataGridViewHistory.DataSource = filteredDataSource;
        }

    }
}
