using System.Windows.Forms;

namespace LibraryApp
{
    public partial class AddDepartmentManagerDialog : Form
    {
        public AddDepartmentManagerDialog()
        {
            InitializeComponent();
            AddManagerBtn.Click += (sender, args) =>
            {
                DialogResult = DialogResult.OK;  
            };
        }

        public DepartmentHead GetManager()
        {
            var manager = new DepartmentHead(ManagerName.Text, 0, (int)DepartmentId.Value);
            return manager;
        }
    }
}