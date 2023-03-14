using System;
using System.Collections.Generic;
using LibraryApp;
using NUnit.Framework;

namespace LibraryAppTesting
{
    public class BookFilterTest
    {
        private BookFilter bookFilter;
        private List<Book> list;

        [SetUp]
        public void SetUp()
        {
            list = new List<Book>()
            {
                new Book(){Name = "BookName",  AccessLevel = 0, Author = "Author", ReturnDate = DateTime.Now, Taken = false, TakenBy = -1},
                new Book(){Name = "BookName1", AccessLevel = 0, Author = "Author", ReturnDate = DateTime.Now, Taken = false, TakenBy = -1},
                new Book(){Name = "BookName2", AccessLevel = 5, Author = "Author", ReturnDate = DateTime.Now, Taken = false, TakenBy = -1},
                new Book(){Name = "BookName3", AccessLevel = 0, Author = "Abc",    ReturnDate = DateTime.Now, Taken = false, TakenBy = -1},
                new Book(){Name = "BookName4", AccessLevel = 0, Author = "Author", ReturnDate = DateTime.Now, Taken = false, TakenBy =  4},
            };   
        }
        
        [Test]
        public void Test1()
        {
            bookFilter = new BookFilter("", "", -1, 100, false);
            var newList = bookFilter.FilterList(list);
            Assert.AreEqual(5, newList.Count);
        }
        
        [Test]
        public void Test2()
        {
            bookFilter = new BookFilter("abacaba", "", -1, 100, false);
            var newList = bookFilter.FilterList(list);
            Assert.AreEqual(0, newList.Count);
        }
        
        [Test]
        public void Test3()
        {
            bookFilter = new BookFilter("BookName1", "", -1, 100, false);
            var newList = bookFilter.FilterList(list);
            Assert.AreEqual(1, newList.Count);
        }
        
        [Test]
        public void Test4()
        {
            bookFilter = new BookFilter("1", "", -1, 100, false);
            var newList = bookFilter.FilterList(list);
            Assert.AreEqual(1, newList.Count);
        }
        
        [Test]
        public void Test5()
        {
            bookFilter = new BookFilter("", "", 4, 100, false);
            var newList = bookFilter.FilterList(list);
            Assert.AreEqual(1, newList.Count);
        }
        
        [Test]
        public void Test6()
        {
            bookFilter = new BookFilter("", "", -1, 4, false);
            var newList = bookFilter.FilterList(list);
            Assert.AreEqual(4, newList.Count);
        }
    }
}