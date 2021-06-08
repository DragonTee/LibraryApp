using System.Windows.Forms;

namespace LibraryApp
{
    public partial class LibrariansListRow : Form
    {
        public LibrariansListRow(Librarian librarian, LibrariansListForm parent)
        {
            InitializeComponent();
            UserId.Text = librarian.Id.ToString();
            UserName.Text = librarian.Name;
            RemoveBtn.Click += (sender, args) =>
            {
                parent.RemoveLibrarian(librarian);
            };
        }
    }
}