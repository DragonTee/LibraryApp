using System;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class AddBookDialog : Form
    {
        public AddBookDialog()
        {
            InitializeComponent();
            AddBookBtn.Click += (sender, args) =>
            {
                DialogResult = DialogResult.OK;
            };
        }

        public Book GetBook()
        {
            var book = new Book()
            {
                Name = BookName.Text,
                Author = BookAuthor.Text,
                AccessLevel = (int)AccessLevel.Value,
                ReturnDate = DateTime.Now,
                Taken = false,
                TakenBy = -1
            };
            return book;
        }
    }
}