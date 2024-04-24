namespace BankLogin
{
    partial class frmBankLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAccountNumber = new Label();
            lblPinNumber = new Label();
            lblDeposit = new Label();
            lblWithdrawal = new Label();
            txtAccountNumber = new TextBox();
            txtPinNumber = new TextBox();
            txtDeposit = new TextBox();
            txtWithdrawal = new TextBox();
            btnLogin = new Button();
            btnDeposit = new Button();
            btnWithdrawal = new Button();
            btnLogout = new Button();
            btnExit = new Button();
            txtCustomerInformation = new TextBox();
            SuspendLayout();
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.BackColor = Color.FromArgb(128, 255, 128);
            lblAccountNumber.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountNumber.Location = new Point(153, 48);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(149, 41);
            lblAccountNumber.TabIndex = 10;
            lblAccountNumber.Text = "Account #";
            lblAccountNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPinNumber
            // 
            lblPinNumber.BackColor = Color.FromArgb(128, 255, 128);
            lblPinNumber.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPinNumber.Location = new Point(203, 128);
            lblPinNumber.Name = "lblPinNumber";
            lblPinNumber.Size = new Size(99, 41);
            lblPinNumber.TabIndex = 11;
            lblPinNumber.Text = "Pin #";
            lblPinNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDeposit
            // 
            lblDeposit.BackColor = Color.FromArgb(128, 255, 128);
            lblDeposit.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeposit.Location = new Point(60, 442);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(367, 41);
            lblDeposit.TabIndex = 12;
            lblDeposit.Text = "Would you like to make a deposit?";
            lblDeposit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWithdrawal
            // 
            lblWithdrawal.BackColor = Color.FromArgb(128, 255, 128);
            lblWithdrawal.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWithdrawal.Location = new Point(45, 589);
            lblWithdrawal.Name = "lblWithdrawal";
            lblWithdrawal.Size = new Size(403, 41);
            lblWithdrawal.TabIndex = 13;
            lblWithdrawal.Text = "Would you like to make a withdrawal?";
            lblWithdrawal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAccountNumber.Location = new Point(323, 52);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(269, 30);
            txtAccountNumber.TabIndex = 0;
            txtAccountNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPinNumber
            // 
            txtPinNumber.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPinNumber.Location = new Point(323, 133);
            txtPinNumber.Name = "txtPinNumber";
            txtPinNumber.Size = new Size(269, 30);
            txtPinNumber.TabIndex = 1;
            txtPinNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDeposit
            // 
            txtDeposit.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDeposit.Location = new Point(116, 502);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(269, 30);
            txtDeposit.TabIndex = 3;
            txtDeposit.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWithdrawal
            // 
            txtWithdrawal.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWithdrawal.Location = new Point(116, 649);
            txtWithdrawal.Name = "txtWithdrawal";
            txtWithdrawal.Size = new Size(269, 30);
            txtWithdrawal.TabIndex = 5;
            txtWithdrawal.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(631, 81);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(181, 65);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeposit.Location = new Point(484, 485);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(181, 65);
            btnDeposit.TabIndex = 4;
            btnDeposit.Text = "&Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdrawal
            // 
            btnWithdrawal.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdrawal.Location = new Point(484, 632);
            btnWithdrawal.Name = "btnWithdrawal";
            btnWithdrawal.Size = new Size(181, 65);
            btnWithdrawal.TabIndex = 6;
            btnWithdrawal.Text = "&Withdrawal";
            btnWithdrawal.UseVisualStyleBackColor = true;
            btnWithdrawal.Click += btnWithdrawal_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(352, 790);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(181, 65);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "L&ogout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(714, 790);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(181, 65);
            btnExit.TabIndex = 8;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtCustomerInformation
            // 
            txtCustomerInformation.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCustomerInformation.Location = new Point(215, 196);
            txtCustomerInformation.Multiline = true;
            txtCustomerInformation.Name = "txtCustomerInformation";
            txtCustomerInformation.ReadOnly = true;
            txtCustomerInformation.Size = new Size(443, 203);
            txtCustomerInformation.TabIndex = 9;
            txtCustomerInformation.TextAlign = HorizontalAlignment.Center;
            // 
            // frmBankLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            CancelButton = btnExit;
            ClientSize = new Size(923, 877);
            Controls.Add(txtCustomerInformation);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(btnWithdrawal);
            Controls.Add(btnDeposit);
            Controls.Add(btnLogin);
            Controls.Add(txtWithdrawal);
            Controls.Add(txtDeposit);
            Controls.Add(txtPinNumber);
            Controls.Add(txtAccountNumber);
            Controls.Add(lblWithdrawal);
            Controls.Add(lblDeposit);
            Controls.Add(lblPinNumber);
            Controls.Add(lblAccountNumber);
            Name = "frmBankLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bank Login";
            Load += frmBankLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccountNumber;
        private Label lblPinNumber;
        private Label lblDeposit;
        private Label lblWithdrawal;
        private TextBox txtAccountNumber;
        private TextBox txtPinNumber;
        private TextBox txtDeposit;
        private TextBox txtWithdrawal;
        private Button btnLogin;
        private Button btnDeposit;
        private Button btnWithdrawal;
        private Button btnLogout;
        private Button btnExit;
        private TextBox txtCustomerInformation;
    }
}
