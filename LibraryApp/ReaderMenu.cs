using System.Windows.Forms;

namespace LibraryApp
{
    public partial class ReaderMenu : Form
    {
        public ReaderMenu(ReaderUser user)
        {
            InitializeComponent();

            ViewBooksBtn.Click += (sender, args) =>
            {
                var filter = new BookFilter("","", -1, user.AccessLevel, false);
                FormsManager.ChangeForm(new BooksListForm(user.GetBooksListFiltered(filter))); 
            };
            ViewTakenBooksBtn.Click += (sender, args) =>
            {
                var filter = new BookFilter("","", user.Id, user.AccessLevel, false);
                FormsManager.ChangeForm(new BooksListForm(user.GetBooksListFiltered(filter))); 
                
            };
            SignOutBtn.Click += (sender, args) => { FormsManager.GoBack(); };

        }
    }
}