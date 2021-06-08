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
                FormsManager.ChangeForm(new BooksListLibrarianForm(librarian.GetBooksList(), librarian));
            };
            ViewUsersBtn.Click += (sender, args) =>
            {
                FormsManager.ChangeForm(new UsersListForm(librarian.GetUsersList()));
            };
            AddUserBtn.Click += (sender, args) =>
            {
                var dialog = new AddUserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                    librarian.AddUserToList(dialog.GetUser());  
            };
            AddBookBtn.Click += (sender, args) =>
            { 
                var dialog = new AddBookDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                    librarian.AddBookToList(dialog.GetBook());  
            };
            SignOutBtn.Click += (sender, args) =>
            {
                FormsManager.GoBack();
            };
        }
    }
}