/*  Jesse Houk   Program 7   MDI Workshop Supply List Editor  Dr. Stringfellow
 * 
 * Purpose: Create an MDI that allows the user to select or add a workshop.         \,
 *      The data for a workshop should come from a file and be saved to one.        \,
 *      Once a workshop is selected, the user can add and delete items to the       \,
 *      supply list. 
 *      Each item should have a quantity and price.                                 \,
 *      
 *      ParentForm should have a File Menu that allows commands such as New, 
 *      Open, Save, Exit, ect.,                                                     \,
 *      and a Edit Menu that allows commands such as Insert and Delete.             \,
 *      
 *      A WorkshopForm should have the name of the workshop as the form text that   \,
 *      is saved as a public read-only property, Workshopname. This name should     \,
 *      be obtained by a dialog of WorkshopNameForm. Append to this name            \,
 *      the extension ".sup". A workshop form will display the supply list in a     \,
 *      ListBox.                                                                    \,
 *      
 *      The class about an order in a workshop should be implemented to be          \,
 *      Serializable and should be called a Record (Record.cs)                      \,
 *      
 *      When adding an item to a workshop, use a dialog (Form.ShowDialog())
 *      instance of your item information form.                                     \,
 *      
 *      EXTRA CREDIT: Disable items when appropriate                                \,
 *      Create an about form                                                        X
 *      Update an item (instead of having two entries of, say, water bottles
 *          have one entry that is the sum of the two entries)                      X
 *      Sort the ListBox                                                            X
 *      Create a User Control of some sort to get input data from the user          \,
 *          could derive from Dialog type
 *          could be for the store form or an item's value
 *      
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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Workshop_Inventory_Manager
{
    public partial class WorkshopManagerForm : Form
    {
        // binary formatter used to read and write to files, serializing data
        public BinaryFormatter formatter = new BinaryFormatter();
        // file stream for reading from a file
        public FileStream infile;
        // file stream used to write to a file
        public FileStream outfile;

        // default constructor that initializes mouse events
        public WorkshopManagerForm()
        {
            InitializeComponent();
            // make the event handlers be associated with the correct controls
            MouseEvents();
        }

        // method to add the ToolStripMenuItem_Click event handler to the event 
        // handlers of all the controls in the form that are ToolStripMenuItems.
        private void MouseEvents()
        {
            // observe each control in the form
            foreach (ToolStripMenuItem Container in Director_MenuStrip.Items)
            {
                // extract the control from the drop down list of the container
                foreach (ToolStripMenuItem Control in Container.DropDownItems)
                {
                    // if their name contains ToolStripMenuItem...
                    if (Control.Name.Contains("ToolStripMenuItem"))
                    {
                        // add the appropriate MouseEvent to the MouseEventHandler
                        Control.MouseDown += new MouseEventHandler
                            (ToolStripMenuItem_Click);
                    }
                }
            }
        }
        // event handler to handle all events associated with clicking on a drop
        // down item
        private void ToolStripMenuItem_Click(object sender, MouseEventArgs e)
        {
            // make a generic dialog object that will use polymorphism
            object dialog;
            // prepare for errors
            try
            {
                // make the drop down items of the file menu item invisible
                foreach (ToolStripItem toolStripItem in fileToolStripMenuItem.DropDownItems)
                {
                    toolStripItem.Visible = false;

                }
                // make the drop down items of the items menu item invisible
                foreach (ToolStripItem toolStripItem in itemsToolStripMenuItem.DropDownItems)
                {
                    toolStripItem.Visible = false;

                }
                // save the item the user selected as the text of the button
                // they clicked
                string item = ((ToolStripMenuItem)sender).Text;
                // used to hold the full path of a file
                string filePath;
                // declare a result item for when the dialog object is used
                DialogResult result;
                // make a reference to a child form
                Workshop_Form form;
                // switch on the value of item
                switch (item)
                {
                    // if item == "Exit"...
                    case "Exit":
                        // close the app
                        this.Close();
                        // and send an exit message to the system
                        System.Environment.Exit(1);
                        break;

                    // if item == "Insert"...
                    case "Insert":
                        // make form refer to the active child form
                        form = (Workshop_Form)ActiveMdiChild;
                        // make a new reference to a dialog that will allow the 
                        // user to enter information about an item
                        NewItem_Dialog itemForm = new NewItem_Dialog();
                        // show the dialog to the user
                        itemForm.ShowDialog();
                        // if they filled out info and clicked OK...
                        if (itemForm.record != null)
                        {
                            // add the record to the list of records in the active
                            // form
                            form.WorkshopItems.Add(new Record(itemForm.record));
                            // refresh the active form
                            form.UpdateListBox();
                        }
                        break;

                    // if item == "Remove"...
                    case "Remove":
                        // make form refer to the active child from
                        form = (Workshop_Form)ActiveMdiChild;
                        // make a new reference to a dialog that will ask the 
                        // user which item they want to remove
                        RemoveItem_Form rform = new RemoveItem_Form(form);
                        // show the dialog to the user
                        rform.ShowDialog();
                        // refresh the active form
                        form.UpdateListBox();
                        break;
                    // if item == "New"...
                    case "New":
                        // make dialog a reference to a dialog that will prompt 
                        // the user for a name of the new form
                        dialog = new WorkshopName_Dialog();
                        // show the dialog to the user
                        ((WorkshopName_Dialog)dialog).ShowDialog();
                        //if the name they enetered for the new form is valid...
                        if (((WorkshopName_Dialog)dialog).FileName != "" && ((WorkshopName_Dialog)dialog).FileName != null)
                        {
                            // if there is a child form...
                            if (ActiveMdiChild != null)
                            {
                                // and that active child has the same name as what was entered...
                                if (((WorkshopName_Dialog)dialog).FileName ==
                                    ((Workshop_Form)ActiveMdiChild).WorkshopName)
                                {
                                    // set the form to the active child
                                    form = (Workshop_Form)ActiveMdiChild;
                                }
                                else // the names are different
                                {
                                    // make a new form with the name the user entered
                                    form = new Workshop_Form(((WorkshopName_Dialog)
                                        dialog).FileName);
                                    // and make it's MdiParent the current form
                                    form.MdiParent = this;
                                }
                            }
                            else // there is not yet an active child
                            {
                                // so make a new form with the name the user entered
                                form = new Workshop_Form(((WorkshopName_Dialog)
                                    dialog).FileName);
                                // and make it's Mdiparent the current form
                                form.MdiParent = this;

                            }
                            // make the save option visible
                            saveToolStripMenuItem.Visible = true;
                            // add a tag to the form
                            form.Tag = "Child_" + Workshop_Form.Count;
                            // change the name of the form that the user sees appropriately
                            form.Text = form.WorkshopName;
                            // show the form to the user
                            form.Show();
                            // make the insert dorp down menu visible
                            Director_MenuStrip.Items[1].Visible = true;
                        }

                        break;
                    case "Open":
                        // make dialog a popup for finding a file in a file explorer
                        dialog = new OpenFileDialog();
                        // set the initial directory of the dialog the folder
                        // where the executable exists
                        ((OpenFileDialog)dialog).InitialDirectory =
                            Directory.GetCurrentDirectory();
                        // save the result of what the user does to close the dialog
                        result = ((OpenFileDialog)dialog).ShowDialog();
                        // get the file path from the dialog
                        filePath = ((OpenFileDialog)dialog).FileName;
                        // split the file path of the \ character
                        string[] FilePath = filePath.Split('\\');
                        // make a new child form that has a name of the file 
                        // selected without the extension
                        form = new Workshop_Form(FilePath[FilePath.Count() - 1].
                            Split('.')[0]);
                        // set the MdiParent of the form to the current form
                        form.MdiParent = this;
                        // if the file path was an actual path...
                        if (filePath != "" && filePath != null)
                        {
                            //insertToolStripMenuItem.Visible = true;
                            // show the save button
                            saveToolStripMenuItem.Visible = true;
                            // prepare for errors
                            try
                            {

                                // open a file
                                infile = new FileStream(filePath, FileMode.Open,
                                    FileAccess.Read);
                                // read from it until there is a SerializationException
                                while (true)
                                {
                                    // extract a record from the file
                                    Record rec = new Record((Record)formatter.
                                        Deserialize(infile));
                                    // and add it to the new forms lsit of records
                                    form.WorkshopItems.Add(rec);
                                }
                            }
                            catch (SerializationException)
                            {
                                // if the infile was declared...
                                if (infile != null)
                                    // close it
                                    infile.Close();
                                // make the name of the form that the user sees
                                // is set appropriately
                                form.Text = form.WorkshopName;
                                Director_MenuStrip.Items[1].Visible = true;
                                form.Show();
                            }
                            catch (FileNotFoundException)
                            {
                                // tell the user that there was no such file
                                MessageBox.Show("File not found", "FileNotFoundError",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            catch (FormatException)
                            {
                                // tell the user that there was an issue with the 
                                // format of the file being read from
                                MessageBox.Show("File not in proper format", 
                                    "FileFormatError", MessageBoxButtons.OK, 
                                    MessageBoxIcon.Exclamation);
                            }
                        }
                        break;
                    // if item == Save...
                    case "Save":
                        // if there is an active child...
                        if (ActiveMdiChild != null)
                        {
                            // set the form to the active child
                            form = (Workshop_Form)ActiveMdiChild;
                            // get the folder path of the executable
                            filePath = Directory.GetCurrentDirectory();
                            // if the form ahs an acceptable name...
                            if (form.WorkshopName != "" && form.WorkshopName != null)
                            {
                                // prepare for errors
                                try
                                {
                                    // make an output file with the form name and the 
                                    // extension .src
                                    outfile = new FileStream(
                                        form.WorkshopName + ".src", FileMode.OpenOrCreate,
                                        FileAccess.Write);
                                    // for all the records in the record list...
                                    foreach (Record rec in form.WorkshopItems)
                                    {
                                        // print the record to the file
                                        formatter.Serialize(outfile, rec);
                                    }
                                    // then close the file
                                    outfile.Close();
                                    // display a message saying that saving was 
                                    // successful
                                    MessageBox.Show("File successfully saved to " + 
                                        filePath + "\\" + form.WorkshopName + ".src",
                                        "Saved to " + form.WorkshopName + ".src", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (FileNotFoundException)
                                {
                                    // show an error about the file name being unvalid
                                    MessageBox.Show("File not found", "FileNotFoundError",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                catch (SerializationException)
                                {
                                    // show a message to the user about there being
                                    // an error writing to the file
                                    MessageBox.Show("Error writting to file", 
                                        "SerializationError", MessageBoxButtons.OK, 
                                        MessageBoxIcon.Exclamation);
                                    // and close the file
                                    outfile.Close();
                                }
                            }
                        }
                        break;
                    default:
                        // set the default value of result to 
                        // the abort result from a dialog
                        result = DialogResult.Abort;
                        break;
                }
            }
            catch (Exception ex)
            {
                // error message for unexpected error
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            // make the items in the file drop down menu visible
            foreach (ToolStripItem toolStripItem in fileToolStripMenuItem.
                DropDownItems)
            {
                toolStripItem.Visible = true;
            }
            // make the items in the items drop down menu visible
            foreach (ToolStripItem toolStripItem in itemsToolStripMenuItem.
                DropDownItems)
            {
                toolStripItem.Visible = true;
            }
        }
    }
}
