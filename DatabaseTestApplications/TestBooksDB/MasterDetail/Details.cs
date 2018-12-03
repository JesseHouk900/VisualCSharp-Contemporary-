using System;
using System.Windows.Forms;

namespace MasterDetail
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        // Entity Framework DbContext
        BooksDataSet dbcontext = new BooksDataSet();

        // initialize data sources when the Form is loaded
        private void Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.booksDataSet.Authors);
            // TODO: This line of code loads data into the 'booksDataSet.Titles' table. You can move, or remove it, as needed.
            this.titlesTableAdapter.Fill(this.booksDataSet.Titles);
        }

        private void authorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);

        }

        private void authorsBindingNavigator_TabIndexChanged(object sender, EventArgs e)
        {
            //pull data out of booksDataSet.Titles where the ISBN and author ID are same as in authorsBindingNavigator

            
            // TODO: This line of code loads data into the 'booksDataSet.Titles' table. You can move, or remove it, as needed.
            this.titlesTableAdapter.Fill(this.booksDataSet.Titles);

        }
    }
}
