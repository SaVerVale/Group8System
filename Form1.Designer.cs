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
            label2 = new Label();
            inventory1 = new Group8Sytem.Inventory();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(743, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(713, 48);
            label1.TabIndex = 3;
            label1.Text = "SOMETHING MANAGEMENT SYSTEM";
            // 
            // history
            // 
            history.BackColor = Color.LightGray;
            history.Location = new Point(17, 263);
            history.Margin = new Padding(4, 5, 4, 5);
            history.Name = "history";
            history.Size = new Size(118, 105);
            history.TabIndex = 0;
            history.Text = "HISTORY";
            history.TextAlign = ContentAlignment.MiddleCenter;
            history.Click += button1_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.LightGray;
            label3.Location = new Point(17, 378);
            label3.Margin = new Padding(4, 5, 4, 5);
            label3.Name = "label3";
            label3.Size = new Size(118, 105);
            label3.TabIndex = 5;
            label3.Text = "Logout";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // inventory
            // 
            inventory.BackColor = Color.LightGray;
            inventory.BorderStyle = BorderStyle.Fixed3D;
            inventory.Location = new Point(14, 148);
            inventory.Margin = new Padding(4, 5, 4, 5);
            inventory.Name = "inventory";
            inventory.Size = new Size(121, 105);
            inventory.TabIndex = 6;
            inventory.Text = "INVENTORY";
            inventory.TextAlign = ContentAlignment.MiddleCenter;
            inventory.Click += button3_Click;
            // 
            // recentUpdates1
            // 
            recentUpdates1.Location = new Point(155, 148);
            recentUpdates1.Margin = new Padding(4, 7, 4, 7);
            recentUpdates1.Name = "recentUpdates1";
            recentUpdates1.Size = new Size(1725, 692);
            recentUpdates1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1956, 120);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(702, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(795, 48);
            label2.TabIndex = 4;
            label2.Text = "COMPUTER PARTS INVENTORY SYSTEM";
            // 
            // inventory1
            // 
            inventory1.Location = new Point(155, 148);
            inventory1.Margin = new Padding(4, 7, 4, 7);
            inventory1.Name = "inventory1";
            inventory1.Size = new Size(1775, 840);
            inventory1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 985);
            Controls.Add(recentUpdates1);
            Controls.Add(inventory);
            Controls.Add(label3);
            Controls.Add(history);
            Controls.Add(panel1);
            Controls.Add(inventory1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label2;
    }
}
