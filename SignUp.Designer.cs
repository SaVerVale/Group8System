namespace Group8Sytem
{
    partial class SignUp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            signupLink = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            UserNameTxt = new TextBox();
            PasswordTxt = new TextBox();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // signupLink
            // 
            signupLink.AccessibleName = "signupLink";
            signupLink.AutoSize = true;
            signupLink.Location = new Point(482, 606);
            signupLink.Margin = new Padding(4, 0, 4, 0);
            signupLink.Name = "signupLink";
            signupLink.Size = new Size(0, 25);
            signupLink.TabIndex = 13;
            signupLink.TabStop = true;
            // 
            // label3
            // 
            label3.AccessibleName = "passwordLabel";
            label3.AutoSize = true;
            label3.BackColor = Color.LightSeaGreen;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(305, 392);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AccessibleName = "userLabel";
            label2.AutoSize = true;
            label2.BackColor = Color.LightSeaGreen;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(305, 302);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 11;
            label2.Text = "UserName";
            // 
            // UserNameTxt
            // 
            UserNameTxt.AccessibleName = "UserNameTxt";
            UserNameTxt.Location = new Point(443, 302);
            UserNameTxt.Margin = new Padding(4, 5, 4, 5);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(438, 31);
            UserNameTxt.TabIndex = 10;
            UserNameTxt.Enter += UserNameTxt_Enter;
            UserNameTxt.Leave += UserNameTxt_Leave;
            // 
            // PasswordTxt
            // 
            PasswordTxt.AccessibleName = "PasswordTxt";
            PasswordTxt.Location = new Point(443, 388);
            PasswordTxt.Margin = new Padding(4, 5, 4, 5);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(438, 31);
            PasswordTxt.TabIndex = 9;
            PasswordTxt.UseSystemPasswordChar = true;
            PasswordTxt.Enter += PasswordTxt_Enter;
            PasswordTxt.Leave += PasswordTxt_Leave;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(298, 489);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(571, 70);
            button1.TabIndex = 8;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AccessibleName = "loginLabel";
            label1.AutoSize = true;
            label1.BackColor = Color.LightSeaGreen;
            label1.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(368, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(430, 110);
            label1.TabIndex = 7;
            label1.Text = "Sign Up";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(PasswordTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(UserNameTxt);
            panel1.Location = new Point(-12, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 766);
            panel1.TabIndex = 14;
            // 
            // linkLabel1
            // 
            linkLabel1.AccessibleName = "signupLink";
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.LightSeaGreen;
            linkLabel1.LinkColor = SystemColors.Info;
            linkLabel1.Location = new Point(448, 592);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(272, 25);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Have an account already? Log in!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 750);
            Controls.Add(signupLink);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel signupLink;
        private Label label3;
        private Label label2;
        private TextBox UserNameTxt;
        private TextBox PasswordTxt;
        private Button button1;
        private Label label1;
        private Panel panel1;
        private LinkLabel linkLabel1;
    }
}