namespace ExpenseManager.Forms.Controls
{
    partial class TransactionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            subjectLabel = new Label();
            categoryLabel = new Label();
            amountLabel = new Label();
            dateLabel = new Label();
            SuspendLayout();
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subjectLabel.Location = new Point(3, 13);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(94, 31);
            subjectLabel.TabIndex = 0;
            subjectLabel.Text = "Subject";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.BorderStyle = BorderStyle.FixedSingle;
            categoryLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryLabel.Location = new Point(3, 54);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(143, 25);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "ExpenseCategory";
            // 
            // amountLabel
            // 
            amountLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountLabel.Location = new Point(247, 16);
            amountLabel.Name = "amountLabel";
            amountLabel.RightToLeft = RightToLeft.No;
            amountLabel.Size = new Size(183, 38);
            amountLabel.TabIndex = 3;
            amountLabel.Text = "<amount>";
            amountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // dateLabel
            // 
            dateLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(284, 54);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(143, 25);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "<date>";
            dateLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // ExpenseControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            Controls.Add(dateLabel);
            Controls.Add(amountLabel);
            Controls.Add(categoryLabel);
            Controls.Add(subjectLabel);
            Name = "ExpenseControl";
            Size = new Size(430, 82);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label subjectLabel;
        private Label categoryLabel;
        private Label amountLabel;
        private Label dateLabel;
    }
}
