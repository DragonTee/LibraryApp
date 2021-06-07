using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class BooksListLibrarianForm : Form
    {
        private List<BooksListLibrarianRow> childForms;
        private List<Book> booksUnfiltered;
        private Librarian librarian;
        private Panel mainPanel;
        
        public BooksListLibrarianForm(List<Book> books, Librarian librarian)
        {
            InitializeComponent();
            
            booksUnfiltered = books;
            this.librarian = librarian;
            BackBtn.Click += (sender, args) => { FormsManager.GoBack(); };
            FilterBtn.Click += (sender, args) => { throw new NotImplementedException(); }; 

            foreach (var book in booksUnfiltered)
            {
                var newRow = new BooksListLibrarianRow(book, this);
                childForms.Add(newRow);
                foreach (Control control in newRow.Controls)
                {
                    mainPanel.Controls.Add(control);    
                }
            }
        }
        
        private void FilterBooks(BookFilter filter)
        {
            mainPanel.Controls.Clear();
            CloseChildForms();
            
            foreach (var book in filter.FilterList(booksUnfiltered))
            {
                var newRow = new BooksListLibrarianRow(book, this);
                childForms.Add(newRow);
                foreach (Control control in newRow.Controls)
                {
                    mainPanel.Controls.Add(control);    
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            CloseChildForms();
        }
        
        private void CloseChildForms()
        {
            foreach (var form in childForms)
            {
                form.Close();
            }
            childForms.Clear();
        }
    }
}