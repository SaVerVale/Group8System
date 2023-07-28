namespace Group8Sytem
{
    partial class LoginWindow
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
            label1 = new Label();
            button1 = new Button();
            PasswordTxt = new TextBox();
            UserNameTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            signupLink = new LinkLabel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleName = "loginLabel";
            label1.AutoSize = true;
            label1.BackColor = Color.LightSeaGreen;
            label1.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(386, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(350, 110);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(276, 460);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(571, 70);
            button1.TabIndex = 1;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PasswordTxt
            // 
            PasswordTxt.AccessibleName = "PasswordTxt";
            PasswordTxt.Location = new Point(399, 352);
            PasswordTxt.Margin = new Padding(4, 5, 4, 5);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(438, 31);
            PasswordTxt.TabIndex = 2;
            PasswordTxt.UseSystemPasswordChar = true;
            PasswordTxt.Enter += password_Enter;
            PasswordTxt.Leave += password_Leave;
            // 
            // UserNameTxt
            // 
            UserNameTxt.AccessibleName = "UserNameTxt";
            UserNameTxt.Location = new Point(399, 265);
            UserNameTxt.Margin = new Padding(4, 5, 4, 5);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(438, 31);
            UserNameTxt.TabIndex = 3;
            UserNameTxt.Enter += username_Enter;
            UserNameTxt.Leave += username_Leave;
            // 
            // label2
            // 
            label2.AccessibleName = "userLabel";
            label2.AutoSize = true;
            label2.BackColor = Color.LightSeaGreen;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(261, 265);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 4;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AccessibleName = "passwordLabel";
            label3.AutoSize = true;
            label3.BackColor = Color.LightSeaGreen;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(261, 355);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // signupLink
            // 
            signupLink.AccessibleName = "signupLink";
            signupLink.AutoSize = true;
            signupLink.BackColor = Color.LightSeaGreen;
            signupLink.LinkColor = SystemColors.Info;
            signupLink.Location = new Point(426, 578);
            signupLink.Margin = new Padding(4, 0, 4, 0);
            signupLink.Name = "signupLink";
            signupLink.Size = new Size(270, 25);
            signupLink.TabIndex = 6;
            signupLink.TabStop = true;
            signupLink.Text = "Don't have an account? Sign Up!";
            signupLink.LinkClicked += signupLink_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Location = new Point(-1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 766);
            panel1.TabIndex = 7;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(signupLink);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UserNameTxt);
            Controls.Add(PasswordTxt);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox PasswordTxt;
        private TextBox UserNameTxt;
        private Label label2;
        private Label label3;
        private LinkLabel signupLink;
        private Panel panel1;
    }
}