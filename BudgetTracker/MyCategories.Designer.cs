namespace BudgetTracker
{
    partial class MyCategories
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
            this.lbCurrentCategories = new System.Windows.Forms.ListBox();
            this.btnRemoveSelectedCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddCategory = new System.Windows.Forms.TextBox();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current categories";
            // 
            // lbCurrentCategories
            // 
            this.lbCurrentCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            this.lbCurrentCategories.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbCurrentCategories.FormattingEnabled = true;
            this.lbCurrentCategories.ItemHeight = 15;
            this.lbCurrentCategories.Location = new System.Drawing.Point(12, 46);
            this.lbCurrentCategories.Margin = new System.Windows.Forms.Padding(2);
            this.lbCurrentCategories.Name = "lbCurrentCategories";
            this.lbCurrentCategories.Size = new System.Drawing.Size(257, 229);
            this.lbCurrentCategories.TabIndex = 2;
            this.lbCurrentCategories.DoubleClick += new System.EventHandler(this.lbCurrentCategories_DoubleClick);
            // 
            // btnRemoveSelectedCategory
            // 
            this.btnRemoveSelectedCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.btnRemoveSelectedCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveSelectedCategory.Location = new System.Drawing.Point(115, 282);
            this.btnRemoveSelectedCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveSelectedCategory.Name = "btnRemoveSelectedCategory";
            this.btnRemoveSelectedCategory.Size = new System.Drawing.Size(153, 27);
            this.btnRemoveSelectedCategory.TabIndex = 3;
            this.btnRemoveSelectedCategory.Text = "Remove selected category";
            this.btnRemoveSelectedCategory.UseVisualStyleBackColor = false;
            this.btnRemoveSelectedCategory.Click += new System.EventHandler(this.btnRemoveSelectedCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label2.Location = new System.Drawing.Point(12, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add category:";
            // 
            // txtAddCategory
            // 
            this.txtAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.txtAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddCategory.Location = new System.Drawing.Point(12, 344);
            this.txtAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddCategory.MaxLength = 50;
            this.txtAddCategory.Name = "txtAddCategory";
            this.txtAddCategory.Size = new System.Drawing.Size(180, 23);
            this.txtAddCategory.TabIndex = 5;
            this.txtAddCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddCategory_KeyDown);
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.btnAddNewCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewCategory.Location = new System.Drawing.Point(196, 341);
            this.btnAddNewCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(70, 27);
            this.btnAddNewCategory.TabIndex = 6;
            this.btnAddNewCategory.Text = "Add";
            this.btnAddNewCategory.UseVisualStyleBackColor = false;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // MyCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(284, 389);
            this.Controls.Add(this.btnAddNewCategory);
            this.Controls.Add(this.txtAddCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveSelectedCategory);
            this.Controls.Add(this.lbCurrentCategories);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MyCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCategories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCurrentCategories;
        private System.Windows.Forms.Button btnRemoveSelectedCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddCategory;
        private System.Windows.Forms.Button btnAddNewCategory;
    }
}