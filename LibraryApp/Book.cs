using System;

namespace LibraryApp
{
    public class Book
    {
        public string Name;
        public string Author;
        public bool Taken;
        public int TakenBy;
        public int AccessLevel;
        public DateTime ReturnDate;

        public bool Equals(Book other)
        {
            return (other.Name == Name && other.Author == Author && other.Taken == Taken && other
                .TakenBy == TakenBy && other.AccessLevel == AccessLevel);
        }
    }
}