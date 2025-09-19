using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005m; // const for monthly interest.
            decimal balance; //The account balnce.
            int months; //The number of months.
            int count = 1; // Loop counter, initialized with 1.

            //Get the starting balance.
            if (decimal.TryParse(txtstartingBal.Text, out balance))
            {
                //Get the number of months.
                if (int.TryParse(txtmonths.Text, out months))
                {
                    //The fooloowing loop calculates the edning balance.
                    while (count <= months)
                    {
                        //Add this months interest to the balnce.
                        balance = balance + (INTEREST_RATE * balance);

                        //Display this month's ending balance. (For enhancing our program.)
                        lstDetailList.Items.Add("The ending balance " + "for month " + count + " is " + balance.ToString("c"));

                        //Add one to the loop.
                        count += 1;
                    }

                    //Display ending balance. to that empty label.
                    lblendingBalance.Text = balance.ToString("c");

                }
                else
                {
                    //Invalid number of months was entered.
                    MessageBox.Show("Invalid value for months.");
                }
            }
            else
            {
                //Invalid starting balance was entered.
                MessageBox.Show("Invalid value for a starting balance.");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the textboxes and the endingBalance label control.
            // and the listbox.
            txtmonths.Text = "";
            txtstartingBal.Text = "";
            lblendingBalance.Text = "";
            lstDetailList.Items.Clear();

            //Reset the focus.
            txtstartingBal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the application.
            this.Close();
        }
    }
}
