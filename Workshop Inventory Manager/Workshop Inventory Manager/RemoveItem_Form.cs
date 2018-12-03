/*      Jesse Houk - removeItem_Form.cs
 *      Purpose - form that will be called like a dialog to get which item the
 *      user wants to delete from the form
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
    public partial class RemoveItem_Form : Form
    {
        // a reference that will be the current active child
        public Workshop_Form Workshop;
        // parameterized constructor that takes in the a form the user wants 
        // to delete an item from
        public RemoveItem_Form(Workshop_Form f)
        {
            // set the workshop to the form that was passed in
            Workshop = f;
            InitializeComponent();
        }
        // event handler for when the user clicks remove or presses enter
        private void Remove_Button_Click(object sender, EventArgs e)
        {
            // loop through the list of records from the end to the front so as 
            // to not have indexing issues
            for (int i = Workshop.WorkshopItems.Count - 1; i >= 0; i--)
            {
                // if the ith item has the same name as the name entered...
                if (Workshop.WorkshopItems[i].Name == Name_TextBox.Text)
                {
                    // remove the item at position i
                        Workshop.WorkshopItems.RemoveAt(i);
                }
            }
            // then close the form
            Close();
        }
        // event handler for when the user clicks on the cancel button
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            // close the form
            Close();
        }
    }

}
