using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryApp
{
    public class UsersList
    {
        private static UsersList instance;

        public static UsersList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UsersList();
                }

                return instance;
            }
        }

        private List<ReaderUser> usersList;
        public List<ReaderUser> GetUsersList => usersList;
        
        public UsersList()
        {
            usersList = new List<ReaderUser>();
            var users = DataManager.LoadAllUsersData();
            foreach (var user in users)
            {    
                if (user.type == DataManager.UserType.Reader)
                    usersList.Add(new ReaderUser(new ReaderUser(user.attribute, user.name), user.id));
            }
        }

        public void AddUser(ReaderUser user)
        {
            var newUser = new ReaderUser(user, usersList.Count);
            usersList.Add(user);
            var newUserData = new DataManager.UserData()
            {
                name = newUser.Name,
                login = newUser.Name,
                attribute = newUser.AccessLevel,
                id = newUser.Id,
                password = newUser.Name,
                type = DataManager.UserType.Reader
            };
            DataManager.SaveUser(newUserData);
        }

        public void ChangeUserAccess(int id, int newAccesssLevel)
        {
            foreach (var user in usersList)
            {
                user.AccessLevel = newAccesssLevel;
            }
        }
    }
}