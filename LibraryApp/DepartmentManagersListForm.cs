using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class DepartmentManagersListForm : Form
    {
        private List<DepartmentManagersListRow> childForms = new List<DepartmentManagersListRow>();
        public DepartmentManagersListForm(List<DepartmentHead> managers)
        {
            InitializeComponent();
            BackBtn.Click += (sender, args) => { FormsManager.GoBack(); };
            foreach (var manager in managers)
            {
                var newRow = new DepartmentManagersListRow(manager);
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
            foreach (var form in childForms)
            {
                form.Close();
            }
            childForms.Clear();
        }
    }
}