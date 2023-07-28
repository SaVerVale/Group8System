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
            label1.Location = new Point(266, 29);
            label1.Name = "label1";
            label1.Size = new Size(601, 40);
            label1.TabIndex = 3;
            label1.Text = "SOMETHING MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            history.Location = new Point(14, 211);
            history.Margin = new Padding(3, 4, 3, 4);
            history.Name = "label2";
            history.Size = new Size(146, 84);
            history.TabIndex = 0;
            history.Text = "HISTORY";
            history.TextAlign = ContentAlignment.MiddleCenter;
            history.BackColor = Color.LightGray;
            history.Click += button1_Click; // You can keep the same event handler for the label
            // 
            // label3
            // 
            label3.Location = new Point(14, 303);
            label3.Margin = new Padding(3, 4, 3, 4);
            label3.Name = "label3";
            label3.Size = new Size(146, 84);
            label3.TabIndex = 5;
            label3.Text = "EMPLOYEES";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.BackColor = Color.LightGray;
            // 
            // label4
            // 
            inventory.Location = new Point(12, 119);
            inventory.Margin = new Padding(3, 4, 3, 4);
            inventory.Name = "label4";
            inventory.Size = new Size(146, 84);
            inventory.TabIndex = 6;
            inventory.Text = "INVENTORY";
            inventory.TextAlign = ContentAlignment.MiddleCenter;
            inventory.BackColor = Color.LightGray;
            inventory.Click += button3_Click; // You can keep the same event handler for the label
            // 
            // recentUpdates1
            // 
            recentUpdates1.Location = new Point(195, 119);
            recentUpdates1.Margin = new Padding(3, 5, 3, 5);
            recentUpdates1.Name = "recentUpdates1";
            recentUpdates1.Size = new Size(398, 480);
            recentUpdates1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 96);
            panel1.TabIndex = 9;
            // 
            // inventory1
            // 
            inventory1.Location = new Point(195, 119);
            inventory1.Margin = new Padding(3, 5, 3, 5);
            inventory1.Name = "inventory1";
            inventory1.Size = new Size(807, 549);
            inventory1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 693);
            Controls.Add(recentUpdates1);
            Controls.Add(inventory);
            Controls.Add(label3);
            Controls.Add(history);
            Controls.Add(panel1);
            Controls.Add(inventory1);
            Margin = new Padding(3, 4, 3, 4);
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
