using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCardHelper
{
    public partial class frmParkingHelper : Form
    {
        public frmParkingHelper()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool creditValid = Double.TryParse(txtCreditAdded.Text, out double creditAdded);
            /* I made the cost and savings static amounts because it seems silly to
             * ask for user input when this is specifically designed for MCTC parking*/
            const double ParkCost = 2.50;
            const double ParkSavings = 2.50;

            // Because of above, there's only need for one boolean (as opposed to three)
            if (creditValid)
            {
                int daysParking = (int)(creditAdded / ParkCost);
                double creditRemaining = creditAdded % ParkCost;
                double totalSavings = daysParking * ParkSavings;

                txtNumOfDays.Text = daysParking.ToString();
                txtRemainingCredit.Text = creditRemaining.ToString("c");
                txtSavings.Text = totalSavings.ToString("c");
            }
            else
            {
                // If a dollar sign is added, it causes an exception
                MessageBox.Show("Please enter a number without a dollar sign", "Error");
            }
        }

        // Basic "Exit button"
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
