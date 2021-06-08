using System;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class DepartmentHeadMenu : Form
    {
        public DepartmentHeadMenu(DepartmentHead manager)
        {
            InitializeComponent();

            ViewLibrariansBtn.Click += (sender, args) =>
            {
                FormsManager.ChangeForm(new LibrariansListForm(manager.GetLibrariansList(), manager));
            };
            AddLibrarianBtn.Click += (sender, args) =>
            {
                var dialog = new AddLibrarianDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                    manager.AddLibrarian(dialog.GetLibrarianName());
            };
            SignOutBtn.Click += (sender, args) =>
            {
                FormsManager.GoBack();
            };
        }
    }
}