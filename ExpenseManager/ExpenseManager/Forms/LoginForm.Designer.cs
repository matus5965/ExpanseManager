namespace ExpenseManager
{
    partial class LoginForm
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
            passwordTextBox = new TextBox();
            loginButton = new Button();
            usernameTextBox = new TextBox();
            showPasswordCheckBox = new CheckBox();
            captionLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            gotoRegisterLabel = new Label();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(12, 134);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(218, 30);
            passwordTextBox.TabIndex = 0;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.LightGreen;
            loginButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.Location = new Point(12, 206);
            loginButton.Name = "loginButton";
            loginButton.RightToLeft = RightToLeft.Yes;
            loginButton.Size = new Size(108, 39);
            loginButton.TabIndex = 1;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.White;
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(12, 78);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(218, 27);
            usernameTextBox.TabIndex = 2;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Location = new Point(12, 170);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(134, 24);
            showPasswordCheckBox.TabIndex = 3;
            showPasswordCheckBox.Text = "Show password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // captionLabel
            // 
            captionLabel.AutoSize = true;
            captionLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            captionLabel.Location = new Point(12, 9);
            captionLabel.Name = "captionLabel";
            captionLabel.Size = new Size(77, 35);
            captionLabel.TabIndex = 4;
            captionLabel.Text = "Login";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(12, 55);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 111);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password";
            // 
            // gotoRegisterLabel
            // 
            gotoRegisterLabel.AutoSize = true;
            gotoRegisterLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gotoRegisterLabel.ForeColor = Color.DarkOliveGreen;
            gotoRegisterLabel.Location = new Point(12, 248);
            gotoRegisterLabel.Name = "gotoRegisterLabel";
            gotoRegisterLabel.Size = new Size(177, 20);
            gotoRegisterLabel.TabIndex = 7;
            gotoRegisterLabel.Text = "Do you want to register?";
            gotoRegisterLabel.Click += gotoRegisterLabel_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(336, 276);
            Controls.Add(gotoRegisterLabel);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(captionLabel);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(usernameTextBox);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTextBox;
        private Button loginButton;
        private TextBox usernameTextBox;
        private CheckBox showPasswordCheckBox;
        private Label captionLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private Label gotoRegisterLabel;
    }
}
