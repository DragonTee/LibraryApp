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
            user = new ReaderUser(user, usersList.Count);
            usersList.Add(user);
            DataManager.SaveUser(new DataManager.UserData()
            {
                name = user.Name,
                login = user.Name,
                attribute = user.AccessLevel,
                id = user.Id,
                password = user.Name,
                type = DataManager.UserType.Reader
            });
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