namespace Kape
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            recentUpdates1 = new Group8Sytem.RecentUpdates();
            panel1 = new Panel();
            inventory1 = new Group8Sytem.Inventory();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 89);
            button1.Name = "button1";
            button1.Size = new Size(128, 63);
            button1.TabIndex = 0;
            button1.Text = "RECENT UPDATES";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // button2
            // 
            button2.Location = new Point(12, 227);
            button2.Name = "button2";
            button2.Size = new Size(128, 63);
            button2.TabIndex = 5;
            button2.Text = "EMPLOYEES";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 158);
            button3.Name = "button3";
            button3.Size = new Size(128, 63);
            button3.TabIndex = 6;
            button3.Text = "INVENTORY";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 296);
            button4.Name = "button4";
            button4.Size = new Size(128, 63);
            button4.TabIndex = 7;
            button4.Text = "ISA PA?";
            button4.UseVisualStyleBackColor = true;
            // 
            // recentUpdates1
            // 
            recentUpdates1.Location = new Point(171, 89);
            recentUpdates1.Name = "recentUpdates1";
            recentUpdates1.Size = new Size(348, 360);
            recentUpdates1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 72);
            panel1.TabIndex = 9;
            // 
            // inventory1
            // 
            inventory1.Location = new Point(171, 89);
            inventory1.Name = "inventory1";
            inventory1.Size = new Size(706, 412);
            inventory1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 520);
            Controls.Add(recentUpdates1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Group8Sytem.RecentUpdates recentUpdates1;
        private Panel panel1;
        private Group8Sytem.Inventory inventory1;
    }
}