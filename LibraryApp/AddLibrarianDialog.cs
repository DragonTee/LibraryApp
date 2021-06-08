using System;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class AddLibrarianDialog : Form
    {
        public AddLibrarianDialog()
        {
            InitializeComponent();
            AddUserBtn.Click += (sender, args) =>
            {
                DialogResult = DialogResult.OK;
            };
        }

        public string GetLibrarianName()
        {
            return UserName.Text;
        }
    }
}