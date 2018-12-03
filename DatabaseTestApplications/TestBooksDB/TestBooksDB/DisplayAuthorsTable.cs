using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBooksDB
{
    public partial class DisplayAuthorsTable : Form
    {
        public DisplayAuthorsTable()
        {
            InitializeComponent();
        }

        private void authorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);

        }

        private void DisplayAuthorsTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.booksDataSet.Authors);

        }
    }
}
