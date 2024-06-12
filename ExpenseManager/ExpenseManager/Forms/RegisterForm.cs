using ExpenseManager.DataModels;
using ExpenseManager.SqliteCom;

namespace ExpenseManager.Forms
{
    public partial class RegisterForm : Form
    {
        public User? User { get; private set; }

        private static readonly int PasswoordMinLength = 8;
        private static readonly Color ErrorColor = Color.IndianRed;

        public RegisterForm()
        {
            InitializeComponent();
            Color orgColor = gotoLoginLabel.ForeColor;
            gotoLoginLabel.MouseEnter += (o, e) => gotoLoginLabel.ForeColor = SystemColors.MenuHighlight;
            gotoLoginLabel.MouseLeave += (o, e) => gotoLoginLabel.ForeColor = orgColor;
        }

        public void ResetForm()
        {
            User = null;
            nameTextBox.Text = string.Empty;
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            passwordRepeatedTextBox.Text = string.Empty;
            ResetEntryError();
        }

        private void gotoLoginLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
            passwordRepeatedTextBox.UseSystemPasswordChar = !passwordRepeatedTextBox.UseSystemPasswordChar;
        }

        private void ResetEntryError()
        {
            nameTextBox.BackColor = Color.White;
            usernameTextBox.BackColor = Color.White;
            passwordTextBox.BackColor = Color.White;
            passwordRepeatedTextBox.BackColor = Color.White;
        }

        private void ShowEntryError(TextBox tb, string message = "")
        {
            tb.BackColor = ErrorColor;
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            ResetEntryError();

            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                ShowEntryError(nameTextBox, "Missing name");             
            }
            else if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                ShowEntryError(usernameTextBox, "Missing username");
            }
            else if (SqliteDataAccess.GetUserWithUsername(usernameTextBox.Text) != null)
            {
                ShowEntryError(usernameTextBox, "Username already taken");
            }
            else if (passwordTextBox.Text.Length < PasswoordMinLength)
            {
                ShowEntryError(passwordTextBox, "Password too short, must be at least 8 characters long");
            }
            else if (!passwordTextBox.Text.Equals(passwordRepeatedTextBox.Text))
            {
                ShowEntryError(passwordRepeatedTextBox, "Password verification do not match");
            }
            else
            {
                if (Register())
                {
                    Close();
                }
            }
        }

        private bool Register()
        {
            User user = new User
            {
                Name = nameTextBox.Text,
                Username = usernameTextBox.Text,
                Balance = 0m
            };

            User? addedUser = SqliteDataAccess.AddUser(user, passwordTextBox.Text);
            if (addedUser == null)
            {
                MessageBox.Show("Unexpected error happend. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            User = addedUser;
            return true;
        }
    }
}
