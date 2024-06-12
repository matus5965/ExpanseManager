namespace ExpenseManager.Forms
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            balanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)balanceChart).BeginInit();
            SuspendLayout();
            // 
            // balanceChart
            // 
            chartArea1.Name = "ChartArea1";
            balanceChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            balanceChart.Legends.Add(legend1);
            balanceChart.Location = new Point(12, 12);
            balanceChart.Name = "balanceChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            balanceChart.Series.Add(series1);
            balanceChart.Size = new Size(776, 426);
            balanceChart.TabIndex = 0;
            balanceChart.Text = "balanceChart";
            // 
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(balanceChart);
            Name = "ChartForm";
            Text = "Chart";
            FormClosing += ChartForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)balanceChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart balanceChart;
    }
}