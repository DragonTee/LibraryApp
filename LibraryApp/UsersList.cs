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
        }

        public void AddUser(ReaderUser user)
        {
            usersList.Add(new ReaderUser(user, usersList.Count));
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