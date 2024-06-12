using ExpenseManager.Forms;
using ExpenseManager.DataModels;
using ExpenseManager.Utils;
using System.Windows.Forms;
using ExpenseManager.SqliteCom;

namespace ExpenseManager
{
    public partial class LoginForm : Form
    {
        private RegisterForm? registerForm;
        private static readonly Color ErrorColor = Color.IndianRed;

        public LoginForm()
        {
            InitializeComponent();
            Color orgColor = gotoRegisterLabel.ForeColor;
            gotoRegisterLabel.MouseEnter += (o, e) => gotoRegisterLabel.ForeColor = SystemColors.MenuHighlight;
            gotoRegisterLabel.MouseLeave += (o, e) => gotoRegisterLabel.ForeColor = orgColor;
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
        }

        private void gotoRegisterLabel_Click(object sender, EventArgs e)
        {
            if (registerForm == null)
            {
                registerForm = new RegisterForm();
            }

            Hide();
            registerForm.ShowDialog();
            Show();
            if (registerForm.User != null)
            {
                User user = registerForm.User;
                registerForm.ResetForm();
                Login(user);
            }
        }

        private void ResetForm()
        {
            ResetEntryError();
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }

        private void ResetEntryError()
        {
            usernameTextBox.BackColor = Color.White;
            passwordTextBox.BackColor = Color.White;
        }

        private void ShowEntryError(TextBox tb, string message = "Entry error")
        {
            tb.BackColor = ErrorColor;
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ResetEntryError();

            if (usernameTextBox.Text.Length == 0)
            {
                ShowEntryError(usernameTextBox, "Username missing");
            }
            else if (passwordTextBox.Text.Length == 0)
            {
                ShowEntryError(passwordTextBox, "Password missing");
            }
            else if (!PasswordUtils.VerifyUserPassword(usernameTextBox.Text, passwordTextBox.Text))
            {
                usernameTextBox.BackColor = ErrorColor;
                passwordTextBox.BackColor = ErrorColor;
                MessageBox.Show("Wrong user or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User? user = SqliteDataAccess.GetUserWithUsername(usernameTextBox.Text);
                
                if (user == null)
                {
                    MessageBox.Show("Unexpected error happend. Try again");

                }
                else
                {
                    Login(user);
                }
            }
        }

        private void Login(User user)
        {
            MainForm mainForm = new MainForm(user);
            Hide();
            mainForm.ShowDialog();
            ResetForm();
            Show();
        }
    }
}
