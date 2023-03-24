using System;
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
                    switch (type)
                    {
                        case UsersDataManager.UserType.Reader:
                            foreach (var user in UsersList.Instance.GetUsersList)
                            {
                                if (user.Name.Equals(Username.Text))
                                    FormsManager.ChangeForm(new ReaderMenu(user)); 
                            }
                            break;
                        case UsersDataManager.UserType.Librarian:
                            var users = UsersDataManager.LoadAllUsersData();
                            foreach (var user in users)
                            {
                                if (user.type == UsersDataManager.UserType.Librarian && Username.Text.Equals(user.name))
                                    FormsManager.ChangeForm(new LibrarianMenu(new Librarian(user.name, user.id))); 
                            }
                            break;
                        case UsersDataManager.UserType.DepartmentHead:
                            foreach (var user in DepartmentHeadsList.Instance.GetDepartmentHeads)
                            {
                                if (user.Name.Equals(Username.Text))
                                    FormsManager.ChangeForm(new DepartmentHeadMenu(user)); 
                            }
                            break;
                        case UsersDataManager.UserType.HeadManager:
                            FormsManager.ChangeForm(new HeadManagerMenu(new HeadManager()));
                            break;
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