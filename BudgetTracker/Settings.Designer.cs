namespace BudgetTracker
{
    partial class Settings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSaveAccountChanges = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRedZoneHelp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvCategoryBudgets = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDisplayTheme = new System.Windows.Forms.ComboBox();
            this.btnSaveBudgetChanges = new System.Windows.Forms.Button();
            this.btnSaveCategoryBudgetChanges = new System.Windows.Forms.Button();
            this.lblRedZone = new System.Windows.Forms.Label();
            this.nudCurrentMonthBudget = new System.Windows.Forms.NumericUpDown();
            this.nudRedZone = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryBudgets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentMonthBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRedZone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.Location = new System.Drawing.Point(133, 53);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(129, 23);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(133, 81);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(129, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSaveAccountChanges
            // 
            this.btnSaveAccountChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.btnSaveAccountChanges.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveAccountChanges.Location = new System.Drawing.Point(169, 115);
            this.btnSaveAccountChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveAccountChanges.Name = "btnSaveAccountChanges";
            this.btnSaveAccountChanges.Size = new System.Drawing.Size(93, 27);
            this.btnSaveAccountChanges.TabIndex = 5;
            this.btnSaveAccountChanges.Text = "Save changes";
            this.btnSaveAccountChanges.UseVisualStyleBackColor = false;
            this.btnSaveAccountChanges.Click += new System.EventHandler(this.btnSaveAccountChanges_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteAccount.Location = new System.Drawing.Point(147, 146);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(115, 27);
            this.btnDeleteAccount.TabIndex = 6;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Budget settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label5.Location = new System.Drawing.Point(22, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current month budget:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label6.Location = new System.Drawing.Point(22, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Red zone:";
            // 
            // lblRedZoneHelp
            // 
            this.lblRedZoneHelp.AutoSize = true;
            this.lblRedZoneHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblRedZoneHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRedZoneHelp.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRedZoneHelp.Location = new System.Drawing.Point(84, 230);
            this.lblRedZoneHelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRedZoneHelp.Name = "lblRedZoneHelp";
            this.lblRedZoneHelp.Size = new System.Drawing.Size(12, 13);
            this.lblRedZoneHelp.TabIndex = 10;
            this.lblRedZoneHelp.Text = "?";
            this.lblRedZoneHelp.MouseLeave += new System.EventHandler(this.lblRedZoneHelp_MouseLeave);
            this.lblRedZoneHelp.MouseHover += new System.EventHandler(this.lblRedZoneHelp_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label8.Location = new System.Drawing.Point(22, 297);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Budget of categories:";
            // 
            // dgvCategoryBudgets
            // 
            this.dgvCategoryBudgets.AllowUserToAddRows = false;
            this.dgvCategoryBudgets.AllowUserToDeleteRows = false;
            this.dgvCategoryBudgets.AllowUserToResizeColumns = false;
            this.dgvCategoryBudgets.AllowUserToResizeRows = false;
            this.dgvCategoryBudgets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoryBudgets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCategoryBudgets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategoryBudgets.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCategoryBudgets.EnableHeadersVisualStyles = false;
            this.dgvCategoryBudgets.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.dgvCategoryBudgets.Location = new System.Drawing.Point(17, 325);
            this.dgvCategoryBudgets.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategoryBudgets.MultiSelect = false;
            this.dgvCategoryBudgets.Name = "dgvCategoryBudgets";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoryBudgets.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCategoryBudgets.RowHeadersVisible = false;
            this.dgvCategoryBudgets.RowHeadersWidth = 51;
            this.dgvCategoryBudgets.RowTemplate.Height = 24;
            this.dgvCategoryBudgets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoryBudgets.Size = new System.Drawing.Size(244, 215);
            this.dgvCategoryBudgets.TabIndex = 14;
            this.dgvCategoryBudgets.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvCategoryBudgets_CellValidating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(16, 591);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Display settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label10.Location = new System.Drawing.Point(24, 616);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Theme:";
            // 
            // cbDisplayTheme
            // 
            this.cbDisplayTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.cbDisplayTheme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbDisplayTheme.FormattingEnabled = true;
            this.cbDisplayTheme.Location = new System.Drawing.Point(128, 613);
            this.cbDisplayTheme.Margin = new System.Windows.Forms.Padding(2);
            this.cbDisplayTheme.Name = "cbDisplayTheme";
            this.cbDisplayTheme.Size = new System.Drawing.Size(129, 23);
            this.cbDisplayTheme.TabIndex = 17;
            this.cbDisplayTheme.SelectedIndexChanged += new System.EventHandler(this.cbDisplayTheme_SelectedIndexChanged);
            // 
            // btnSaveBudgetChanges
            // 
            this.btnSaveBudgetChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.btnSaveBudgetChanges.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveBudgetChanges.Location = new System.Drawing.Point(169, 261);
            this.btnSaveBudgetChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveBudgetChanges.Name = "btnSaveBudgetChanges";
            this.btnSaveBudgetChanges.Size = new System.Drawing.Size(93, 27);
            this.btnSaveBudgetChanges.TabIndex = 18;
            this.btnSaveBudgetChanges.Text = "Save changes";
            this.btnSaveBudgetChanges.UseVisualStyleBackColor = false;
            this.btnSaveBudgetChanges.Click += new System.EventHandler(this.btnSaveBudgetChanges_Click);
            // 
            // btnSaveCategoryBudgetChanges
            // 
            this.btnSaveCategoryBudgetChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.btnSaveCategoryBudgetChanges.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveCategoryBudgetChanges.Location = new System.Drawing.Point(169, 551);
            this.btnSaveCategoryBudgetChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveCategoryBudgetChanges.Name = "btnSaveCategoryBudgetChanges";
            this.btnSaveCategoryBudgetChanges.Size = new System.Drawing.Size(93, 27);
            this.btnSaveCategoryBudgetChanges.TabIndex = 19;
            this.btnSaveCategoryBudgetChanges.Text = "Save changes";
            this.btnSaveCategoryBudgetChanges.UseVisualStyleBackColor = false;
            this.btnSaveCategoryBudgetChanges.Click += new System.EventHandler(this.btnSaveCategoryBudgetChanges_Click);
            // 
            // lblRedZone
            // 
            this.lblRedZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            this.lblRedZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedZone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRedZone.Location = new System.Drawing.Point(41, 253);
            this.lblRedZone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRedZone.Name = "lblRedZone";
            this.lblRedZone.Size = new System.Drawing.Size(226, 70);
            this.lblRedZone.TabIndex = 20;
            this.lblRedZone.Text = "Red Zone is the amount of money before you reach your monthly budget. When the re" +
    "d zone is reached after a transaction, you will be alerted.";
            this.lblRedZone.Visible = false;
            // 
            // nudCurrentMonthBudget
            // 
            this.nudCurrentMonthBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.nudCurrentMonthBudget.DecimalPlaces = 2;
            this.nudCurrentMonthBudget.Location = new System.Drawing.Point(165, 206);
            this.nudCurrentMonthBudget.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudCurrentMonthBudget.Name = "nudCurrentMonthBudget";
            this.nudCurrentMonthBudget.Size = new System.Drawing.Size(102, 20);
            this.nudCurrentMonthBudget.TabIndex = 21;
            // 
            // nudRedZone
            // 
            this.nudRedZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.nudRedZone.DecimalPlaces = 2;
            this.nudRedZone.Location = new System.Drawing.Point(165, 234);
            this.nudRedZone.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudRedZone.Name = "nudRedZone";
            this.nudRedZone.Size = new System.Drawing.Size(102, 20);
            this.nudRedZone.TabIndex = 22;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(290, 656);
            this.Controls.Add(this.nudRedZone);
            this.Controls.Add(this.nudCurrentMonthBudget);
            this.Controls.Add(this.lblRedZone);
            this.Controls.Add(this.btnSaveCategoryBudgetChanges);
            this.Controls.Add(this.btnSaveBudgetChanges);
            this.Controls.Add(this.cbDisplayTheme);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvCategoryBudgets);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRedZoneHelp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnSaveAccountChanges);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryBudgets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentMonthBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRedZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSaveAccountChanges;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRedZoneHelp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCategoryBudgets;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDisplayTheme;
        private System.Windows.Forms.Button btnSaveBudgetChanges;
        private System.Windows.Forms.Button btnSaveCategoryBudgetChanges;
        private System.Windows.Forms.Label lblRedZone;
        private System.Windows.Forms.NumericUpDown nudCurrentMonthBudget;
        private System.Windows.Forms.NumericUpDown nudRedZone;
    }
}