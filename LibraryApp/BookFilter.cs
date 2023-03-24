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

        private bool CheckBook(Book book) =>
            book.Name.Contains(bookName) &&
            book.Author.Contains(authorName) &&
            (takenBy <= 0 || book.TakenBy == takenBy) &&
            (book.AccessLevel <= maxAccessLevel);

        public List<Book> FilterList(List<Book> list)
        {
            var newList = new List<Book>();
            foreach (var book in list)
            {
                if (CheckBook(book))
                    newList.Add(book);
            }
            newList.Sort(new BookComparer(!descendingOrder));
            return newList;
        }
    }
}