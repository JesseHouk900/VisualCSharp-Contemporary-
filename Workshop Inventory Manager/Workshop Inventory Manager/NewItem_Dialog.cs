/*      Jesse Houk - NewItem_Dialog.cs
 *      Purpose - form that will act as a dialog to allow the user to enter 
 *      information for a new item
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Inventory_Manager
{
    public partial class NewItem_Dialog : Form
    {
        // record that will hold the information that the user enters
        public Record record;
        // default constructor
        public NewItem_Dialog()
        {
            InitializeComponent();
            // initialize a new instance of a record
            record = new Record();
        }

        private void Insert_Button_Click(object sender, EventArgs e)
        {
            // prepare for errors
            try
            {
                // check that the fields have been enterd appropriately
                if (IsEmpty(Name_TextBox.Text) || IsEmpty(Price_TextBox.Text) ||
                    IsEmpty(Quantity_TextBox.Text))
                {
                    // if not, throw an error
                    throw new FormatException("Empty Field");
                }
                // set the fields of the record to the values given by the user
                record.Name = Name_TextBox.Text;
                record.Price = decimal.Parse(Price_TextBox.Text);
                record.Quantity = Int32.Parse(Quantity_TextBox.Text);
                // close the dialog
                this.Close();
            }
            catch (FormatException)
            {
                // give the user a message about not having the information entered correctly
                MessageBox.Show("Name needs to not be empty and not start with a" +
                    " number, Price needs to be in the form of 123.45 and " +
                    "Quantity needs to be a non negative number", "FormattingError",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // event handler for when the user clicks on the cancel button
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            // clear any information saved to the record
            record = null;
            // and close the dialog
            this.Close();
        }
        // support method to determine if a string is either empty or uninitialized
        private bool IsEmpty(string s)
        {
            return s == "" || s == null;
        }
    }
}
