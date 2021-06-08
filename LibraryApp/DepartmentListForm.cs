using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class DepartmentListForm : Form
    {
        private List<Department> departments;
        private HeadManager headManager;
        private List<DepartmentListRow> childForms = new List<DepartmentListRow>();
        public DepartmentListForm(List<Department> departments, HeadManager headManager)
        {            
            InitializeComponent();
            this.headManager = headManager;
            this.departments = departments;
            BackBtn.Click += (sender, args) => { FormsManager.GoBack(); };
            foreach (var department in departments)
            {
                var newRow = new DepartmentListRow(department, this);
                childForms.Add(newRow);
                foreach (Control control in newRow.Controls)
                {
                    TablePanel.Controls.Add(control);
                }
            }
        }

        public void DeleteDepartment(Department department)
        {
            headManager.DeleteDepartment(department);
            CloseChildForms();
            foreach (var departmentRow in departments)
            {
                var newRow = new DepartmentListRow(departmentRow, this);
                childForms.Add(newRow);
                foreach (Control control in newRow.Controls)
                {
                    TablePanel.Controls.Add(control);
                }
            }
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            CloseChildForms();
        }

        private void CloseChildForms()
        {
            TablePanel.Controls.Clear();
            foreach (var form in childForms)
            {
                form.Close();
            }           
            childForms.Clear();
        }
    }
}