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
        public List<Book> GetBooksList => books;
        
        public BooksList()
        {
            books = new List<Book>();
        }
        
    }
}