using System.Windows.Forms;

namespace LibraryApp
{
    public partial class BooksListRow : Form
    {
        public BooksListRow(Book book)
        {
            InitializeComponent();
            
            BookName.Text = book.Name;
            BookAuthor.Text = book.Author;
        }
    }
}