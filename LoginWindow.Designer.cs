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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleName = "loginLabel";
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 21);
            label1.Name = "label1";
            label1.Size = new Size(234, 74);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(187, 276);
            button1.Name = "button1";
            button1.Size = new Size(400, 42);
            button1.TabIndex = 1;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PasswordTxt
            // 
            PasswordTxt.AccessibleName = "PasswordTxt";
            PasswordTxt.Location = new Point(279, 211);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(308, 23);
            PasswordTxt.TabIndex = 2;
            PasswordTxt.UseSystemPasswordChar = true;
            PasswordTxt.Enter += password_Enter;
            PasswordTxt.Leave += password_Leave;
            // 
            // UserNameTxt
            // 
            UserNameTxt.AccessibleName = "UserNameTxt";
            UserNameTxt.Location = new Point(279, 159);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(308, 23);
            UserNameTxt.TabIndex = 3;
            UserNameTxt.Enter += username_Enter;
            UserNameTxt.Leave += username_Leave;
            // 
            // label2
            // 
            label2.AccessibleName = "userLabel";
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(183, 159);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 4;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AccessibleName = "passwordLabel";
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(183, 213);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // signupLink
            // 
            signupLink.AccessibleName = "signupLink";
            signupLink.AutoSize = true;
            signupLink.Location = new Point(298, 347);
            signupLink.Name = "signupLink";
            signupLink.Size = new Size(178, 15);
            signupLink.TabIndex = 6;
            signupLink.TabStop = true;
            signupLink.Text = "Don't have an account? Sign Up!";
            signupLink.LinkClicked += signupLink_LinkClicked;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signupLink);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UserNameTxt);
            Controls.Add(PasswordTxt);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "LoginWindow";
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
    }
}