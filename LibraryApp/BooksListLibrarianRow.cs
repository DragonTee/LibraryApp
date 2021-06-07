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
                BooksList.Instance.RemoveBook(book);
                throw new NotImplementedException();
            };
            OrderBtn.Click += (sender, args) => { BooksList.Instance.SetAsTaken(book, 0);
                throw new NotImplementedException();
            };
            ReturnBtn.Click += (sender, args) => { BooksList.Instance.ReturnBook(book);
                throw new NotImplementedException();
            };
        }
    }
}