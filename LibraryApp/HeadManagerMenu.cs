using System;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class HeadManagerMenu : Form
    {
        public HeadManagerMenu()
        {
            InitializeComponent();
            
            ViewDepartmentsBtn.Click += (sender, args) =>
            {
                throw new NotImplementedException();
            };
            ViewHeadsBtn.Click += (sender, args) =>
            {
                throw new NotImplementedException();
            };
            AddDepartmentBtn.Click += (sender, args) =>
            {
                throw new NotImplementedException();
            };
            AddHeadBtn.Click += (sender, args) =>
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