namespace ExpenseManager.Forms
{
    partial class MainForm
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
            logoutPictureBox = new PictureBox();
            nameLabel = new Label();
            historyLabel = new Label();
            transactionsFlowLayoutPanel = new FlowLayoutPanel();
            balanceLabel = new Label();
            transactionsTotalCaption = new Label();
            transactionsCountCaption = new Label();
            transactionsTotalLabel = new Label();
            transactionsCountLabel = new Label();
            newTransactionButton = new Button();
            addCategoryButton = new Button();
            addCategoryTextBox = new TextBox();
            exportButton = new Button();
            refreshPictureBox = new PictureBox();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            filterIncomesCheckBox = new CheckBox();
            filterExpensesCheckBox = new CheckBox();
            filterCategoriesCheckedListBox = new CheckedListBox();
            useMinAmountCheckBox = new CheckBox();
            useMaxAmountCheckBox = new CheckBox();
            minAmountNumericUpDown = new NumericUpDown();
            maxAmountNumericUpDown = new NumericUpDown();
            panel1 = new Panel();
            chartTypeComboBox = new ComboBox();
            showChartButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)refreshPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minAmountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxAmountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // logoutPictureBox
            // 
            logoutPictureBox.Image = Properties.Resources.logout;
            logoutPictureBox.Location = new Point(12, 12);
            logoutPictureBox.Name = "logoutPictureBox";
            logoutPictureBox.Size = new Size(41, 41);
            logoutPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoutPictureBox.TabIndex = 0;
            logoutPictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(59, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(164, 38);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name Label";
            // 
            // historyLabel
            // 
            historyLabel.AutoSize = true;
            historyLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            historyLabel.Location = new Point(322, 15);
            historyLabel.Name = "historyLabel";
            historyLabel.Size = new Size(105, 38);
            historyLabel.TabIndex = 3;
            historyLabel.Text = "History";
            // 
            // transactionsFlowLayoutPanel
            // 
            transactionsFlowLayoutPanel.AutoScroll = true;
            transactionsFlowLayoutPanel.Location = new Point(322, 59);
            transactionsFlowLayoutPanel.Name = "transactionsFlowLayoutPanel";
            transactionsFlowLayoutPanel.Size = new Size(466, 364);
            transactionsFlowLayoutPanel.TabIndex = 4;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            balanceLabel.Location = new Point(12, 73);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(279, 46);
            balanceLabel.TabIndex = 0;
            balanceLabel.Text = "<total_balance>";
            // 
            // transactionsTotalCaption
            // 
            transactionsTotalCaption.AutoSize = true;
            transactionsTotalCaption.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transactionsTotalCaption.Location = new Point(321, 448);
            transactionsTotalCaption.Name = "transactionsTotalCaption";
            transactionsTotalCaption.Size = new Size(56, 25);
            transactionsTotalCaption.TabIndex = 5;
            transactionsTotalCaption.Text = "Total:";
            // 
            // transactionsCountCaption
            // 
            transactionsCountCaption.AutoSize = true;
            transactionsCountCaption.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transactionsCountCaption.Location = new Point(321, 473);
            transactionsCountCaption.Name = "transactionsCountCaption";
            transactionsCountCaption.Size = new Size(67, 25);
            transactionsCountCaption.TabIndex = 6;
            transactionsCountCaption.Text = "Count:";
            // 
            // transactionsTotalLabel
            // 
            transactionsTotalLabel.AutoSize = true;
            transactionsTotalLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            transactionsTotalLabel.Location = new Point(373, 448);
            transactionsTotalLabel.Name = "transactionsTotalLabel";
            transactionsTotalLabel.Size = new Size(97, 25);
            transactionsTotalLabel.TabIndex = 7;
            transactionsTotalLabel.Text = "<decimal>";
            // 
            // transactionsCountLabel
            // 
            transactionsCountLabel.AutoSize = true;
            transactionsCountLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            transactionsCountLabel.Location = new Point(386, 473);
            transactionsCountLabel.Name = "transactionsCountLabel";
            transactionsCountLabel.Size = new Size(91, 25);
            transactionsCountLabel.TabIndex = 8;
            transactionsCountLabel.Text = "<integer>";
            // 
            // newTransactionButton
            // 
            newTransactionButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newTransactionButton.Location = new Point(12, 139);
            newTransactionButton.Name = "newTransactionButton";
            newTransactionButton.Size = new Size(211, 33);
            newTransactionButton.TabIndex = 0;
            newTransactionButton.Text = "New transaction";
            newTransactionButton.UseVisualStyleBackColor = true;
            newTransactionButton.Click += newExpenseButton_Click;
            // 
            // addCategoryButton
            // 
            addCategoryButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCategoryButton.Location = new Point(12, 203);
            addCategoryButton.Name = "addCategoryButton";
            addCategoryButton.Size = new Size(211, 33);
            addCategoryButton.TabIndex = 9;
            addCategoryButton.Text = "Add category";
            addCategoryButton.UseVisualStyleBackColor = true;
            addCategoryButton.Click += addCategoryButton_Click;
            // 
            // addCategoryTextBox
            // 
            addCategoryTextBox.Location = new Point(12, 242);
            addCategoryTextBox.MaxLength = 20;
            addCategoryTextBox.Name = "addCategoryTextBox";
            addCategoryTextBox.Size = new Size(211, 27);
            addCategoryTextBox.TabIndex = 0;
            // 
            // exportButton
            // 
            exportButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exportButton.Location = new Point(12, 305);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(211, 33);
            exportButton.TabIndex = 11;
            exportButton.Text = "Export transactions";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // refreshPictureBox
            // 
            refreshPictureBox.Image = Properties.Resources.refresh;
            refreshPictureBox.Location = new Point(763, 28);
            refreshPictureBox.Name = "refreshPictureBox";
            refreshPictureBox.Size = new Size(25, 25);
            refreshPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            refreshPictureBox.TabIndex = 14;
            refreshPictureBox.TabStop = false;
            refreshPictureBox.Click += refreshPictureBox_Click;
            refreshPictureBox.MouseEnter += refreshPictureBox_MouseEnter;
            refreshPictureBox.MouseLeave += refreshPictureBox_MouseLeave;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(32, 19);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            // 
            // filterIncomesCheckBox
            // 
            filterIncomesCheckBox.AutoSize = true;
            filterIncomesCheckBox.Checked = true;
            filterIncomesCheckBox.CheckState = CheckState.Checked;
            filterIncomesCheckBox.Location = new Point(603, 443);
            filterIncomesCheckBox.Name = "filterIncomesCheckBox";
            filterIncomesCheckBox.Size = new Size(86, 24);
            filterIncomesCheckBox.TabIndex = 15;
            filterIncomesCheckBox.Text = "Incomes";
            filterIncomesCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterExpensesCheckBox
            // 
            filterExpensesCheckBox.AutoSize = true;
            filterExpensesCheckBox.Checked = true;
            filterExpensesCheckBox.CheckState = CheckState.Checked;
            filterExpensesCheckBox.Location = new Point(695, 443);
            filterExpensesCheckBox.Name = "filterExpensesCheckBox";
            filterExpensesCheckBox.Size = new Size(91, 24);
            filterExpensesCheckBox.TabIndex = 16;
            filterExpensesCheckBox.Text = "Expenses";
            filterExpensesCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterCategoriesCheckedListBox
            // 
            filterCategoriesCheckedListBox.BackColor = SystemColors.Window;
            filterCategoriesCheckedListBox.CheckOnClick = true;
            filterCategoriesCheckedListBox.FormattingEnabled = true;
            filterCategoriesCheckedListBox.Location = new Point(600, 473);
            filterCategoriesCheckedListBox.Name = "filterCategoriesCheckedListBox";
            filterCategoriesCheckedListBox.Size = new Size(193, 92);
            filterCategoriesCheckedListBox.TabIndex = 17;
            // 
            // useMinAmountCheckBox
            // 
            useMinAmountCheckBox.AutoSize = true;
            useMinAmountCheckBox.Location = new Point(483, 443);
            useMinAmountCheckBox.Name = "useMinAmountCheckBox";
            useMinAmountCheckBox.Size = new Size(94, 24);
            useMinAmountCheckBox.TabIndex = 18;
            useMinAmountCheckBox.Text = "Minimum";
            useMinAmountCheckBox.UseVisualStyleBackColor = true;
            useMinAmountCheckBox.CheckedChanged += useMinAmountCheckBox_CheckedChanged;
            // 
            // useMaxAmountCheckBox
            // 
            useMaxAmountCheckBox.AutoSize = true;
            useMaxAmountCheckBox.Location = new Point(483, 508);
            useMaxAmountCheckBox.Name = "useMaxAmountCheckBox";
            useMaxAmountCheckBox.Size = new Size(97, 24);
            useMaxAmountCheckBox.TabIndex = 19;
            useMaxAmountCheckBox.Text = "Maximum";
            useMaxAmountCheckBox.UseVisualStyleBackColor = true;
            useMaxAmountCheckBox.CheckedChanged += useMaxAmountCheckBox_CheckedChanged;
            // 
            // minAmountNumericUpDown
            // 
            minAmountNumericUpDown.DecimalPlaces = 2;
            minAmountNumericUpDown.ImeMode = ImeMode.NoControl;
            minAmountNumericUpDown.Location = new Point(483, 475);
            minAmountNumericUpDown.Maximum = new decimal(new int[] { 1215752191, 23, 0, 131072 });
            minAmountNumericUpDown.Name = "minAmountNumericUpDown";
            minAmountNumericUpDown.Size = new Size(111, 27);
            minAmountNumericUpDown.TabIndex = 20;
            // 
            // maxAmountNumericUpDown
            // 
            maxAmountNumericUpDown.DecimalPlaces = 2;
            maxAmountNumericUpDown.Location = new Point(483, 538);
            maxAmountNumericUpDown.Maximum = new decimal(new int[] { 1215752191, 23, 0, 131072 });
            maxAmountNumericUpDown.Name = "maxAmountNumericUpDown";
            maxAmountNumericUpDown.Size = new Size(111, 27);
            maxAmountNumericUpDown.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSlateGray;
            panel1.Location = new Point(321, 429);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 10);
            panel1.TabIndex = 22;
            // 
            // chartTypeComboBox
            // 
            chartTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            chartTypeComboBox.FormattingEnabled = true;
            chartTypeComboBox.Location = new Point(12, 411);
            chartTypeComboBox.Name = "chartTypeComboBox";
            chartTypeComboBox.Size = new Size(211, 28);
            chartTypeComboBox.TabIndex = 23;
            // 
            // showChartButton
            // 
            showChartButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showChartButton.Location = new Point(12, 371);
            showChartButton.Name = "showChartButton";
            showChartButton.Size = new Size(211, 29);
            showChartButton.TabIndex = 24;
            showChartButton.Text = "Show chart";
            showChartButton.UseVisualStyleBackColor = true;
            showChartButton.Click += showChartButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 574);
            Controls.Add(showChartButton);
            Controls.Add(chartTypeComboBox);
            Controls.Add(panel1);
            Controls.Add(maxAmountNumericUpDown);
            Controls.Add(minAmountNumericUpDown);
            Controls.Add(useMaxAmountCheckBox);
            Controls.Add(useMinAmountCheckBox);
            Controls.Add(filterCategoriesCheckedListBox);
            Controls.Add(filterExpensesCheckBox);
            Controls.Add(filterIncomesCheckBox);
            Controls.Add(refreshPictureBox);
            Controls.Add(exportButton);
            Controls.Add(addCategoryTextBox);
            Controls.Add(addCategoryButton);
            Controls.Add(newTransactionButton);
            Controls.Add(transactionsCountLabel);
            Controls.Add(transactionsTotalLabel);
            Controls.Add(transactionsCountCaption);
            Controls.Add(transactionsTotalCaption);
            Controls.Add(balanceLabel);
            Controls.Add(transactionsFlowLayoutPanel);
            Controls.Add(historyLabel);
            Controls.Add(nameLabel);
            Controls.Add(logoutPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Transactions";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)refreshPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)minAmountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxAmountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoutPictureBox;
        private Label nameLabel;
        private Label historyLabel;
        private FlowLayoutPanel transactionsFlowLayoutPanel;
        private Label balanceLabel;
        private Label transactionsTotalCaption;
        private Label transactionsCountCaption;
        private Label transactionsTotalLabel;
        private Label transactionsCountLabel;
        private Button newTransactionButton;
        private Button addCategoryButton;
        private TextBox addCategoryTextBox;
        private Button exportButton;
        private PictureBox refreshPictureBox;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripTextBox toolStripTextBox1;
        private CheckBox filterIncomesCheckBox;
        private CheckBox filterExpensesCheckBox;
        private CheckedListBox filterCategoriesCheckedListBox;
        private CheckBox useMinAmountCheckBox;
        private CheckBox useMaxAmountCheckBox;
        private NumericUpDown minAmountNumericUpDown;
        private NumericUpDown maxAmountNumericUpDown;
        private Panel panel1;
        private ComboBox chartTypeComboBox;
        private Button showChartButton;
    }
}