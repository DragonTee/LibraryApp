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

        private readonly List<Book> books;

        public BooksList()
        {
            books = new List<Book>();
            var booksData = BooksDataManager.LoadAllBooksData();
            foreach (var book in booksData)
            {
                books.Add(book);
            }
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
            BooksDataManager.SaveBook(book);
        }
        
        public void RemoveBook(Book book)
        {
            books.Remove(book);
            BooksDataManager.DeleteBook(book);
        }

        public void SetAsTaken(Book book, int id)
        {
            BooksDataManager.DeleteBook(book);
            books.Remove(book);
            book.Taken = true;
            book.TakenBy = id;
            books.Add(book);
            BooksDataManager.SaveBook(book);
        }

        public void ReturnBook(Book book)
        {
            BooksDataManager.DeleteBook(book);
            books.Remove(book);
            book.Taken = false;
            book.TakenBy = -1;
            books.Add(book);
            BooksDataManager.SaveBook(book);
        }
    }
}