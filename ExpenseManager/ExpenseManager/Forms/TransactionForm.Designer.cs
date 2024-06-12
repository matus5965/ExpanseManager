namespace ExpenseManager.Forms
{
    partial class TransactionForm
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
            label3 = new Label();
            amountNumericUpDown = new NumericUpDown();
            subjectTextBox = new TextBox();
            label2 = new Label();
            categoryComboBox = new ComboBox();
            label1 = new Label();
            typeComboBox = new ComboBox();
            expenseTypeLabel = new Label();
            dateDateTimePicker = new DateTimePicker();
            label4 = new Label();
            saveButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)amountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 118);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 21;
            label3.Text = "Amount:";
            // 
            // amountNumericUpDown
            // 
            amountNumericUpDown.DecimalPlaces = 2;
            amountNumericUpDown.Location = new Point(98, 114);
            amountNumericUpDown.Maximum = new decimal(new int[] { 1215752191, 23, 0, 131072 });
            amountNumericUpDown.Name = "amountNumericUpDown";
            amountNumericUpDown.Size = new Size(151, 27);
            amountNumericUpDown.TabIndex = 14;
            amountNumericUpDown.ThousandsSeparator = true;
            // 
            // subjectTextBox
            // 
            subjectTextBox.Location = new Point(98, 81);
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.RightToLeft = RightToLeft.No;
            subjectTextBox.Size = new Size(151, 27);
            subjectTextBox.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 85);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 20;
            label2.Text = "Subject:";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(98, 47);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(151, 28);
            categoryComboBox.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 52);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 19;
            label1.Text = "Category:";
            // 
            // typeComboBox
            // 
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(98, 12);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(151, 28);
            typeComboBox.TabIndex = 16;
            // 
            // expenseTypeLabel
            // 
            expenseTypeLabel.AutoSize = true;
            expenseTypeLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expenseTypeLabel.Location = new Point(42, 17);
            expenseTypeLabel.Name = "expenseTypeLabel";
            expenseTypeLabel.Size = new Size(50, 23);
            expenseTypeLabel.TabIndex = 17;
            expenseTypeLabel.Text = "Type:";
            // 
            // dateDateTimePicker
            // 
            dateDateTimePicker.Format = DateTimePickerFormat.Short;
            dateDateTimePicker.Location = new Point(98, 147);
            dateDateTimePicker.Name = "dateDateTimePicker";
            dateDateTimePicker.Size = new Size(151, 27);
            dateDateTimePicker.TabIndex = 22;
            dateDateTimePicker.Value = new DateTime(2024, 5, 7, 2, 45, 37, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 151);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 23;
            label4.Text = "Date:";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LightGreen;
            saveButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(155, 180);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 38);
            saveButton.TabIndex = 24;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveExpenseButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(22, 180);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 38);
            deleteButton.TabIndex = 25;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(267, 228);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(label4);
            Controls.Add(dateDateTimePicker);
            Controls.Add(label3);
            Controls.Add(amountNumericUpDown);
            Controls.Add(subjectTextBox);
            Controls.Add(label2);
            Controls.Add(categoryComboBox);
            Controls.Add(label1);
            Controls.Add(typeComboBox);
            Controls.Add(expenseTypeLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TransactionForm";
            Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)amountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private NumericUpDown amountNumericUpDown;
        private TextBox subjectTextBox;
        private Label label2;
        private ComboBox categoryComboBox;
        private Label label1;
        private ComboBox typeComboBox;
        private Label expenseTypeLabel;
        private DateTimePicker dateDateTimePicker;
        private Label label4;
        private Button saveButton;
        private Button deleteButton;
    }
}