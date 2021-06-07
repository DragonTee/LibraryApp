using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class UsersListForm : Form
    {
        private List<UsersListRow> childForms = new List<UsersListRow>();
        public UsersListForm(List<ReaderUser> users)
        {
            InitializeComponent();
            BackBtn.Click += (sender, args) => { FormsManager.GoBack(); };
            foreach (var user in users)
            {
                var newRow = new UsersListRow(user);
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