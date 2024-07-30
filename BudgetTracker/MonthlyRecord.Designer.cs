namespace BudgetTracker
{
    partial class MonthlyRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSelectedMonth = new System.Windows.Forms.ComboBox();
            this.dgvWeeklyCategoryTotals = new System.Windows.Forms.DataGridView();
            this.btnViewChart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBudgetOfMonth = new System.Windows.Forms.TextBox();
            this.txtTotalIncome = new System.Windows.Forms.TextBox();
            this.txtTotalExpense = new System.Windows.Forms.TextBox();
            this.txtTotalProfit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyCategoryTotals)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Show data from:";
            // 
            // cbSelectedMonth
            // 
            this.cbSelectedMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.cbSelectedMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbSelectedMonth.FormattingEnabled = true;
            this.cbSelectedMonth.Location = new System.Drawing.Point(113, 48);
            this.cbSelectedMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSelectedMonth.Name = "cbSelectedMonth";
            this.cbSelectedMonth.Size = new System.Drawing.Size(114, 23);
            this.cbSelectedMonth.TabIndex = 2;
            this.cbSelectedMonth.SelectedIndexChanged += new System.EventHandler(this.cbSelectedMonth_SelectedIndexChanged);
            // 
            // dgvWeeklyCategoryTotals
            // 
            this.dgvWeeklyCategoryTotals.AllowUserToAddRows = false;
            this.dgvWeeklyCategoryTotals.AllowUserToDeleteRows = false;
            this.dgvWeeklyCategoryTotals.AllowUserToResizeColumns = false;
            this.dgvWeeklyCategoryTotals.AllowUserToResizeRows = false;
            this.dgvWeeklyCategoryTotals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWeeklyCategoryTotals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWeeklyCategoryTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWeeklyCategoryTotals.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWeeklyCategoryTotals.EnableHeadersVisualStyles = false;
            this.dgvWeeklyCategoryTotals.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.dgvWeeklyCategoryTotals.Location = new System.Drawing.Point(20, 80);
            this.dgvWeeklyCategoryTotals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvWeeklyCategoryTotals.Name = "dgvWeeklyCategoryTotals";
            this.dgvWeeklyCategoryTotals.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWeeklyCategoryTotals.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvWeeklyCategoryTotals.RowHeadersVisible = false;
            this.dgvWeeklyCategoryTotals.RowHeadersWidth = 51;
            this.dgvWeeklyCategoryTotals.RowTemplate.Height = 24;
            this.dgvWeeklyCategoryTotals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWeeklyCategoryTotals.Size = new System.Drawing.Size(306, 265);
            this.dgvWeeklyCategoryTotals.TabIndex = 12;
            // 
            // btnViewChart
            // 
            this.btnViewChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.btnViewChart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewChart.Location = new System.Drawing.Point(474, 15);
            this.btnViewChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewChart.Name = "btnViewChart";
            this.btnViewChart.Size = new System.Drawing.Size(77, 27);
            this.btnViewChart.TabIndex = 13;
            this.btnViewChart.Text = "View chart";
            this.btnViewChart.UseVisualStyleBackColor = false;
            this.btnViewChart.Click += new System.EventHandler(this.btnViewChart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label3.Location = new System.Drawing.Point(345, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Budget of month:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label4.Location = new System.Drawing.Point(345, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total income:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label5.Location = new System.Drawing.Point(345, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total expense:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label6.Location = new System.Drawing.Point(345, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total profit:";
            // 
            // txtBudgetOfMonth
            // 
            this.txtBudgetOfMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.txtBudgetOfMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBudgetOfMonth.Location = new System.Drawing.Point(458, 97);
            this.txtBudgetOfMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBudgetOfMonth.Name = "txtBudgetOfMonth";
            this.txtBudgetOfMonth.ReadOnly = true;
            this.txtBudgetOfMonth.Size = new System.Drawing.Size(95, 23);
            this.txtBudgetOfMonth.TabIndex = 18;
            // 
            // txtTotalIncome
            // 
            this.txtTotalIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.txtTotalIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalIncome.Location = new System.Drawing.Point(458, 134);
            this.txtTotalIncome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalIncome.Name = "txtTotalIncome";
            this.txtTotalIncome.ReadOnly = true;
            this.txtTotalIncome.Size = new System.Drawing.Size(95, 23);
            this.txtTotalIncome.TabIndex = 19;
            // 
            // txtTotalExpense
            // 
            this.txtTotalExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.txtTotalExpense.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalExpense.Location = new System.Drawing.Point(458, 161);
            this.txtTotalExpense.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalExpense.Name = "txtTotalExpense";
            this.txtTotalExpense.ReadOnly = true;
            this.txtTotalExpense.Size = new System.Drawing.Size(95, 23);
            this.txtTotalExpense.TabIndex = 20;
            // 
            // txtTotalProfit
            // 
            this.txtTotalProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.txtTotalProfit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalProfit.Location = new System.Drawing.Point(458, 213);
            this.txtTotalProfit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalProfit.Name = "txtTotalProfit";
            this.txtTotalProfit.ReadOnly = true;
            this.txtTotalProfit.Size = new System.Drawing.Size(95, 23);
            this.txtTotalProfit.TabIndex = 21;
            // 
            // MonthlyRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(570, 358);
            this.Controls.Add(this.txtTotalProfit);
            this.Controls.Add(this.txtTotalExpense);
            this.Controls.Add(this.txtTotalIncome);
            this.Controls.Add(this.txtBudgetOfMonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnViewChart);
            this.Controls.Add(this.dgvWeeklyCategoryTotals);
            this.Controls.Add(this.cbSelectedMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MonthlyRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthlyRecord";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyCategoryTotals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSelectedMonth;
        private System.Windows.Forms.DataGridView dgvWeeklyCategoryTotals;
        private System.Windows.Forms.Button btnViewChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBudgetOfMonth;
        private System.Windows.Forms.TextBox txtTotalIncome;
        private System.Windows.Forms.TextBox txtTotalExpense;
        private System.Windows.Forms.TextBox txtTotalProfit;
    }
}