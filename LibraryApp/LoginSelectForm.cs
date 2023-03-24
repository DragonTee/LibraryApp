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

            
            LoginReaderBtn.Click += (sender, args) => { FormsManager.ChangeForm(new UserLoginForm(UsersDataManager.UserType.Reader)); };
            LoginLibrarianBtn.Click += (sender, args) => { FormsManager.ChangeForm(new UserLoginForm(UsersDataManager.UserType.Librarian)); };
            LoginDepartmentHeadBtn.Click += (sender, args) => { FormsManager.ChangeForm(new UserLoginForm(UsersDataManager.UserType.DepartmentHead)); };
            LoginHeadManagerBtn.Click += (sender, args) => { FormsManager.ChangeForm(new UserLoginForm(UsersDataManager.UserType.HeadManager)); };
            /*LoginReaderBtn.Click += (sender, args) => { FormsManager.ChangeForm(new ReaderMenu(new ReaderUser(0,""))); };
            LoginLibrarianBtn.Click += (sender, args) => { FormsManager.ChangeForm(new LibrarianMenu(new Librarian("", 0))); };
            LoginDepartmentHeadBtn.Click += (sender, args) => { FormsManager.ChangeForm(new DepartmentHeadMenu(new DepartmentHead("",1,1))); };
            LoginHeadManagerBtn.Click += (sender, args) => { FormsManager.ChangeForm(new HeadManagerMenu(new HeadManager())); };*/

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}