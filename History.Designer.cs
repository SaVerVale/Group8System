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
            txtSearch = new TextBox();
            btnShow = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.BackgroundColor = SystemColors.Control;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Location = new Point(4, 66);
            dataGridViewHistory.Margin = new Padding(4, 5, 4, 5);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.RowHeadersWidth = 51;
            dataGridViewHistory.RowTemplate.Height = 25;
            dataGridViewHistory.Size = new Size(1707, 611);
            dataGridViewHistory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 54);
            label1.TabIndex = 1;
            label1.Text = "HISTORY";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1415, 25);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(165, 31);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearchTextChanged;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(1590, 25);
            btnShow.Margin = new Padding(4, 4, 4, 4);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(116, 34);
            btnShow.TabIndex = 3;
            btnShow.Text = "SHOW ALL";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShowAllClick;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnShow);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dataGridViewHistory);
            Margin = new Padding(4, 5, 4, 5);
            Name = "History";
            Size = new Size(1715, 774);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewHistory;
        private Label label1;
        private TextBox txtSearch;
        private Button btnShow;

        // This method is used to populate the DataGridView with data (Replace this with your actual data)
    }
}
