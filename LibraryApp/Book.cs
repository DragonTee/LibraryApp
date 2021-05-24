using System;

namespace LibraryApp
{
    public struct Book
    {
        public string Name;
        public string Author;
        public bool Taken;
        public int TakenBy;
        public int AccessLevel;
        public DateTime ReturnDate;
    }
}