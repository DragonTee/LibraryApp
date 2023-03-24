using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class UserLoginForm : Form
    {        
        public UserLoginForm(UsersDataManager.UserType type)
        {
            InitializeComponent();
            BackBtn.Click += (sender, args) =>
            {
                FormsManager.GoBack();  
            };
            LogInBtn.Click += (sender, args) =>
            {
                if (CheckLogin(type))
                {
                    var loggedReaderUser = UsersList.Instance.GetUsersList.First(user => user.Name == Username.Text);
                    var loggedHeadUser = DepartmentHeadsList.Instance.GetDepartmentHeads.First(user => user.Name == Username.Text);
                    switch (type)
                    {
                        case UsersDataManager.UserType.Reader:
                            FormsManager.ChangeForm(new ReaderMenu(loggedReaderUser));
                            break;
                        case UsersDataManager.UserType.Librarian:
                            FormsManager.ChangeForm(new LibrarianMenu(new Librarian(loggedReaderUser.Name, loggedReaderUser.Id)));
                            break;
                        case UsersDataManager.UserType.DepartmentHead:
                            FormsManager.ChangeForm(new DepartmentHeadMenu(loggedHeadUser));
                            break;
                        case UsersDataManager.UserType.HeadManager:
                            FormsManager.ChangeForm(new HeadManagerMenu(new HeadManager()));
                            break;
                    }
                }
            };
        }

        private bool CheckLogin(UsersDataManager.UserType userType)
        {
            var users = UsersDataManager.LoadAllUsersData();
            foreach (var user in users)
            {
                if (user.type == userType && Password.Text.Equals(user.password) && Username.Text.Equals(user.login))
                    return true;
            }
            return false;
        }

        public void GoBack(object sender, EventArgs e)
        {
            FormsManager.GoBack();
        }
    }
}