using System.Windows.Forms;

namespace LibraryApp
{
    public partial class FilterDialogForm : Form
    {
        public FilterDialogForm()
        {
            InitializeComponent();
            OkBtn.Click += (sender, args) => { DialogResult = DialogResult.OK; };
        }

        public BookFilter GetFilter()
        {
            var bookName = BookName.Text;
            var author = BookAuthor.Text;
            var descending = DescendingOrder.Checked;
            return new BookFilter(bookName, author, -1, 100, descending);
        }
    }
}