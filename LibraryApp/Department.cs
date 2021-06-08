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
            var users = DataManager.LoadAllUsersData();
            foreach (var user in users)
            {
                if (user.type == DataManager.UserType.Librarian && user.id == id)
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
            DataManager.AddLibrarianToDepartment(id, maxId);
            DataManager.SaveUser(new DataManager.UserData()
            {
                name = name,
                login = name,
                attribute = 0,
                password = name,
                id = maxId,
                type = DataManager.UserType.Librarian
            });
        }

        public void RemoveLibrarian(int id)
        {
            foreach (var librarian in librarians)
            {
                if (librarian.Id == id)
                {
                    librarians.Remove(librarian);
                    DataManager.DeleteUser(librarian.Name);
                    break;
                }
            }
            DataManager.RemoveLibrarianFromDepartment(this.id, id);
        }

        public int Id => id;

    }
}