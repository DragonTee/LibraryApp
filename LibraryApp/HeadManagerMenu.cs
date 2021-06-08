using System;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class HeadManagerMenu : Form
    {
        public HeadManagerMenu(HeadManager headManager)
        {
            InitializeComponent();
            
            ViewDepartmentsBtn.Click += (sender, args) =>
            {
                FormsManager.ChangeForm(new DepartmentListForm(headManager.GetDepartmentsList(), headManager));
            };
            ViewHeadsBtn.Click += (sender, args) =>
            {
                FormsManager.ChangeForm(new DepartmentManagersListForm(headManager.GetDepartmentHeads(), headManager));
            };
            AddDepartmentBtn.Click += (sender, args) =>
            {
                var dialog = new AddDepartmentDialog(headManager.CreateNewDepartment());
                dialog.ShowDialog();
            };
            AddHeadBtn.Click += (sender, args) =>
            {
                var dialog = new AddDepartmentManagerDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var manager = dialog.GetManager();
                    headManager.AddDepartmentHead(manager.Name, manager.DepartmentId);
                }
            };
            SignOutBtn.Click += (sender, args) =>
            {
                FormsManager.GoBack();
            };
        }
    }
}