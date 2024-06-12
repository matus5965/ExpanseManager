using ExpenseManager.Forms.Controls;
using System.Windows.Forms.DataVisualization.Charting;
using ExpenseManager.DataModels;

namespace ExpenseManager.Forms
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
        }

        private async Task PrintTransactionsAsync(IEnumerable<TransactionControl> transactionsControls, Dictionary<int, string> categories, bool areIncomes)
        {
            balanceChart.Series.Clear();
            var series = new Series
            {
                Name = "Series",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            series.Label = "#VALX: #VALY";
            balanceChart.Series.Add(series);


            Dictionary<string, decimal> categoryIncomes = new Dictionary<string, decimal>();
            await Task.Run(() =>
            {
                foreach (TransactionControl tc in transactionsControls)
                {
                    Transaction t = tc.Transaction;
                    if ((t.Type == TransactionType.Income && areIncomes) || (t.Type == TransactionType.Expense && !areIncomes))
                    {
                        string category = categories[t.Category];
                        decimal amount = categoryIncomes.GetValueOrDefault(category, 0);
                        categoryIncomes[category] = amount + t.Amount;
                    }
                }
            });

            foreach (var categoryIncome in categoryIncomes )
            {
                series.Points.AddXY(categoryIncome.Key, categoryIncome.Value);
            }

            Show();
        }

        public async void PrintIncomesAsync(IEnumerable<TransactionControl> transactionsControls, Dictionary<int, string> categories)
        {
            await PrintTransactionsAsync(transactionsControls, categories, true);
        }

        public async void PrintExpensesAsync(IEnumerable<TransactionControl> transactionsControls, Dictionary<int, string> categories)
        {
            await PrintTransactionsAsync(transactionsControls, categories, false);
        }

        public async void PrintYearBalanceAsync(IEnumerable<TransactionControl> transactionsControls)
        {
            balanceChart.Series.Clear();

            var series = new Series
            {
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };

            balanceChart.Series.Add(series);

            var aggregatedTransactions = await Task.Run(() => transactionsControls
                .Where(t => t.Date.Year == DateTime.Now.Year)
                .GroupBy(t => new { t.Date.Month })
                .Select(g => new
                {
                    Month = g.Key.Month,
                    TotalAmount = g.Sum(t => t.Transaction.Amount * (t.Transaction.Type == TransactionType.Income ? 1 : -1))
                })
                .ToDictionary(g => g.Month)
            );

            double totalSum = 0;
            DateTime startTime = new DateTime(DateTime.Now.Year, 1, 1);
            for (int month = 1; month <= DateTime.Now.Month; month++)
            {
                var monthObject = aggregatedTransactions.GetValueOrDefault(month, null);
                if (monthObject != null)
                {
                    totalSum += (double) monthObject.TotalAmount;
                }

                var point = new DataPoint
                {
                    AxisLabel = startTime.ToString("MMM"),
                    XValue = month,
                    YValues = new double[] { (double) totalSum },
                    Color = totalSum > 0 ? Color.Green : Color.Red
                };

                startTime = startTime.AddMonths(1);
                series.Points.Add(point);
            }

            balanceChart.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true;
            balanceChart.ChartAreas[0].AxisX.LabelStyle.IntervalOffset = 1;

            Show();
        }

        public async void PrintMonthBalanceAsync(IEnumerable<TransactionControl> transactionsControls)
        {
            balanceChart.Series.Clear();

            var series = new Series
            {
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };

            balanceChart.Series.Add(series);

            var aggregatedTransactions = await Task.Run(() => transactionsControls
                .Where(t => t.Date.Year == DateTime.Now.Year && t.Date.Month == DateTime.Now.Month)
                .GroupBy(t => new { t.Date.Day })
                .Select(g => new
                {
                    Month = g.Key.Day,
                    TotalAmount = g.Sum(t => t.Transaction.Amount * (t.Transaction.Type == TransactionType.Income ? 1 : -1))
                })
                .ToDictionary(g => g.Month)
            );

            double totalSum = 0;
            DateTime startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            for (int day = 1; day <= DateTime.Now.Day; day++)
            {
                var dayObject = aggregatedTransactions.GetValueOrDefault(day, null);
                if (dayObject != null)
                {
                    totalSum += (double) dayObject.TotalAmount;
                }

                var point = new DataPoint
                {
                    AxisLabel = startTime.ToString("dd, ddd"),
                    XValue = day,
                    YValues = new double[] { (double)totalSum },
                    Color = totalSum > 0 ? Color.Green : Color.Red
                };

                startTime = startTime.AddDays(1);
                series.Points.Add(point);
            }

            balanceChart.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true;
            balanceChart.ChartAreas[0].AxisX.LabelStyle.IntervalOffset = 1;

            Show();
        }

        private void ChartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
