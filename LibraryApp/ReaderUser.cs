﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace LibraryApp
{
    public class ReaderUser
    {
        private int accessLevel;
        private string name;
        private readonly int id;

        public ReaderUser(int accessLevel, string name)
        {
            this.accessLevel = accessLevel;
            this.name = name;
        }

        public ReaderUser(ReaderUser other, int id)
        {
            this.accessLevel = other.accessLevel;
            this.Name = other.name;
            this.id = id;
        }

        public List<Book> GetBooksList()
        {
            return null;
        }
        
        public List<Book> GetBooksListFiltered(BookFilter filter)
        {
            return null;
        }

        public List<Book> GetTakenBooksList()
        {
            return null;
        }
        
        
        public int AccessLevel
        {
            get => accessLevel;
            set => accessLevel = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Id => id;
    }
}