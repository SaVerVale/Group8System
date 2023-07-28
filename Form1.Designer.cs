using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kape
{
    partial class Form1
    {
        // ... (other code remains the same)

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            history = new Label();
            label3 = new Label();
            inventory = new Label();
            recentUpdates1 = new Group8Sytem.History();
            panel1 = new Panel();
            inventory1 = new Group8Sytem.Inventory();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(233, 22);
            label1.Name = "label1";
            label1.Size = new Size(482, 32);
            label1.TabIndex = 3;
            label1.Text = "SOMETHING MANAGEMENT SYSTEM";
            // 
            // history
            // 
            history.BackColor = Color.LightGray;
            history.Location = new Point(12, 158);
            history.Margin = new Padding(3);
            history.Name = "history";
            history.Size = new Size(128, 63);
            history.TabIndex = 0;
            history.Text = "HISTORY";
            history.TextAlign = ContentAlignment.MiddleCenter;
            history.Click += button1_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.LightGray;
            label3.Location = new Point(12, 227);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(128, 63);
            label3.TabIndex = 5;
            label3.Text = "EMPLOYEES";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inventory
            // 
            inventory.BackColor = Color.LightGray;
            inventory.Location = new Point(10, 89);
            inventory.Margin = new Padding(3);
            inventory.Name = "inventory";
            inventory.Size = new Size(128, 63);
            inventory.TabIndex = 6;
            inventory.Text = "INVENTORY";
            inventory.TextAlign = ContentAlignment.MiddleCenter;
            inventory.Click += button3_Click;
            // 
            // recentUpdates1
            // 
            recentUpdates1.Location = new Point(171, 89);
            recentUpdates1.Margin = new Padding(3, 4, 3, 4);
            recentUpdates1.Name = "recentUpdates1";
            recentUpdates1.Size = new Size(1199, 415);
            recentUpdates1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1369, 72);
            panel1.TabIndex = 9;
            // 
            // inventory1
            // 
            inventory1.Location = new Point(171, 89);
            inventory1.Margin = new Padding(3, 4, 3, 4);
            inventory1.Name = "inventory1";
            inventory1.Size = new Size(1199, 456);
            inventory1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 546);
            Controls.Add(recentUpdates1);
            Controls.Add(inventory);
            Controls.Add(label3);
            Controls.Add(history);
            Controls.Add(panel1);
            Controls.Add(inventory1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label history;
        private Label label3;
        private Label inventory;
        private Group8Sytem.History recentUpdates1;
        private Panel panel1;
        private Group8Sytem.Inventory inventory1;
    }
}
