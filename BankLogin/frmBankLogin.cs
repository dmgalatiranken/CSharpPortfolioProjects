using System;
using System.Windows.Forms;

namespace BankLogin
{
    public partial class frmBankLogin : Form
    {
        // Declare class variables
        List<Account> accounts = new List<Account>();
        string currentAccountNumber = "";
        string currentPinNumber = "";
        int accountNumberLocation = 0;
        int pinNumberLocation = 0;
        bool youAreLoggedIn = false;

        public frmBankLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AttemptToLogIn();
        }

        private void AttemptToLogIn()
        {
            bool keepGoing = ValidateAccountNumber();

            if (keepGoing)
            {
                keepGoing = ValidatePinNumber();
            }
            else
            {
                return;
            }

            if ((accountNumberLocation == -1) ||
                (pinNumberLocation == -1) ||
                (accountNumberLocation != pinNumberLocation))
            {
                youAreLoggedIn = false;
                ShowErrorMessage("Account # or PIN # Error",
                                 "LOGIN ERROR");
                txtAccountNumber.Text = "";
                txtPinNumber.Text = "";
                txtCustomerInformation.Text = "";
                txtAccountNumber.Focus();
                return;
            }

            // We inputted a valid account AND pin #
            // Now show customer welcome information
            DisplayCustomerInformation();
        }

        private bool ValidateAccountNumber()
        {
            string acctNum = txtAccountNumber.Text.Trim();

            if (string.IsNullOrEmpty(acctNum))
            {
                ShowErrorMessage("You must enter in an account number",
                                 "NO ACCOUNT NUMBER ENTERED");
                txtAccountNumber.Focus();
                return false;
            }

            // Look through all existing account #'s
            for (int lcv = 0; lcv < accounts.Count; lcv++)
            {
                if (acctNum == accounts[lcv].GetAccountNumber())
                {
                    currentAccountNumber = acctNum;
                    accountNumberLocation = lcv;
                    return true;
                }
            }

            ShowErrorMessage("That account does not exist.",
                             "INVALID ACCOUNT #");
            txtAccountNumber.Text = "";
            txtPinNumber.Text = "";
            txtAccountNumber.Focus();
            accountNumberLocation = -1;
            return false;
        }

        private bool ValidatePinNumber()
        {
            string pinNum = txtPinNumber.Text.Trim();

            if (string.IsNullOrEmpty(pinNum))
            {
                ShowErrorMessage("You must enter in a pin number",
                                 "NO PIN NUMBER ENTERED");
                txtPinNumber.Focus();
                return false;
            }

            // Look through all existing pin #'s
            for (int lcv = 0; lcv < accounts.Count; lcv++)
            {
                if (pinNum == accounts[lcv].GetPinNumber())
                {
                    currentPinNumber = pinNum;
                    pinNumberLocation = lcv;
                    return true;
                }
            }

            ShowErrorMessage("That pin does not exist.",
                             "INVALID PIN #");
            txtPinNumber.Text = "";
            txtPinNumber.Focus();
            pinNumberLocation = -1;
            return false;
        }

        private void DisplayCustomerInformation()
        {
            int local = accountNumberLocation;
            string outputStr = "";

            outputStr += "\r\n\r\nWelcome " + " " +
                         accounts[local].GetTitle() + " " +
                         accounts[local].GetFirstName() + " " +
                         accounts[local].GetLastName() + "\r\n\r\n" +
                         "Your current balance is " +
                         accounts[local].GetBalance().ToString("c");

            txtCustomerInformation.Text = outputStr;
            SetPostLoginControls();
        }

        private void SetPreLoginControls()
        {
            youAreLoggedIn = false;
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
            btnDeposit.Enabled = false;
            btnWithdrawal.Enabled = false;
            currentAccountNumber = "";
            currentPinNumber = "";
            accountNumberLocation = -1;
            pinNumberLocation = -1;
        }

        private void SetPostLoginControls()
        {
            youAreLoggedIn = true;
            btnLogin.Enabled = false;
            btnLogout.Enabled = true;
            btnDeposit.Enabled = true;
            btnWithdrawal.Enabled = true;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            TryToDeposit();
        }

        private void TryToDeposit()
        {
            bool result;
            decimal deposit = 0.00m;
            string depositStr = txtDeposit.Text.Trim();
            int location = accountNumberLocation;

            // Check for no input
            if (string.IsNullOrEmpty(depositStr))
            {
                ShowErrorMessage("You must enter a number > 0.",
                                 "NO DEPOSIT AMOUNT ENTERED");
                return;
            }

            try
            {
                result = decimal.TryParse(depositStr, out deposit);

                // There was non-numeric input
                if (!result)
                {
                    throw new FormatException();
                }

                accounts[location].MakeDeposit(deposit);
                DisplayCustomerInformation();
                txtDeposit.Text = "";
                txtDeposit.Focus();
            }
            catch (FormatException fe)
            {
                ShowErrorMessage("System Message: " + fe.Message +
                                 "\n\nDeveloper Message: Non-Numeric Deposit Entered",
                                 "ILLEGAL DEPOSIT VALUE");
                txtDeposit.Text = "";
                txtDeposit.Focus();

            }
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            TryToWithdrawal();
        }

        private void TryToWithdrawal()
        {
            bool result;
            decimal withdraw = 0.00m;
            string withdrawStr = txtWithdrawal.Text.Trim();
            int location = accountNumberLocation;

            // Check for no input
            if (string.IsNullOrEmpty(withdrawStr))
            {
                ShowErrorMessage("You must enter a number > 0.",
                                 "NO WITHDRAW AMOUNT ENTERED");
                return;
            }

            try
            {
                result = decimal.TryParse(withdrawStr, out withdraw);

                // There was non-numeric input
                if (!result)
                {
                    throw new FormatException();
                }

                accounts[location].MakeWithdrawal(withdraw);
                DisplayCustomerInformation();
                txtWithdrawal.Text = "";
                txtWithdrawal.Focus();
            }
            catch (FormatException fe)
            {
                ShowErrorMessage("System Message: " + fe.Message +
                                 "\n\nDeveloper Message: Non-Numeric Withdrawal Entered",
                                 "ILLEGAL WITHDRAWAL VALUE");
                txtWithdrawal.Text = "";
                txtWithdrawal.Focus();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SetPreLoginControls();
            txtCustomerInformation.Text = "";
            txtAccountNumber.Text = "";
            txtPinNumber.Text = "";
            txtDeposit.Text = "";
            txtWithdrawal.Text = "";
            txtAccountNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void ExitProgram()
        {
            DialogResult dialog = MessageBox.Show(
        "Do You Really Want To Exit The Program?",
        "EXIT NOW?",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void frmBankLogin_Load(object sender, EventArgs e)
        {
            /*  Karter Hill
                Kennedy Walker
                Jeff Bezos
                Rylee Nelson
                Anna Garcia
             */
            accounts.Add(new Account("Mr.", "Karter", "Hill", "123-45-6789", "1234", 5000.00m));
            accounts.Add(new Account("Mr.", "Kennedy", "Walker", "121-23-3434", "4321", 6500.00m));
            accounts.Add(new Account("Mr.", "Jeff", "Bezos", "098-76-5432", "0987", 25.00m));
            accounts.Add(new Account("Mrs.", "Rylee", "Nelson", "135-79-1234", "1357", 4500.00m));
            accounts.Add(new Account("Mrs.", "Anna", "Garcia", "086-42-0987", "0864", 7000.00m));
            SetPreLoginControls();
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
