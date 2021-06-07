using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class BooksListForm : Form
    {
        private List<BooksListRow> childForms = new List<BooksListRow>();
        private List<Book> booksUnfiltered;
        public BooksListForm(List<Book> books)
        {
            InitializeComponent();
            
            booksUnfiltered = books;
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
                var newRow = new BooksListRow(book);
                childForms.Add(newRow);
                foreach (Control control in newRow.Controls)
                {
                    TablePanel.Controls.Add(control);    
                }
            }
        }

        private void FilterBooks(BookFilter filter)
        {
            TablePanel.Controls.Clear();
            CloseChildForms();
            
            foreach (var book in filter.FilterList(booksUnfiltered))
            {
                var newRow = new BooksListRow(book);
                childForms.Add(newRow);
                foreach (Control control in newRow.Controls)
                {
                    TablePanel.Controls.Add(control);    
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