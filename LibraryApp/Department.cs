using System;
using System.Collections.Generic;

namespace LibraryApp
{
    public class Department
    {
        private List<Librarian> librarians;
        private int id;

        public List<Librarian> GetLibrarians() => librarians;

        public Department(int id)
        {
            librarians = new List<Librarian>();
            this.id = id;
        }

        public void AddLibrarian(int id)
        {
            var users = UsersDataManager.LoadAllUsersData();
            foreach (var user in users)
            {
                if (user.type == UsersDataManager.UserType.Librarian && user.id == id)
                {
                    var librarian = new Librarian(user.login, id);
                    librarians.Add(librarian);
                    break;
                }
            }            
        }
        
        public void AddLibrarian(string name)
        {
            int maxId = -1;
            foreach (var librarian in librarians)
            {
                maxId = Math.Max(maxId, librarian.Id);
            }
            maxId += 1;
            librarians.Add(new Librarian(name, maxId));
            DepartmentDataManager.AddLibrarianToDepartment(id, maxId);
            UsersDataManager.SaveUser(new UsersDataManager.UserData()
            {
                name = name,
                login = name,
                attribute = 0,
                password = name,
                id = maxId,
                type = UsersDataManager.UserType.Librarian
            });
        }

        public void RemoveLibrarian(int id)
        {
            foreach (var librarian in librarians)
            {
                if (librarian.Id == id)
                {
                    librarians.Remove(librarian);
                    UsersDataManager.DeleteUser(librarian.Name);
                    break;
                }
            }
            DepartmentDataManager.RemoveLibrarianFromDepartment(this.id, id);
        }

        public int Id => id;

    }
}