namespace ExpenseManager.DataModels
{
    public enum TransactionType
    {
        Income = 0,
        Expense = 1
    }

    public class Transaction
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public TransactionType Type { get; set; }
        public int Category { get; set; }
        public string? Subject { get; set; }
        public decimal Amount { get; set; }
        public string? Date { get; set; }
    }
}
