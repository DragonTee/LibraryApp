using System.Windows.Forms;

namespace LibraryApp
{
    public partial class DepartmentListRow : Form
    {
        public DepartmentListRow(Department department, DepartmentListForm parent)
        {
            InitializeComponent();
            DepId.Text = department.Id.ToString();
            RemoveBtn.Click += (sender, args) =>
            {
                parent.DeleteDepartment(department);
            };
        }
    }
}