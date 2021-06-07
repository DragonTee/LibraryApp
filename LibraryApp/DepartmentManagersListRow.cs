using System.Windows.Forms;

namespace LibraryApp
{
    public partial class DepartmentManagersListRow : Form
    {
        public DepartmentManagersListRow(DepartmentHead manager)
        {
            InitializeComponent();
            UserId.Text = manager.Id.ToString();
            UserName.Text = manager.Name;
            DepartmentId.Text = manager.DepartmentId.ToString();
        }
    }
}