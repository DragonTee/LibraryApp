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
            return BooksList.Instance.GetBooksList();
        }
        
        public List<Book> GetBooksListFiltered(BookFilter filter)
        {
            return filter.FilterList(BooksList.Instance.GetBooksList());
        }

        public List<ReaderUser> GetUsersList()
        {
            return null;
        }

        public void ReturnBook(Book book)
        {
            BooksList.Instance.ReturnBook(book);
        }

        public void CreateOrder(Book book, int userId)
        {
            BooksList.Instance.SetAsTaken(book, userId);
        }

        public void SetUserAccessLevel(int userId, int accessLevel)
        {
            UsersList.Instance.ChangeUserAccess(userId, accessLevel);
        }

        public void AddBookToList(Book book)
        {
            BooksList.Instance.AddBook(book);
        }

        public void AddUserToList(ReaderUser user)
        {
            UsersList.Instance.AddUser(user);
        }

        public void WriteOffBook(Book book)
        {
            BooksList.Instance.RemoveBook(book);
        }
    }
}