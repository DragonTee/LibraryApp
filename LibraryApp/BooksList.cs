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
            return filter.FilterList(books);
        }
        
        public List<Book> GetTakenBooks(int id)
        {
            var filter = new BookFilter("", "", id, 100, false);
            return filter.FilterList(books);
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
            var index = books.FindIndex(book.Equals);
            if (books[index].Taken)
                return;
            books[index].Taken = true;
            books[index].TakenBy = id;
        }

        public void ReturnBook(Book book)
        {
            var index = books.FindIndex(book.Equals);
            if (!books[index].Taken)
                return;
            books[index].Taken = false;
        }
    }
}