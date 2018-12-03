using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace JoinQueries
{
    public partial class JoiningTableDataForm : Form
    {
        public JoiningTableDataForm()
        {
            InitializeComponent();
        }

        private void JoiningTableDataForm_Load(object sender, EventArgs e)
        {
            // Entity Framework DbContext
            var dbcontext = new BooksExample.BooksEntities();

            // get authors and ISBNs of each book they co-authored
            var authorsAndISBNs =
               from author in dbcontext.Authors
               from book in author.Titles
               orderby author.LastName, author.FirstName
               select new { author.FirstName, author.LastName, book.ISBN };

            outputTextBox.AppendText("Authors and ISBNs:");

            // display authors and ISBNs in tabular format
            foreach (var element in authorsAndISBNs)
            {
                outputTextBox.AppendText($"\r\n\t{element.FirstName,-10} " +
                   $"{element.LastName,-10} {element.ISBN,-10}");
            }

            // get authors and titles of each book they co-authored
            var authorsAndTitles =
               from book in dbcontext.Titles
               from author in book.Authors
               orderby author.LastName, author.FirstName, book.Title1
               select new { author.FirstName, author.LastName, book.Title1 };

            outputTextBox.AppendText("\r\n\r\nAuthors and titles:");

            // display authors and titles in tabular format
            foreach (var element in authorsAndTitles)
            {
                outputTextBox.AppendText($"\r\n\t{element.FirstName,-10} " +
                   $"{element.LastName,-10} {element.Title1}");
            }

            // get authors and titles of each book 
            // they co-authored; group by author
            var titlesByAuthor =
               from author in dbcontext.Authors
               orderby author.LastName, author.FirstName
               select new
               {
                   Name = author.FirstName + " " + author.LastName,
                   Titles =
                     from book in author.Titles
                     orderby book.Title1
                     select book.Title1
               };

            outputTextBox.AppendText("\r\n\r\nTitles grouped by author:");

            // display titles written by each author, grouped by author
            foreach (var author in titlesByAuthor)
            {
                // display author's name
                outputTextBox.AppendText($"\r\n\t{author.Name}:");

                // display titles written by that author
                foreach (var title in author.Titles)
                {
                    outputTextBox.AppendText($"\r\n\t\t{title}");
                }
            }
        }
    }
}
