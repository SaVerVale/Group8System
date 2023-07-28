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
            ((System.ComponentModel.ISupportInitialize)(dataGridViewHistory)).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Location = new Point(0, 46);
            dataGridViewHistory.Name = "dataGridView1";
            dataGridViewHistory.RowTemplate.Height = 25;
            dataGridViewHistory.Size = new Size(347, 367);
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
            // RecentUpdates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dataGridViewHistory);
            Name = "RecentUpdates";
            Size = new Size(348, 413);
            ((System.ComponentModel.ISupportInitialize)(dataGridViewHistory)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewHistory;
        private Label label1;

        // This method is used to populate the DataGridView with data (Replace this with your actual data)
    }
}
