/*      Jesse Houk - WorkshopName_Dialog
 *      Purpose - Used to prompt the user for a name for a new workshop form
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

    public partial class WorkshopName_Dialog : Form
    {
        // name for the new form is also used for the file name if the form is saved
        public string FileName;
        
        // default constructor
        public WorkshopName_Dialog()
        {
            InitializeComponent();
            // initialize the positions of the components on the form
            SetComponentPositions();
        }

        // method to set the position of the components of the form that the user 
        // will interact with
        public void SetComponentPositions()
        {
            UserPrompt_Label.Location = new Point((this.Width / 2) -
                (UserPrompt_Label.Size.Width / 2), Height / 10);
            WorkshopName_TextBox.Location = new Point(UserPrompt_Label.Location.X +
                (UserPrompt_Label.Size.Width / 2) - 
                (WorkshopName_TextBox.Size.Width / 2), Height * 2 / 5);
            OK_Button.Location = new Point(UserPrompt_Label.Location.X +
                (UserPrompt_Label.Size.Width / 2) - (OK_Button.Size.Width / 2),
                Height * 3 / 5);
        }

        // event handler for when the dialog is first shown
        private void WorkshopName_Dialog_Load(object sender, EventArgs e)
        {
            // make the textbox empty
            WorkshopName_TextBox.Text = "";
            // initialize the default fileName to be empty
            FileName = "";
        }

        // event handler for when the Ok button is clicked
        private void OK_Button_Click(object sender, EventArgs e)
        {
            // if the file name is not empty and the first letter is not a number
            if (WorkshopName_TextBox.Text != "" && 
                WorkshopName_TextBox.Text[0] - '0' >= 10)
            {
                // save the name entered
                FileName = WorkshopName_TextBox.Text;
                // and close the dialog
                Close();
            }
            else
            {
                // print an error message
                MessageBox.Show("File Name is not usable", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
    }
}
