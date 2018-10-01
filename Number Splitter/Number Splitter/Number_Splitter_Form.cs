/* Jesse Houk:    Number Splitter:    Assignment 3:    4143
 * 
 * Problem: Prompt the user for numerical input, break that number into five
 *      seperate digits, and show the user these seperated digits
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Splitter
{
    public partial class Number_Splitter_Form : Form
    {
        public Number_Splitter_Form()
        {
            InitializeComponent();
            SplitNumberLabel.Text = "0    0    0    0    0";
        }

        private void SplitButton_Click(object sender, EventArgs e)
        {
            string userText = UserNumberTextBox.Text;
            string splitNumberText = "";
            if (userText.Length > 0) {
                int splittingNumber = Int32.Parse(userText);
                for (int i = userText.Length - 1; i >= 0; i--)
                {
                    // Get the ith digit from the splitting number
                    splitNumberText += (int)(splittingNumber / Math.Pow(10, i));
                    if (i % 5 == 0)
                    {
                        splitNumberText += "\n";
                    }
                    else
                    {
                        splitNumberText += "    ";
                    }
                    // Remove the ith digit from the number
                    splittingNumber =  (int)(splittingNumber % Math.Pow(10, i));
                }
                SplitNumberLabel.Text = splitNumberText;

            }
        }
    }
}
