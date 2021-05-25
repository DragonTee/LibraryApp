using System;
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

        public class BookComparer : IComparer<Book>
        {
            private bool ascendingOrder;
            public BookComparer(bool ascending)
            {
                this.ascendingOrder = ascending;
            }
            
            public int Compare(Book x, Book y)
            {
                if (ascendingOrder)
                    return String.Compare(x.Name, y.Name, StringComparison.InvariantCultureIgnoreCase);
                else
                    return String.Compare(y.Name, x.Name, StringComparison.InvariantCultureIgnoreCase);
            }
        }


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
            var newList = new List<Book>();
            foreach (var book in list)
            {
                var rightBook = true;
                if (!book.Name.Contains(bookName))
                    rightBook = false;
                if (!book.Author.Contains(authorName))
                    rightBook = false;
                if (takenBy > 0 && book.TakenBy != takenBy)
                    rightBook = false;
                if (book.AccessLevel > maxAccessLevel)
                    rightBook = false;
                if (rightBook)
                    newList.Add(book);
            }
            newList.Sort(new BookComparer(!descendingOrder));
            return newList;
        }
    }
}