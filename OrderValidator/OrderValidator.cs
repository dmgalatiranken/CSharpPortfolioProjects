using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderValidator
{
    public partial class OrderValidator : Form
    {
        // Declare and initialize program constants
        const int MIN_ITEM_NUMBER = 100;
        const int MAX_ITEM_NUMBER = 999;
        const int MIN_QUANTITY = 1;
        const int MAX_QUANTITY = 12;
        const int MIN_ESTIMATED_DELIVERY = 1;
        const int MAX_ESTIMATED_DELIVERY = 30;

        public OrderValidator()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            ValidateDataAndDetermineOrderStatus();
        }

        private bool ValidateDataAndDetermineOrderStatus()
        {
            string errorMessage = "";
            bool keepGoing = true;

            // Validate item number text boxes
            errorMessage += IsPresent(txtItemNumber.Text, "Item Number");
            errorMessage += IsInt32(txtItemNumber.Text, "Item Number");
            errorMessage += IsWithinRange(txtItemNumber.Text, "Item Number",
                                                               MIN_ITEM_NUMBER,
                                                               MAX_ITEM_NUMBER);


            // Validate quantity text boxes
            errorMessage += IsPresent(txtQuantity.Text, "Quantity");
            errorMessage += IsInt32(txtQuantity.Text, "Quantity");
            errorMessage += IsWithinRange(txtQuantity.Text, "Quantity",
                                                             MIN_QUANTITY,
                                                             MAX_QUANTITY);


            // Validate delivery day text boxes
            errorMessage += IsPresent(txtEstimatedDelivery.Text, "Estimated Delivery");
            errorMessage += IsInt32(txtEstimatedDelivery.Text, "Estimated Delivery");
            errorMessage += IsWithinRange(txtEstimatedDelivery.Text, "Estimated Delivery",
                                                                      MIN_ESTIMATED_DELIVERY,
                                                                      MAX_ESTIMATED_DELIVERY);

            // Display error message if any and make the order invalid.
            // If there are no errors, make the order valid.
            if (errorMessage != "")
            {
                keepGoing = false;
                ShowErrorMessage(errorMessage, "Entry Error");
                lblOrderIs.Text = "Order is NOT valid.";
            }
            else
            {
                lblOrderIs.Text = "Order is valid.";
            }

            return keepGoing;

        }

        private string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = name + " is a required field.\n";
            }

            return msg;
        }


        private string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg = name + " must be a valid integer value.\n";
            }

            return msg;
        }


        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg = name + " must be between " + min + " and " + max + ".\n";
                }
            }

            return msg;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtItemNumber.Text = "";
            txtQuantity.Text = "";
            txtEstimatedDelivery.Text = "";
            lblOrderIs.Text = "Order is";
            txtItemNumber.Focus();
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
