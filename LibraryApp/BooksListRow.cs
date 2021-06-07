using System.Windows.Forms;

namespace LibraryApp
{
    public partial class BooksListRow : Form
    {
        public BooksListRow(Book book)
        {
            InitializeComponent();
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
                }
            }
        }
    }
}