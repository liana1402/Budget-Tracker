namespace BudgetTracker
{
    partial class Login
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
            this.txtUsernameInput = new System.Windows.Forms.TextBox();
            this.txtPasswordInput = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(169, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log in";
            // 
            // txtUsernameInput
            // 
            this.txtUsernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.txtUsernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsernameInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsernameInput.Location = new System.Drawing.Point(111, 143);
            this.txtUsernameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsernameInput.Name = "txtUsernameInput";
            this.txtUsernameInput.Size = new System.Drawing.Size(227, 26);
            this.txtUsernameInput.TabIndex = 1;
            this.txtUsernameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsernameInput_KeyDown);
            // 
            // txtPasswordInput
            // 
            this.txtPasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.txtPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPasswordInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPasswordInput.Location = new System.Drawing.Point(111, 198);
            this.txtPasswordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordInput.Name = "txtPasswordInput";
            this.txtPasswordInput.Size = new System.Drawing.Size(227, 26);
            this.txtPasswordInput.TabIndex = 2;
            this.txtPasswordInput.UseSystemPasswordChar = true;
            this.txtPasswordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswordInput_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.Location = new System.Drawing.Point(176, 246);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(211, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Or";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRegister.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRegister.Location = new System.Drawing.Point(149, 316);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(151, 20);
            this.lblRegister.TabIndex = 5;
            this.lblRegister.Text = "Create a new account";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(107, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(107, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(448, 368);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswordInput);
            this.Controls.Add(this.txtUsernameInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsernameInput;
        private System.Windows.Forms.TextBox txtPasswordInput;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

