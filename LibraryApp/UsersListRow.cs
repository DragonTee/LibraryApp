using System.Windows.Forms;

namespace LibraryApp
{
    public partial class UsersListRow : Form
    {
        public UsersListRow(ReaderUser user)
        {
            InitializeComponent();
            UserId.Text = user.Id.ToString();
            UserName.Text = user.Name;
            UserAccess.Text = user.AccessLevel.ToString();
        }
    }
}