using ExpenseManager.DataModels;
using ExpenseManager.SqliteCom;
using System.Globalization;

namespace ExpenseManager.Forms.Controls
{
    public partial class TransactionControl : UserControl, IComparable<TransactionControl>
    {
        public Transaction Transaction { get; private set; }
        public DateTime Date { get; private set; }

        private MainForm mainForm;
        private Dictionary<int, string> categories;
        private static readonly Color inactiveColor = Color.NavajoWhite;
        private static Color activeColor = ControlPaint.Light(inactiveColor, 0.5f);

        public TransactionControl(Transaction transaction, Dictionary<int, string> categories, MainForm mainForm)
        {
            InitializeComponent();
            this.categories = categories;
            this.mainForm = mainForm;
            SetMouseHandlers();

            Transaction = transaction;
            Date = DateTime.ParseExact(transaction.Date, SqliteDataAccess.DateFormat, CultureInfo.InvariantCulture);

            InitContent();
        }

        private void InitContent()
        {
            subjectLabel.Text = Transaction.Subject;
            categoryLabel.Text = categories[Transaction.Category];
            if (Transaction.Type == TransactionType.Income)
            {
                amountLabel.ForeColor = Color.Green;
                amountLabel.Text = $"+ {Transaction.Amount.ToString("0.00")}";
            }
            else
            {
                amountLabel.ForeColor = Color.Red;
                amountLabel.Text = $"- {Transaction.Amount.ToString("0.00")}";
            }

            dateLabel.Text = Transaction.Date;
        }

        private void SetMouseHandlers()
        {
            Click += (s, e) => expenseControl_Click();
            MouseEnter += (s, e) => { BackColor = activeColor; };
            MouseLeave += (s, e) => { BackColor = inactiveColor; };
            foreach (Control c in Controls)
            {
                c.Click += (s, e) => expenseControl_Click();
                c.MouseEnter += (s, e) => { BackColor = activeColor; };
                c.MouseLeave += (s, e) => { BackColor = inactiveColor; };
            }
        }

        public int CompareTo(TransactionControl? e)
        {
            if (e == null) return -1;

            int c = (-1) * Date.CompareTo(e.Date);
            return c == 0 ? e.Transaction.ID - Transaction.ID : c;
        }

        private void expenseControl_Click()
        {
            Transaction oldTransaction = Transaction;
            TransactionForm transactionForm = new TransactionForm(categories, this);
            transactionForm.ShowDialog();
            if (transactionForm.Deleted)
            {
                mainForm.TransactionUpdate(this, oldTransaction, null);
            }
            else
            {
                mainForm.TransactionUpdate(this, oldTransaction, Transaction);
            }
        }

        public void UpdateTransaction(Transaction transaction)
        {
            Transaction = transaction;
            InitContent();
        }
    }
}
