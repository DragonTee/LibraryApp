using System;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class DepartmentHeadMenu : Form
    {
        public DepartmentHeadMenu()
        {
            InitializeComponent();

            ViewLibrariansBtn.Click += (sender, args) =>
            {
                throw new NotImplementedException();
            };
            AddLibrarianBtn.Click += (sender, args) =>
            {
                throw new NotImplementedException();
            };
            SignOutBtn.Click += (sender, args) =>
            {
                FormsManager.GoBack();
            };
        }
    }
}