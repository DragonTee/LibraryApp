using System.Windows.Forms;

namespace LibraryApp
{
    public partial class AddUserDialog : Form
    {
        public AddUserDialog()
        {
            InitializeComponent();
            AddUserBtn.Click += (sender, args) =>
            {
                DialogResult = DialogResult.OK;
            };
        }

        public ReaderUser GetUser()
        {
            return new ReaderUser((int)AccessLevel.Value, UserName.Text);
        }
    }
}