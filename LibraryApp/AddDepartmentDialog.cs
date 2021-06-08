using System.Windows.Forms;

namespace LibraryApp
{
    public partial class AddDepartmentDialog : Form
    {
        public AddDepartmentDialog(int id)
        {
            InitializeComponent();
            Notification.Text = $@"Department #{id} is created.";
            OkBtn.Click += (sender, args) =>
            {
                DialogResult = DialogResult.OK;
            };
        }

    }
}