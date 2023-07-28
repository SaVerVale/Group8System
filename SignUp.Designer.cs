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
            SuspendLayout();
            // 
            // signupLink
            // 
            signupLink.AccessibleName = "signupLink";
            signupLink.AutoSize = true;
            signupLink.Location = new Point(386, 485);
            signupLink.Name = "signupLink";
            signupLink.Size = new Size(0, 20);
            signupLink.TabIndex = 13;
            signupLink.TabStop = true;
            // 
            // label3
            // 
            label3.AccessibleName = "passwordLabel";
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(256, 307);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AccessibleName = "userLabel";
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(256, 235);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 11;
            label2.Text = "UserName";
            // 
            // UserNameTxt
            // 
            UserNameTxt.AccessibleName = "UserNameTxt";
            UserNameTxt.Location = new Point(366, 235);
            UserNameTxt.Margin = new Padding(3, 4, 3, 4);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(351, 27);
            UserNameTxt.TabIndex = 10;
            UserNameTxt.Enter += UserNameTxt_Enter;
            UserNameTxt.Leave += UserNameTxt_Leave;
            // 
            // PasswordTxt
            // 
            PasswordTxt.AccessibleName = "PasswordTxt";
            PasswordTxt.Location = new Point(366, 304);
            PasswordTxt.Margin = new Padding(3, 4, 3, 4);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(351, 27);
            PasswordTxt.TabIndex = 9;
            PasswordTxt.UseSystemPasswordChar = true;
            PasswordTxt.Enter += PasswordTxt_Enter;
            PasswordTxt.Leave += PasswordTxt_Leave;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(261, 391);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(457, 56);
            button1.TabIndex = 8;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AccessibleName = "loginLabel";
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(326, 51);
            label1.Name = "label1";
            label1.Size = new Size(359, 91);
            label1.TabIndex = 7;
            label1.Text = "Sign Up";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(signupLink);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UserNameTxt);
            Controls.Add(PasswordTxt);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUp";
            Text = "SignUp";
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
    }
}