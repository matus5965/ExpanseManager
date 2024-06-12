namespace ExpenseManager.Forms
{
    partial class RegisterForm
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
            gotoLoginLabel = new Label();
            passwordRepeatedLabel = new Label();
            usernameLabel = new Label();
            captionLabel = new Label();
            showPasswordCheckBox = new CheckBox();
            usernameTextBox = new TextBox();
            registerButton = new Button();
            passwordRepeatedTextBox = new TextBox();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // gotoLoginLabel
            // 
            gotoLoginLabel.AutoSize = true;
            gotoLoginLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gotoLoginLabel.ForeColor = Color.DarkOliveGreen;
            gotoLoginLabel.Location = new Point(12, 345);
            gotoLoginLabel.Name = "gotoLoginLabel";
            gotoLoginLabel.Size = new Size(160, 20);
            gotoLoginLabel.TabIndex = 15;
            gotoLoginLabel.Text = "Do you want to login?";
            gotoLoginLabel.Click += gotoLoginLabel_Click;
            // 
            // passwordRepeatedLabel
            // 
            passwordRepeatedLabel.AutoSize = true;
            passwordRepeatedLabel.Location = new Point(12, 214);
            passwordRepeatedLabel.Name = "passwordRepeatedLabel";
            passwordRepeatedLabel.Size = new Size(123, 20);
            passwordRepeatedLabel.TabIndex = 14;
            passwordRepeatedLabel.Text = "Repeat password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(12, 105);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 13;
            usernameLabel.Text = "Username";
            // 
            // captionLabel
            // 
            captionLabel.AutoSize = true;
            captionLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            captionLabel.Location = new Point(12, 9);
            captionLabel.Name = "captionLabel";
            captionLabel.Size = new Size(104, 35);
            captionLabel.TabIndex = 12;
            captionLabel.Text = "Register";
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Location = new Point(12, 273);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(140, 24);
            showPasswordCheckBox.TabIndex = 11;
            showPasswordCheckBox.Text = "Show passwords";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.White;
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(12, 128);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(218, 27);
            usernameTextBox.TabIndex = 10;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.LightGreen;
            registerButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerButton.Location = new Point(12, 303);
            registerButton.Name = "registerButton";
            registerButton.RightToLeft = RightToLeft.Yes;
            registerButton.Size = new Size(108, 39);
            registerButton.TabIndex = 9;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // passwordRepeatedTextBox
            // 
            passwordRepeatedTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordRepeatedTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordRepeatedTextBox.Location = new Point(12, 237);
            passwordRepeatedTextBox.Name = "passwordRepeatedTextBox";
            passwordRepeatedTextBox.Size = new Size(218, 30);
            passwordRepeatedTextBox.TabIndex = 8;
            passwordRepeatedTextBox.UseSystemPasswordChar = true;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 52);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.White;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(12, 75);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(218, 27);
            nameTextBox.TabIndex = 16;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 158);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 19;
            passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(12, 181);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(218, 30);
            passwordTextBox.TabIndex = 18;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(336, 372);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(gotoLoginLabel);
            Controls.Add(passwordRepeatedLabel);
            Controls.Add(usernameLabel);
            Controls.Add(captionLabel);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(usernameTextBox);
            Controls.Add(registerButton);
            Controls.Add(passwordRepeatedTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegisterForm";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gotoLoginLabel;
        private Label passwordRepeatedLabel;
        private Label usernameLabel;
        private Label captionLabel;
        private CheckBox showPasswordCheckBox;
        private TextBox usernameTextBox;
        private Button registerButton;
        private TextBox passwordRepeatedTextBox;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
    }
}