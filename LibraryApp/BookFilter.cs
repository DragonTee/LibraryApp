using System.Collections.Generic;

namespace LibraryApp
{
    public class BookFilter
    {
        private string bookName;
        private string authorName;
        private int takenBy;
        private int maxAccessLevel;
        private bool descendingOrder;

        public BookFilter(string bookName, string authorName, int takenBy, int maxAccessLevel, bool descendingOrder)
        {
            this.bookName = bookName;
            this.authorName = authorName;
            this.takenBy = takenBy;
            this.maxAccessLevel = maxAccessLevel;
            this.descendingOrder = descendingOrder;
        }

        public List<Book> FilterList(List<Book> list)
        {
            return list;
        }
    }
}