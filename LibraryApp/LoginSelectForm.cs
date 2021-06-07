using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class LoginSelectForm : Form
    {
        private int currentUserType;
        
        public LoginSelectForm(bool secondaryForm = false)
        {
            if (!secondaryForm)
                FormsManager.MainForm = this;
            InitializeComponent();

            LoginReaderBtn.Click += (sender, args) => { FormsManager.ChangeForm(new ReaderMenu(new ReaderUser(0,""))); };
            LoginLibrarianBtn.Click += (sender, args) => { FormsManager.ChangeForm(new LibrarianMenu(new Librarian("", 0))); };
            LoginDepartmentHeadBtn.Click += (sender, args) => { FormsManager.ChangeForm(new DepartmentHeadMenu()); };
            LoginHeadManagerBtn.Click += (sender, args) => { FormsManager.ChangeForm(new HeadManagerMenu()); };

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
        
        public void ChangeForms(object sender, EventArgs e)
        {
            FormsManager.ChangeForm(new UserLoginForm());
        }
    }
}