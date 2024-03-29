﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class DepartmentManagersListForm : Form
    {
        private List<DepartmentManagersListRow> childForms = new List<DepartmentManagersListRow>();
        private HeadManager headManager;
        private List<DepartmentHead> managers;
        public DepartmentManagersListForm(List<DepartmentHead> managers, HeadManager headManager)
        {
            InitializeComponent();
            this.headManager = headManager;
            this.managers = managers;
            BackBtn.Click += (sender, args) => { FormsManager.GoBack(); };
            foreach (var manager in managers)
            {
                var newRow = new DepartmentManagersListRow(manager, this);
                childForms.Add(newRow);
                foreach (Control control in newRow.Controls)
                {
                    TablePanel.Controls.Add(control);
                }
            }
        }

        public void RemoveDepartmentHead(DepartmentHead manager)
        {
            headManager.DeleteDepartmentHead(manager);
            CloseChildForms();
            foreach (var managerRow in managers)
            {
                var newRow = new DepartmentManagersListRow(managerRow, this);
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