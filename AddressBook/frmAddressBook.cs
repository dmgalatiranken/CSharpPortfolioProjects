using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class frmAddressBook : Form
    {
        // Declare and initialize program constants
        const string FN = "First Name:";
        const string LN = "Last Name:";
        const string PN = "Phone Number:";
        const string UNF = "User Not Found";
        const string E = "Error";

        // Declare and initialize program arrays
        string[] firstNames = { "Markel", "Luiza", "Bryony", "Giraldo", "Lowri" };
        string[] lastNames = { "Diggory", "Gunnar", "Hester", "Addy", "Hari" };
        string[] phoneNumbers = { "555-8390", "555-4618", "555-4440", "555-1687", "555-7763" };

        public frmAddressBook()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = CheckForNoInput();

            if (keepGoing)
            {
                PerformSearch();
            }
        }

        private bool CheckForNoInput()
        {
            bool retVal = true;
            string term = txtFirstOrLastName.Text.Trim();

            if (term == "")
            {
                ShowErrorMessage("You must enter a search term",
                                 "Search Term Left Empty");
                ClearForm();
                retVal = false;
            }

            return retVal;
        }

        private void PerformSearch()
        {
            string term = txtFirstOrLastName.Text.Trim();
            bool isFound = false;
            int ind = -1;
            string outputStr = "";

            for (int lcv = 0; lcv < firstNames.Length; lcv++)
            {
                // Search either firstNames or lastNames array looking for a match
                if (firstNames[lcv].ToLower().Contains(term.ToLower()) ||
                    lastNames[lcv].ToLower().Contains(term.ToLower()) ||
                    phoneNumbers[lcv].ToLower().Contains(term.ToLower()))
                {
                    isFound = true;
                    ind = lcv;
                    break;

                }
            }

            // We found a match
            if (isFound)
            {
                outputStr += $"{FN}\t {firstNames[ind]}\r\n";
                outputStr += $"{LN}\t {lastNames[ind]}\r\n";
                outputStr += $"{PN}\t {phoneNumbers[ind]}\r\n";
                lblUserFoundOrNot.Text = "User Found";
            }
            else
            {
                outputStr += $"{FN}\t {E}\r\n";
                outputStr += $"{LN}\t {E}\r\n";
                outputStr += $"{PN}\t {E}\r\n";
                lblUserFoundOrNot.Text = "User Not Found";
            }

            txtResult.Text = outputStr;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFirstOrLastName.Text = "";
            txtResult.Text = "";
            lblUserFoundOrNot.Text = "";
            txtFirstOrLastName.Focus();
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

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
