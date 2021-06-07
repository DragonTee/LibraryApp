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
            foreach (Control control in Controls)
            {
                switch (control.Name)
                {
                    case "BookName":
                        control.Text = book.Name;
                        break;
                    case "BookAuthor":
                        control.Text = book.Author;
                        break;
                    case "BookTaken":
                        control.Text = book.Taken ? book.TakenBy.ToString() : "-";
                        break;
                    case "WriteOffBtn":
                        control.Click += (sender, args) =>
                        {
                            BooksList.Instance.RemoveBook(book);
                            throw new NotImplementedException();
                        };
                        break;
                    case "OrderBtn":
                        control.Click += (sender, args) => { BooksList.Instance.SetAsTaken(book, 0);
                            throw new NotImplementedException();
                        };
                        break;
                    case "ReturnBtn":
                        control.Click += (sender, args) => { BooksList.Instance.ReturnBook(book);
                            throw new NotImplementedException();
                        };
                        break;
                }
            }
        }
    }
}