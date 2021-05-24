using System.Collections.Generic;
using System.Reflection;

namespace LibraryApp
{
    public class ReaderUser
    {
        private int accessLevel;

        public List<Book> GetBooksList()
        {
            return null;
        }
        
        public List<Book> GetBooksListFiltered(BookFilter filter)
        {
            return null;
        }

        public List<Book> GetTakeBooksList()
        {
            return null;
        }
        
        
        public int AccessLevel
        {
            get => accessLevel;
            set => accessLevel = value;
        }
    }
}