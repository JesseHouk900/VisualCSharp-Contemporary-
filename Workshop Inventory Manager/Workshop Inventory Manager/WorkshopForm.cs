/*      Jesse Houk - WorkshopForm.cs
 *      Purpose - form that will be the child form of the workshopManagerForm
 *      allowing the user to make a supply list. can be saved, opened, and modified.
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
    public partial class Workshop_Form : Form
    {
        // counter used for the tag of the form
        public static int Count = 1;
        // read-only form name, cannot be modified
        public readonly string WorkshopName;
        // list of records that the user will manipulate or observe
        public List<Record> WorkshopItems;
        // used to space elements of a record
        public const int SetWidth = 45;
        // default/parameterized constructor. if formname is passed in, the 
        // form's name and text will be set to this value
        public Workshop_Form(string formName = "")
        {
            InitializeComponent();
            // initialize a list of records
            WorkshopItems = new List<Record>();
            // a list of spaces for the header
            List<string> setWs = new List<string>();
            // make appropriate spacing for the header
            setWs.Add("                                    ");
            setWs.Add("                                   ");
            // add a header for the items in the listbox of records
            Items_ListBox.Items.Add("   Name" + setWs[0] + "Price" + setWs[1] + " Quantity");
            // make the anme of the workshop the name of the form
            WorkshopName = formName;
            // initialize the event handlers of the ciontrols on the form
            MouseEvents();
            // increment the number of WorkshopForms that exist
            Count++;
        }
        // method to add the ToolStripMenuItem_Click event to the event handlers
        // of all the controls in the form that are ToolStripMenuItems.
        private void MouseEvents()
        {
            // add the appropriate MouseEvent to the MouseEventHandler
            this.MouseDown += new MouseEventHandler(Workshop_Form_Click);
        }

        // event handler for when the user clicks on the form, used to make the
        // form the active Mid child form
        private void Workshop_Form_Click(object sender, MouseEventArgs e)
        {
            // loop through the children of the WorkshopManagerForm
            foreach (Form f in MdiParent.MdiChildren)
            {
                // if there is a form that has the same tag as this form...
                if (f.Tag == this.Tag)
                {
                    // make the current form the active child
                    ((Workshop_Form)MdiParent).ActivateMdiChild((Workshop_Form)this);
                }
            }
        }
        private void Items_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string test = ((ListBox.ObjectCollection)sender).
        }

        public void UpdateListBox()
        {
            this.Hide();
            this.Show();
        }
        // event handler for when the user enters the workshop, either by 
        // clicking on it or by opening it
        private void Workshop_Form_Enter(object sender, EventArgs e)
        {
            Items_ListBox.ResetText();
            // reset the list box
            for (int i = Items_ListBox.Items.Count - 1; i >= 1; i--)
            {
                Items_ListBox.Items.RemoveAt(i);
            }
            // loop through the items in the list of records
            for (int i = 0; i < WorkshopItems.Count; i++)
            {
                // and add them to the listbox
                Items_ListBox.Items.Add(WorkshopItems[i].ToString(SetWidth));
            }
        }
    }
}
