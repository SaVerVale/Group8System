using System;
using System.Drawing;
using System.Windows.Forms;

namespace Group8Sytem
{
    partial class History
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewHistory = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.BackgroundColor = SystemColors.Control;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Location = new Point(3, 40);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.RowHeadersWidth = 51;
            dataGridViewHistory.RowTemplate.Height = 25;
            dataGridViewHistory.Size = new Size(831, 367);
            dataGridViewHistory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 37);
            label1.TabIndex = 1;
            label1.Text = "RECENT UPDATES";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(628, 15);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(749, 15);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(81, 20);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridViewHistory);
            Name = "History";
            Size = new Size(845, 464);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewHistory;
        private Label label1;
        private TextBox textBox1;
        private Button btnSearch;

        // This method is used to populate the DataGridView with data (Replace this with your actual data)
    }
}
