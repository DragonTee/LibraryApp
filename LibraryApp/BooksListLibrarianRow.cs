using System;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class BooksListLibrarianRow : Form
    {
        private BooksListLibrarianForm parentForm;
        public BooksListLibrarianRow(Book book, BooksListLibrarianForm parent)
        {
            InitializeComponent();
            parentForm = parent;

            BookName.Text = book.Name;
            BookAuthor.Text = book.Author;
            BookTaken.Text = book.Taken ? book.TakenBy.ToString() : "-";
            WriteOffBtn.Click += (sender, args) =>
            {
                parent.WriteOffBook(book);
            };
            OrderBtn.Click += (sender, args) => { 
                var dialog = new OrderBookDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                    parent.MakeOrder(book, dialog.GetUserId());
            };
            ReturnBtn.Click += (sender, args) => { 
                parent.ReturnBook(book);
            };
        }
    }
}