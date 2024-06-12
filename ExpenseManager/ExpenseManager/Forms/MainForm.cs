using ExpenseManager.DataModels;
using ExpenseManager.Forms.Controls;
using AForge.Imaging.Filters;
using ExpenseManager.SqliteCom;
using ExpenseManager.Utils;
using System.Globalization;

namespace ExpenseManager.Forms
{
    public partial class MainForm : Form
    {
        public static readonly int BasicCategoryCount = 7;

        private User user;
        private Dictionary<int, string> categories = new Dictionary<int, string>()
        {
            { 0, "Bývanie" },
            { 1, "Stravovanie" },
            { 2, "Cestovanie" },
            { 3, "Zábava" },
            { 4, "Práca" },
            { 5, "Investície" },
            { 6, "Nezaradené" }
        };

        private SortedSet<TransactionControl> transactionsControls = new SortedSet<TransactionControl>();
        private Bitmap inactiveLogout;
        private Bitmap activeLogout;
        private ChartForm chartForm = new ChartForm();

        private static readonly int RefreshButtonEnlarge = 6;

        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;

            inactiveLogout = (Bitmap)logoutPictureBox.Image;
            activeLogout = new BrightnessCorrection(100).Apply(inactiveLogout);

            logoutPictureBox.MouseEnter += logoutPictureBox_MouseEnter;
            logoutPictureBox.MouseLeave += logoutPictureBox_MouseLeave;
            logoutPictureBox.Click += (s, e) => Close();
            InitContent();
        }

        private void InitContent()
        {
            nameLabel.Text = user.Name;
            UpdateUserBalance();

            minAmountNumericUpDown.Enabled = false;
            maxAmountNumericUpDown.Enabled = false;

            chartTypeComboBox.Items.Add(new Item { ID = 0, Text = "Total expense in categories" });
            chartTypeComboBox.Items.Add(new Item { ID = 1, Text = "Total income in categories" });
            chartTypeComboBox.Items.Add(new Item { ID = 2, Text = "Year balance graph" });
            chartTypeComboBox.Items.Add(new Item { ID = 3, Text = "Month balance graph" });
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            List<Transaction> transactions = await Task.Run(() => SqliteDataAccess.GetTransactions(user.ID));

            await Task.Run(() =>
            {
                foreach (var c in SqliteDataAccess.GetCategories(user.ID))
                {
                    categories.Add(c.ID, c.Name);
                }
            });

            await Task.Run(() =>
            {
                foreach (var e in transactions)
                {
                    TransactionControl ec = new TransactionControl(e, categories, this);
                    transactionsControls.Add(ec);
                }
            });

            RefreshTransactions();

            foreach (var pair in categories)
            {
                filterCategoriesCheckedListBox.Items.Add(new Item { ID = pair.Key, Text = pair.Value });
            }
        }

        private void UpdateUserBalance()
        {
            if (user.Balance >= 0)
            {
                balanceLabel.ForeColor = Color.Green;
                balanceLabel.Text = $"+{user.Balance.ToString("0.00")}";
            }
            else
            {
                balanceLabel.ForeColor = Color.Red;
                balanceLabel.Text = $"{user.Balance.ToString("0.00")}";
            }
        }

        private void logoutPictureBox_MouseEnter(object? sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(logoutPictureBox, "Click to log-out");
            logoutPictureBox.Image = activeLogout;
        }

        private void logoutPictureBox_MouseLeave(object? sender, EventArgs e)
        {
            logoutPictureBox.Image = inactiveLogout;
        }

        private async void newExpenseButton_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(categories, user.ID);
            transactionForm.ShowDialog();
            if (transactionForm.Transaction != null)
            {
                await Task.Run(() => AddTransaction(transactionForm.Transaction));
            }

            UpdateUserBalance();
        }

        private void AddTransaction(Transaction transaction)
        {
            int newID = SqliteDataAccess.AddTransaction(transaction);
            if (newID != -1)
            {
                user.Balance += transaction.Type == TransactionType.Income ? transaction.Amount : (-1) * transaction.Amount;
                transaction.ID = newID;

                TransactionControl ec = new TransactionControl(transaction, categories, this);
                transactionsControls.Add(ec);
            }
        }

        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
            RefreshTransactions();
        }

        private bool IsNotFiltered(Transaction e)
        {
            return ((e.Type == TransactionType.Income && filterIncomesCheckBox.Checked) || (e.Type == TransactionType.Expense && filterExpensesCheckBox.Checked)) &&
                   filterCategoriesCheckedListBox.Invoke(() =>
                        filterCategoriesCheckedListBox.CheckedItems.Count == 0 || filterCategoriesCheckedListBox.CheckedItems.Contains(Item.GetWithID(e.Category))) &&
                   ((!useMinAmountCheckBox.Checked || e.Amount >= minAmountNumericUpDown.Value) && (!useMaxAmountCheckBox.Checked || e.Amount <= maxAmountNumericUpDown.Value));
        }

        private async void RefreshTransactions()
        {
            transactionsFlowLayoutPanel.Controls.Clear();

            decimal total = 0m;
            int count = 0;
            await Task.Run(() =>
            {
                foreach (var ec in transactionsControls)
                {
                    if (IsNotFiltered(ec.Transaction))
                    {
                        transactionsFlowLayoutPanel.Invoke(() => transactionsFlowLayoutPanel.Controls.Add(ec));
                        count++;
                        if (ec.Transaction.Type == TransactionType.Income)
                        {
                            total += ec.Transaction.Amount;
                        }
                        else
                        {
                            total -= ec.Transaction.Amount;
                        }
                    }
                }
            });

            if (total >= 0)
            {
                transactionsTotalLabel.ForeColor = Color.Green;
                transactionsTotalLabel.Text = $"+{total.ToString("0.00")}";
            }
            else
            {
                transactionsTotalLabel.ForeColor = Color.Red;
                transactionsTotalLabel.Text = $"{total.ToString("0.00")}";
            }

            transactionsCountLabel.Text = count.ToString();
        }

        private void refreshPictureBox_MouseEnter(object? sender, EventArgs e)
        {
            Size oldSize = refreshPictureBox.Size;
            refreshPictureBox.Size = new Size(oldSize.Width + RefreshButtonEnlarge, oldSize.Height + RefreshButtonEnlarge);
            Point location = refreshPictureBox.Location;
            refreshPictureBox.Location = new Point(location.X - RefreshButtonEnlarge / 2, location.Y - RefreshButtonEnlarge / 2);
        }

        private void refreshPictureBox_MouseLeave(object? sender, EventArgs e)
        {
            Size oldSize = refreshPictureBox.Size;
            refreshPictureBox.Size = new Size(oldSize.Width - RefreshButtonEnlarge, oldSize.Height - RefreshButtonEnlarge);
            Point location = refreshPictureBox.Location;
            refreshPictureBox.Location = new Point(location.X + RefreshButtonEnlarge / 2, location.Y + RefreshButtonEnlarge / 2);
        }

        private void useMinAmountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            minAmountNumericUpDown.Enabled = !minAmountNumericUpDown.Enabled;
        }

        private void useMaxAmountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            maxAmountNumericUpDown.Enabled = !maxAmountNumericUpDown.Enabled;
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            string categoryName = addCategoryTextBox.Text.Trim();

            if (categoryName.Equals(string.Empty)) return;

            if (categories.Values.Contains(categoryName, StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show("Same category was already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Category newCategory = new Category { ID = categories.Count, UserID = user.ID, Name = categoryName };
            SqliteDataAccess.AddCategory(newCategory);
            MessageBox.Show("New category added");
            categories.Add(categories.Count, newCategory.Name);
            filterCategoriesCheckedListBox.Items.Add(new Item { ID = newCategory.ID, Text = newCategory.Name });
        }

        public void TransactionUpdate(TransactionControl ec, Transaction oldExpense, Transaction? newExpense)
        {
            if (newExpense == null)
            {
                SqliteDataAccess.DeleteTransactions(oldExpense);
                transactionsControls.Remove(ec);
                transactionsFlowLayoutPanel.Controls.Remove(ec);
            }
            else
            {
                if (newExpense.Type == TransactionType.Income)
                {
                    user.Balance += newExpense.Amount;
                }
                else
                {
                    user.Balance -= newExpense.Amount;
                }

                SqliteDataAccess.EditTransactions(oldExpense, newExpense);
            }

            if (oldExpense.Type == TransactionType.Income)
            {
                user.Balance -= oldExpense.Amount;
            }
            else
            {
                user.Balance += oldExpense.Amount;
            }

            UpdateUserBalance();
        }

        private void showChartButton_Click(object sender, EventArgs e)
        {
            Item? item = (Item?)chartTypeComboBox.SelectedItem;
            if (item != null)
            {
                switch (item.ID)
                {
                    case 0: chartForm.PrintExpensesAsync(transactionsControls, categories); break;
                    case 1: chartForm.PrintIncomesAsync(transactionsControls, categories); break;
                    case 2: chartForm.PrintYearBalanceAsync(transactionsControls); break;
                    case 3: chartForm.PrintMonthBalanceAsync(transactionsControls); break;
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            chartForm.Close();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            JSONUtils.ExportAsync(transactionsControls, categories);
        }
    }
}
