using System.Collections.Generic;

namespace LibraryApp
{
    public class BooksList
    {
        private static BooksList instance;

        public static BooksList Instance
        {
            get
            {
                if (instance == null)
                    instance = new BooksList();
                return instance;
            }
        }

        private List<Book> books;

        public BooksList()
        {
            books = new List<Book>();
        }

        public List<Book> GetBooksList() => books;
        
        public List<Book> GetBooksList(BookFilter filter)
        {
            return books;
        }
        
        public List<Book> GetTakenBooks(BookFilter filter)
        {
            return books;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public void SetAsTaken(Book book, int id)
        {
            return;
        }

        public void ReturnBook(Book book)
        {
            return;
        }
    }
}