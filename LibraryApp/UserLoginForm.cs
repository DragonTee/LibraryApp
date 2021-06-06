using System;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class UserLoginForm : Form
    {
        private LoginSelectForm MainForm;
        
        public UserLoginForm()
        {
            InitializeComponent();
        }

        public void GoBack(object sender, EventArgs e)
        {
            FormsManager.GoBack();
        }
    }
}