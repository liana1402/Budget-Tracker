namespace BudgetTracker
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOpenAddTransaction = new System.Windows.Forms.Button();
            this.btnOpenMonthlyRecord = new System.Windows.Forms.Button();
            this.btnOpenMyCategories = new System.Windows.Forms.Button();
            this.btnOpenHelp = new System.Windows.Forms.Button();
            this.btnOpenSettings = new System.Windows.Forms.Button();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.dgvTransactionsList = new System.Windows.Forms.DataGridView();
            this.btnRemoveTransaction = new System.Windows.Forms.Button();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblWeekNumber = new System.Windows.Forms.Label();
            this.dgvWeeklyCategoryTotals = new System.Windows.Forms.DataGridView();
            this.lblWeeklyTotal = new System.Windows.Forms.Label();
            this.txtWeeklyTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyCategoryTotals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenAddTransaction
            // 
            this.btnOpenAddTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.btnOpenAddTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnOpenAddTransaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenAddTransaction.Location = new System.Drawing.Point(16, 10);
            this.btnOpenAddTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenAddTransaction.Name = "btnOpenAddTransaction";
            this.btnOpenAddTransaction.Size = new System.Drawing.Size(100, 32);
            this.btnOpenAddTransaction.TabIndex = 0;
            this.btnOpenAddTransaction.Text = "Add transaction";
            this.btnOpenAddTransaction.UseVisualStyleBackColor = false;
            this.btnOpenAddTransaction.Click += new System.EventHandler(this.btnOpenAddTransaction_Click);
            // 
            // btnOpenMonthlyRecord
            // 
            this.btnOpenMonthlyRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.btnOpenMonthlyRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnOpenMonthlyRecord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenMonthlyRecord.Location = new System.Drawing.Point(128, 10);
            this.btnOpenMonthlyRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenMonthlyRecord.Name = "btnOpenMonthlyRecord";
            this.btnOpenMonthlyRecord.Size = new System.Drawing.Size(100, 32);
            this.btnOpenMonthlyRecord.TabIndex = 1;
            this.btnOpenMonthlyRecord.Text = "Monthly record";
            this.btnOpenMonthlyRecord.UseVisualStyleBackColor = false;
            this.btnOpenMonthlyRecord.Click += new System.EventHandler(this.btnOpenMonthlyRecord_Click);
            // 
            // btnOpenMyCategories
            // 
            this.btnOpenMyCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.btnOpenMyCategories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnOpenMyCategories.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenMyCategories.Location = new System.Drawing.Point(241, 10);
            this.btnOpenMyCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenMyCategories.Name = "btnOpenMyCategories";
            this.btnOpenMyCategories.Size = new System.Drawing.Size(100, 32);
            this.btnOpenMyCategories.TabIndex = 2;
            this.btnOpenMyCategories.Text = "My categories";
            this.btnOpenMyCategories.UseVisualStyleBackColor = false;
            this.btnOpenMyCategories.Click += new System.EventHandler(this.btnOpenMyCategories_Click);
            // 
            // btnOpenHelp
            // 
            this.btnOpenHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.btnOpenHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnOpenHelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenHelp.Location = new System.Drawing.Point(863, 10);
            this.btnOpenHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenHelp.Name = "btnOpenHelp";
            this.btnOpenHelp.Size = new System.Drawing.Size(70, 30);
            this.btnOpenHelp.TabIndex = 3;
            this.btnOpenHelp.Text = "Help";
            this.btnOpenHelp.UseVisualStyleBackColor = false;
            this.btnOpenHelp.Click += new System.EventHandler(this.btnOpenHelp_Click);
            // 
            // btnOpenSettings
            // 
            this.btnOpenSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.btnOpenSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnOpenSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenSettings.Location = new System.Drawing.Point(938, 10);
            this.btnOpenSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenSettings.Name = "btnOpenSettings";
            this.btnOpenSettings.Size = new System.Drawing.Size(70, 30);
            this.btnOpenSettings.TabIndex = 4;
            this.btnOpenSettings.Text = "Settings";
            this.btnOpenSettings.UseVisualStyleBackColor = false;
            this.btnOpenSettings.Click += new System.EventHandler(this.btnOpenSettings_Click);
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCurrentBalance.Location = new System.Drawing.Point(352, 23);
            this.lblCurrentBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(103, 17);
            this.lblCurrentBalance.TabIndex = 5;
            this.lblCurrentBalance.Text = "Current balance:";
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.txtCurrentBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCurrentBalance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCurrentBalance.Location = new System.Drawing.Point(452, 21);
            this.txtCurrentBalance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.ReadOnly = true;
            this.txtCurrentBalance.Size = new System.Drawing.Size(95, 23);
            this.txtCurrentBalance.TabIndex = 6;
            // 
            // dgvTransactionsList
            // 
            this.dgvTransactionsList.AllowUserToAddRows = false;
            this.dgvTransactionsList.AllowUserToDeleteRows = false;
            this.dgvTransactionsList.AllowUserToResizeColumns = false;
            this.dgvTransactionsList.AllowUserToResizeRows = false;
            this.dgvTransactionsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactionsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactionsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactionsList.EnableHeadersVisualStyles = false;
            this.dgvTransactionsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.dgvTransactionsList.Location = new System.Drawing.Point(16, 61);
            this.dgvTransactionsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTransactionsList.MultiSelect = false;
            this.dgvTransactionsList.Name = "dgvTransactionsList";
            this.dgvTransactionsList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactionsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransactionsList.RowHeadersVisible = false;
            this.dgvTransactionsList.RowHeadersWidth = 51;
            this.dgvTransactionsList.RowTemplate.Height = 24;
            this.dgvTransactionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionsList.Size = new System.Drawing.Size(663, 333);
            this.dgvTransactionsList.TabIndex = 7;
            // 
            // btnRemoveTransaction
            // 
            this.btnRemoveTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.btnRemoveTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnRemoveTransaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveTransaction.Location = new System.Drawing.Point(16, 401);
            this.btnRemoveTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveTransaction.Name = "btnRemoveTransaction";
            this.btnRemoveTransaction.Size = new System.Drawing.Size(175, 24);
            this.btnRemoveTransaction.TabIndex = 8;
            this.btnRemoveTransaction.Text = "Remove selected transaction";
            this.btnRemoveTransaction.UseVisualStyleBackColor = false;
            this.btnRemoveTransaction.Click += new System.EventHandler(this.btnRemoveTransaction_Click);
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblWeek.Location = new System.Drawing.Point(708, 61);
            this.lblWeek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(45, 19);
            this.lblWeek.TabIndex = 9;
            this.lblWeek.Text = "Week:";
            // 
            // lblWeekNumber
            // 
            this.lblWeekNumber.AutoSize = true;
            this.lblWeekNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblWeekNumber.Location = new System.Drawing.Point(748, 61);
            this.lblWeekNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeekNumber.Name = "lblWeekNumber";
            this.lblWeekNumber.Size = new System.Drawing.Size(17, 19);
            this.lblWeekNumber.TabIndex = 10;
            this.lblWeekNumber.Text = "1";
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
            this.dgvWeeklyCategoryTotals.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            this.dgvWeeklyCategoryTotals.Location = new System.Drawing.Point(708, 82);
            this.dgvWeeklyCategoryTotals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvWeeklyCategoryTotals.MultiSelect = false;
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
            this.dgvWeeklyCategoryTotals.Size = new System.Drawing.Size(303, 312);
            this.dgvWeeklyCategoryTotals.TabIndex = 11;
            // 
            // lblWeeklyTotal
            // 
            this.lblWeeklyTotal.AutoSize = true;
            this.lblWeeklyTotal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblWeeklyTotal.Location = new System.Drawing.Point(708, 401);
            this.lblWeeklyTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeeklyTotal.Name = "lblWeeklyTotal";
            this.lblWeeklyTotal.Size = new System.Drawing.Size(81, 17);
            this.lblWeeklyTotal.TabIndex = 12;
            this.lblWeeklyTotal.Text = "Weekly total:";
            // 
            // txtWeeklyTotal
            // 
            this.txtWeeklyTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.txtWeeklyTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWeeklyTotal.Location = new System.Drawing.Point(786, 399);
            this.txtWeeklyTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWeeklyTotal.Name = "txtWeeklyTotal";
            this.txtWeeklyTotal.ReadOnly = true;
            this.txtWeeklyTotal.Size = new System.Drawing.Size(106, 23);
            this.txtWeeklyTotal.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1029, 434);
            this.Controls.Add(this.txtWeeklyTotal);
            this.Controls.Add(this.lblWeeklyTotal);
            this.Controls.Add(this.dgvWeeklyCategoryTotals);
            this.Controls.Add(this.lblWeekNumber);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.btnRemoveTransaction);
            this.Controls.Add(this.dgvTransactionsList);
            this.Controls.Add(this.txtCurrentBalance);
            this.Controls.Add(this.lblCurrentBalance);
            this.Controls.Add(this.btnOpenSettings);
            this.Controls.Add(this.btnOpenHelp);
            this.Controls.Add(this.btnOpenMyCategories);
            this.Controls.Add(this.btnOpenMonthlyRecord);
            this.Controls.Add(this.btnOpenAddTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyCategoryTotals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenAddTransaction;
        private System.Windows.Forms.Button btnOpenMonthlyRecord;
        private System.Windows.Forms.Button btnOpenMyCategories;
        private System.Windows.Forms.Button btnOpenHelp;
        private System.Windows.Forms.Button btnOpenSettings;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.DataGridView dgvTransactionsList;
        private System.Windows.Forms.Button btnRemoveTransaction;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblWeekNumber;
        private System.Windows.Forms.DataGridView dgvWeeklyCategoryTotals;
        private System.Windows.Forms.Label lblWeeklyTotal;
        private System.Windows.Forms.TextBox txtWeeklyTotal;
    }
}