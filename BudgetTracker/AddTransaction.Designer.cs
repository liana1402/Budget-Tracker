namespace BudgetTracker
{
    partial class AddTransaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbWeekly = new System.Windows.Forms.CheckBox();
            this.cbMonthly = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpNewTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.cbNewTransactionCategory = new System.Windows.Forms.ComboBox();
            this.txtNewTransactionDescription = new System.Windows.Forms.TextBox();
            this.nudNewTransactionAmount = new System.Windows.Forms.NumericUpDown();
            this.cbIncome = new System.Windows.Forms.CheckBox();
            this.cbExpense = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewTransactionAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "New transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label4.Location = new System.Drawing.Point(16, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label5.Location = new System.Drawing.Point(16, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label6.Location = new System.Drawing.Point(16, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Check the appropriate box if this is a repeated transaction:";
            // 
            // cbWeekly
            // 
            this.cbWeekly.AutoSize = true;
            this.cbWeekly.BackColor = System.Drawing.Color.Transparent;
            this.cbWeekly.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.cbWeekly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbWeekly.Location = new System.Drawing.Point(27, 296);
            this.cbWeekly.Margin = new System.Windows.Forms.Padding(2);
            this.cbWeekly.Name = "cbWeekly";
            this.cbWeekly.Size = new System.Drawing.Size(64, 19);
            this.cbWeekly.TabIndex = 6;
            this.cbWeekly.Text = "Weekly";
            this.cbWeekly.UseVisualStyleBackColor = false;
            // 
            // cbMonthly
            // 
            this.cbMonthly.AutoSize = true;
            this.cbMonthly.BackColor = System.Drawing.Color.Transparent;
            this.cbMonthly.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.cbMonthly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbMonthly.Location = new System.Drawing.Point(27, 321);
            this.cbMonthly.Margin = new System.Windows.Forms.Padding(2);
            this.cbMonthly.Name = "cbMonthly";
            this.cbMonthly.Size = new System.Drawing.Size(71, 19);
            this.cbMonthly.TabIndex = 7;
            this.cbMonthly.Text = "Monthly";
            this.cbMonthly.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(153)))), ((int)(((byte)(126)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.Location = new System.Drawing.Point(219, 345);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.Location = new System.Drawing.Point(297, 345);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpNewTransactionDate
            // 
            this.dtpNewTransactionDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNewTransactionDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.dtpNewTransactionDate.CustomFormat = "";
            this.dtpNewTransactionDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNewTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNewTransactionDate.Location = new System.Drawing.Point(93, 46);
            this.dtpNewTransactionDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNewTransactionDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpNewTransactionDate.Name = "dtpNewTransactionDate";
            this.dtpNewTransactionDate.Size = new System.Drawing.Size(146, 23);
            this.dtpNewTransactionDate.TabIndex = 10;
            this.dtpNewTransactionDate.Value = new System.DateTime(2024, 4, 20, 0, 0, 0, 0);
            // 
            // cbNewTransactionCategory
            // 
            this.cbNewTransactionCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.cbNewTransactionCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbNewTransactionCategory.FormattingEnabled = true;
            this.cbNewTransactionCategory.Location = new System.Drawing.Point(93, 90);
            this.cbNewTransactionCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbNewTransactionCategory.Name = "cbNewTransactionCategory";
            this.cbNewTransactionCategory.Size = new System.Drawing.Size(146, 23);
            this.cbNewTransactionCategory.TabIndex = 11;
            // 
            // txtNewTransactionDescription
            // 
            this.txtNewTransactionDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.txtNewTransactionDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewTransactionDescription.Location = new System.Drawing.Point(93, 136);
            this.txtNewTransactionDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewTransactionDescription.MaxLength = 500;
            this.txtNewTransactionDescription.Multiline = true;
            this.txtNewTransactionDescription.Name = "txtNewTransactionDescription";
            this.txtNewTransactionDescription.Size = new System.Drawing.Size(195, 48);
            this.txtNewTransactionDescription.TabIndex = 12;
            // 
            // nudNewTransactionAmount
            // 
            this.nudNewTransactionAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.nudNewTransactionAmount.DecimalPlaces = 2;
            this.nudNewTransactionAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudNewTransactionAmount.Location = new System.Drawing.Point(93, 214);
            this.nudNewTransactionAmount.Margin = new System.Windows.Forms.Padding(2);
            this.nudNewTransactionAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudNewTransactionAmount.Name = "nudNewTransactionAmount";
            this.nudNewTransactionAmount.Size = new System.Drawing.Size(125, 23);
            this.nudNewTransactionAmount.TabIndex = 13;
            // 
            // cbIncome
            // 
            this.cbIncome.AutoSize = true;
            this.cbIncome.Location = new System.Drawing.Point(227, 206);
            this.cbIncome.Name = "cbIncome";
            this.cbIncome.Size = new System.Drawing.Size(61, 17);
            this.cbIncome.TabIndex = 14;
            this.cbIncome.Text = "Income";
            this.cbIncome.UseVisualStyleBackColor = true;
            // 
            // cbExpense
            // 
            this.cbExpense.AutoSize = true;
            this.cbExpense.Location = new System.Drawing.Point(227, 229);
            this.cbExpense.Name = "cbExpense";
            this.cbExpense.Size = new System.Drawing.Size(67, 17);
            this.cbExpense.TabIndex = 15;
            this.cbExpense.Text = "Expense";
            this.cbExpense.UseVisualStyleBackColor = true;
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(381, 391);
            this.Controls.Add(this.cbExpense);
            this.Controls.Add(this.cbIncome);
            this.Controls.Add(this.nudNewTransactionAmount);
            this.Controls.Add(this.txtNewTransactionDescription);
            this.Controls.Add(this.cbNewTransactionCategory);
            this.Controls.Add(this.dtpNewTransactionDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbMonthly);
            this.Controls.Add(this.cbWeekly);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.nudNewTransactionAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbWeekly;
        private System.Windows.Forms.CheckBox cbMonthly;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpNewTransactionDate;
        private System.Windows.Forms.ComboBox cbNewTransactionCategory;
        private System.Windows.Forms.TextBox txtNewTransactionDescription;
        private System.Windows.Forms.NumericUpDown nudNewTransactionAmount;
        private System.Windows.Forms.CheckBox cbIncome;
        private System.Windows.Forms.CheckBox cbExpense;
    }
}