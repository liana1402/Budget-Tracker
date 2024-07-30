namespace BudgetTracker
{
    partial class Register
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
            this.txtUsernameInput = new System.Windows.Forms.TextBox();
            this.txtPasswordInput = new System.Windows.Forms.TextBox();
            this.txtConfirmPasswordInput = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(149, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(85, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please create a username and password.";
            // 
            // txtUsernameInput
            // 
            this.txtUsernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.txtUsernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsernameInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsernameInput.Location = new System.Drawing.Point(111, 181);
            this.txtUsernameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsernameInput.MaxLength = 50;
            this.txtUsernameInput.Name = "txtUsernameInput";
            this.txtUsernameInput.Size = new System.Drawing.Size(227, 26);
            this.txtUsernameInput.TabIndex = 3;
            this.txtUsernameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsernameInput_KeyDown);
            // 
            // txtPasswordInput
            // 
            this.txtPasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.txtPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPasswordInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPasswordInput.Location = new System.Drawing.Point(111, 238);
            this.txtPasswordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordInput.MaxLength = 50;
            this.txtPasswordInput.Name = "txtPasswordInput";
            this.txtPasswordInput.Size = new System.Drawing.Size(227, 26);
            this.txtPasswordInput.TabIndex = 4;
            this.txtPasswordInput.UseSystemPasswordChar = true;
            this.txtPasswordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswordInput_KeyDown);
            // 
            // txtConfirmPasswordInput
            // 
            this.txtConfirmPasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.txtConfirmPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtConfirmPasswordInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConfirmPasswordInput.Location = new System.Drawing.Point(111, 295);
            this.txtConfirmPasswordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPasswordInput.MaxLength = 50;
            this.txtConfirmPasswordInput.Name = "txtConfirmPasswordInput";
            this.txtConfirmPasswordInput.Size = new System.Drawing.Size(227, 26);
            this.txtConfirmPasswordInput.TabIndex = 5;
            this.txtConfirmPasswordInput.UseSystemPasswordChar = true;
            this.txtConfirmPasswordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPasswordInput_KeyDown);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(153)))), ((int)(((byte)(126)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegister.Location = new System.Drawing.Point(176, 350);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(93, 30);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(107, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(107, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(107, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirm password:";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(39, 43);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 58);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "⬅";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(448, 415);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmPasswordInput);
            this.Controls.Add(this.txtPasswordInput);
            this.Controls.Add(this.txtUsernameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsernameInput;
        private System.Windows.Forms.TextBox txtPasswordInput;
        private System.Windows.Forms.TextBox txtConfirmPasswordInput;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label btnCancel;
    }
}