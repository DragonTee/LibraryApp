using System.Windows.Forms;

namespace LibraryApp
{
    public partial class DepartmentManagersListRow : Form
    {
        public DepartmentManagersListRow(DepartmentHead manager, DepartmentManagersListForm parent)
        {
            InitializeComponent();
            UserId.Text = manager.Id.ToString();
            UserName.Text = manager.Name;
            DepartmentId.Text = manager.DepartmentId.ToString();
            RemoveBtn.Click += (sender, args) =>
            {
                parent.RemoveDepartmentHead(manager);
            };
        }
    }
}