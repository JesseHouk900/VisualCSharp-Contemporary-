using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayTable
{
    public partial class DisplayAuthorsTable : Form
    {
        public DisplayAuthorsTable()
        {
            InitializeComponent();
        }

        private BooksExample.BooksEntities dbContext = new BooksExample.BooksEntities();

        //load data from database into DataGridView
        private void DisplayAuthorsTable_Load(object sender, EventArgs e)
        {
            //load Authors table orderd by LastName then FirstName
            dbContext.Authors
               .OrderBy(author => author.LastName)
               .ThenBy(author => author.FirstName)
               .Load();

            //specify DataSource for authorBindingSource
            authorBindingSource.DataSource = dbContext.Authors.Local;

        }

        //click event handler for the Save Button in the 
        //BindingNavigator saves the changes made to the database
        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();  //validate the input fields
            authorBindingSource.EndEdit();  //complete current edit, if any

            //try to save changes
            try
            {
                dbContext.SaveChanges(); //write changes to database file
            }
            catch(DbEntityValidationException)
            {
                MessageBox.Show("FirstName and LastName must contain values",
                    "Entity Validation Exception");
            }
        }
    }
}
