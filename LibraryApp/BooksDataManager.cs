using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LibraryApp
{
    public static class BooksDataManager
    {
        public static string BooksFilePath { get; private set; } = "BooksData.dat";

        private static List<Book> booksData = null;

        public static List<Book> LoadAllBooksData()
        {
            if (booksData != null)
                return booksData;
            booksData = new List<Book>();
            if (!File.Exists(BooksFilePath))
                return booksData;
            using (Stream stream = new FileStream(BooksFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var reader = new BinaryReader(stream, Encoding.Default))
                {
                    var count = reader.ReadInt32();
                    for (var i = 0; i < count; i++)
                    {
                        var book = new Book()
                        {
                            Name = reader.ReadString(),
                            Author = reader.ReadString(),
                            Taken = reader.ReadBoolean(),
                            TakenBy = reader.ReadInt32(),
                            AccessLevel = reader.ReadInt32(),
                            ReturnDate = DateTime.Parse(reader.ReadString())
                        };
                        booksData.Add(book);
                    }
                }
            }
            return booksData;
        }

        public static void SaveBook(Book book)
        {
            if (booksData == null)
                LoadAllBooksData();
            booksData.Add(book);
            SaveBooksData();
        }

        public static void DeleteBook(Book book)
        {
            booksData.Remove(book);
            SaveBooksData();
        }

        public static void SaveBooksData()
        {
            using (Stream stream = new FileStream(BooksFilePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            {
                using (var writer = new BinaryWriter(stream, Encoding.Default))
                {
                    writer.Write(booksData.Count);
                    foreach (var book in booksData)
                    {
                        writer.Write(book.Name);
                        writer.Write(book.Author);
                        writer.Write(book.Taken);
                        writer.Write(book.TakenBy);
                        writer.Write(book.AccessLevel);
                        writer.Write(book.ReturnDate.ToString());
                    }
                }
            }
        }
    }
}
