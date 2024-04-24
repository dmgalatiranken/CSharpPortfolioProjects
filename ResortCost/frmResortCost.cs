using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortCost
{
    public partial class frmResortCost : Form
    {
        // Declare and initialize program constants
        decimal[] nightCost = { 200.00m, 180.00m, 160.00m, 145.00m };
        string[] numNights = { "One to Two", "Three To Four", "Five to Seven", "Eight or More" };
        public frmResortCost()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DetermineNightsStayed();
        }

        private void DetermineNightsStayed()
        {
            int nights = 0;

            try
            {
                nights = Convert.ToInt32(txtNightsStayed.Text.Trim());

                if (nights <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                DetermineBill(nights);
            }

            catch (FormatException fe)
            {
                ShowErrorMessage("System Message: " + fe.Message +
                                 "\n\nNights must be an integer.",
                                 "FORMATEXCEPTION");
                ClearForm();
                return;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                ShowErrorMessage("System Message: " + aoore.Message +
                                 "\n\nNights must be greater than 0.",
                                 "ARGUMENTOUTOFRANGEEXCEPTION");
                ClearForm();
                return;
            }
        }

        private void DetermineBill(int nights)
        {
            decimal nightlyCost = 0.00m;
            decimal totalCost = 0.00m;
            string numNightsStr = "";

            switch (nights)
            {
                case 1:
                case 2:
                    nightlyCost = nightCost[0];
                    numNightsStr = numNights[0];
                    break;

                case 3:
                case 4:
                    nightlyCost = nightCost[1];
                    numNightsStr = numNights[1];
                    break;

                case 5:
                case 6:
                case 7:
                    nightlyCost = nightCost[2];
                    numNightsStr = numNights[2];
                    break;

                default:
                    nightlyCost = nightCost[3];
                    numNightsStr = numNights[3];
                    break;
            }

            totalCost = nightlyCost * nights;
            txtNightlyRate.Text = $"{numNightsStr}";
            txtNightlyCost.Text = $"{nightlyCost:c}";
            txtTotalCost.Text = $"{totalCost:c}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtNightsStayed.Text = "";
            txtNightlyRate.Text = "";
            txtNightlyCost.Text = "";
            txtTotalCost.Text = "";
            txtNightsStayed.Focus();
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
