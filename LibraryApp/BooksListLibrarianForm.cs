using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class BooksListLibrarianForm : Form
    {
        private List<BooksListLibrarianRow> childForms = new List<BooksListLibrarianRow>();
        private List<Book> booksUnfiltered = new List<Book>();
        private Librarian librarian;
        private Panel mainPanel;
        
        public BooksListLibrarianForm(List<Book> books, Librarian librarian)
        {
            InitializeComponent();

            mainPanel = TablePanel;
            booksUnfiltered = books;
            this.librarian = librarian;
            BackBtn.Click += (sender, args) => { FormsManager.GoBack(); };
            FilterBtn.Click += (sender, args) =>
            {
                var filterDialog = new FilterDialogForm();
                if (filterDialog.ShowDialog() == DialogResult.OK)
                {
                    FilterBooks(filterDialog.GetFilter());
                }
            };
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

        public void WriteOffBook(Book book)
        {
            librarian.WriteOffBook(book);
            FilterBooks(new BookFilter("", "", -1, 100, false));
        }

        public void MakeOrder(Book book, int userId)
        {
            librarian.CreateOrder(book, userId);
            FilterBooks(new BookFilter("", "", -1, 100, false));
        }

        public void ReturnBook(Book book)
        {
            librarian.ReturnBook(book);
            FilterBooks(new BookFilter("", "", -1, 100, false));
        }
    }
}