using System;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class LibrarianMenu : Form
    {
        private Librarian librarian;
        public LibrarianMenu(Librarian librarian)
        {
            InitializeComponent();

            this.librarian = librarian;
            ViewBooksBtn.Click += (sender, args) =>
            {
                FormsManager.ChangeForm(new BooksListForm(librarian.GetBooksList()));
            };
            ViewUsersBtn.Click += (sender, args) =>
            {
                throw new NotImplementedException();
            };
            AddUserBtn.Click += (sender, args) =>
            {
                throw new NotImplementedException();
            };
            SignOutBtn.Click += (sender, args) =>
            {
                FormsManager.GoBack();
            };
        }
    }
}