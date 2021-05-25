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
        
        public void AddLibrarian(string name)
        {
            librarians.Add(new Librarian(name, librarians.Count));
        }

        public void RemoveLibrarian(int id)
        {
            librarians.Remove(librarians[id]);
        }

        public int Id => id;

    }
}