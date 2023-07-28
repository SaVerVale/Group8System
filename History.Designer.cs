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
            dataGridViewHistory.Location = new Point(3, 53);
            dataGridViewHistory.Margin = new Padding(3, 4, 3, 4);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.RowHeadersWidth = 51;
            dataGridViewHistory.RowTemplate.Height = 25;
            dataGridViewHistory.Size = new Size(1095, 489);
            dataGridViewHistory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 46);
            label1.TabIndex = 1;
            label1.Text = "HISTORY";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(865, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(133, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearchTextChanged;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(1005, 20);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(93, 27);
            btnShow.TabIndex = 3;
            btnShow.Text = "SHOW ALL";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShowAllClick;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnShow);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dataGridViewHistory);
            Margin = new Padding(3, 4, 3, 4);
            Name = "History";
            Size = new Size(1138, 619);
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
