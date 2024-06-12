using ExpenseManager.DataModels;
using ExpenseManager.SqliteCom;
using ExpenseManager.Forms.Controls;

namespace ExpenseManager.Forms
{
    public partial class TransactionForm : Form
    {
        public Transaction? Transaction;
        public bool Deleted = false;
        private int userID;
        private TransactionControl? transactionControl;

        public TransactionForm(Dictionary<int, string> categories, int userID)
        {
            InitializeComponent();
            InitCombos(categories);
            this.userID = userID;

            deleteButton.Enabled = false;
            deleteButton.Visible = false;
            dateDateTimePicker.Value = DateTime.Now.Date;
        }

        public TransactionForm(Dictionary<int, string> categories, TransactionControl expenseControl)
        {
            InitializeComponent();
            InitCombos(categories);

            this.transactionControl = expenseControl;
            userID = expenseControl.Transaction.UserID;
            typeComboBox.SelectedItem = expenseControl.Transaction.Type;
            categoryComboBox.SelectedIndex = expenseControl.Transaction.Category;
            subjectTextBox.Text = expenseControl.Transaction.Subject;
            amountNumericUpDown.Value = expenseControl.Transaction.Amount;
            dateDateTimePicker.Value = expenseControl.Date;
        }

        private void InitCombos(Dictionary<int, string> categories)
        {
            foreach (TransactionType et in Enum.GetValues(typeof(TransactionType)))
            {
                typeComboBox.Items.Add(et);
            }

            foreach (var pair in categories.OrderBy(pair => pair.Key))
            {
                categoryComboBox.Items.Add(new Item { ID = pair.Key, Text = pair.Value });
            }

            typeComboBox.SelectedIndex = 0;
            categoryComboBox.SelectedIndex = 0;
        }

        private void saveExpenseButton_Click(object sender, EventArgs e)
        {
            if (amountNumericUpDown.Value == 0)
            {
                MessageBox.Show("Transaction of amount \"0\" can not be accepted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (subjectTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Subject not specified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (typeComboBox.SelectedItem == null || categoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Transaction type or category contains invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime date = dateDateTimePicker.Value.Date;
                Transaction = new Transaction
                {
                    UserID = userID,
                    Type = ((TransactionType)typeComboBox.SelectedItem),
                    Category = ((Item)categoryComboBox.SelectedItem).ID,
                    Subject = subjectTextBox.Text,
                    Amount = amountNumericUpDown.Value,
                    Date = date.ToString(SqliteDataAccess.DateFormat)
                };

                if (transactionControl != null)
                {
                    Transaction.ID = transactionControl.Transaction.ID;
                    transactionControl.UpdateTransaction(Transaction);
                }

                Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Deleted = true;
            Close();
        }
    }
}
