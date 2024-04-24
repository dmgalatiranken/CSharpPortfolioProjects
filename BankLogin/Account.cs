using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin
{
    public class Account
    {
        // Declare and initialize constant
        public const decimal MIN_BALANCE = 25.00m;

        // Instance variables
        private readonly string _title;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _accountNumber;
        private readonly string _pinNumber;
        private decimal _balance;

        // Full-Arg Constructor
        public Account(string title,
                       string firstName, string lastName,
                       string accountNumber, string pinNumber, decimal balance)
        {
            _title = title;
            _firstName = firstName;
            _lastName = lastName;
            _accountNumber = accountNumber;
            _pinNumber = pinNumber;
            _balance = balance;

        }

        // Getters
        public string GetTitle() => _title;
        public string GetFirstName() => _firstName;
        public string GetLastName() => _lastName;
        public string GetAccountNumber() => _accountNumber;
        public string GetPinNumber() => _pinNumber;
        public decimal GetBalance() => _balance;

        // Attempt to make a deposit method
        public void MakeDeposit(decimal deposit)
        {
            // Create a local variable to hold a copy of the attempted deposit
            decimal theDeposit = deposit;

            try
            {
                // Attempt to make a deposit, but first verify deposit amount is not <= 0
                if (theDeposit <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                // Deposit was >= 0
                _balance += theDeposit;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("System Message: " + aoore.Message +
                                "\n\nDeveloper Message: Illegal Deposit. Must be > 0.",
                                "ILLEGAL DEPOSIT ATTEMPTED");
                return;
            }
        }


        // Attempt to make a withdrawal method
        public void MakeWithdrawal(decimal withdrawal)
        {
            // Create a local variable to hold a copy of the attempted withdrawal
            decimal theWithdrawal = withdrawal;
            decimal newBalance = 0.00m;

            try
            {
                // Attempt to make a withdrawal, but first verify withdrawal amount is not <= 0
                if (theWithdrawal <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                // The withdrawal amount was positive, now verify that the withdrawal will
                // leave our account balanace >= $25 (MIN_BALANCE)
                newBalance = _balance - theWithdrawal;

                if (newBalance < MIN_BALANCE)
                {
                    throw new DataException();
                }


                // Withdrawal was >= 0
                // Balance after the withdrawal is >= $25 (MIN_BALANCE)
                _balance -= theWithdrawal;
            }
            catch (DataException de)
            {
                MessageBox.Show("System Message: " + de.Message +
                                "\n\nDeveloper Message: Insufficient Funds for this withdrawal",
                                "INSUFFICIENT FUNDS");
                return;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("System Message: " + aoore.Message +
                                "\n\nDeveloper Message: Illegal Withdrawal. Must be > 0.",
                                "ILLEGAL WITHDRAWAL ATTEMPTED");
                return;
            }
        }
    }
}
