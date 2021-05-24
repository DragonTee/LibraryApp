using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace LibraryApp
{
    public class Librarian
    {
        private string name;
        private int id;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Id => id;

        public Librarian(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        
        public List<Book> GetBooksList()
        {
            return null;
        }
        
        public List<Book> GetBooksListFiltered(BookFilter filter)
        {
            return null;
        }

        public List<Book> GetUsersList()
        {
            return null;
        }

        public void ReturnBook(Book book)
        {
            return;
        }

        public void CreateOrder(Book book)
        {
            return;
        }

        public void SetUserAccessLevel(int accessLevel)
        {
            return;
        }

        public void AddBookToList(Book book)
        {
            return;
        }

        public void WriteOffBook(Book book)
        {
            return;
        }
    }
}