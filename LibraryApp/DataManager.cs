using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LibraryApp
{
    public static class DataManager
    {
        public static String UsersFilePath { get; private set; } = "UsersData.dat";
        public static String BooksFilePath { get; private set; } = "BooksData.dat";
        public static String DepartmentsFilePath { get; private set; } = "DepartmentsData.dat";
        
        public enum UserType
        {
            Reader = 1,
            Librarian = 2,
            DepartmentHead = 3,
            HeadManager = 4
        }

        public struct DepartmentData
        {
            public int id;
            public int librariansCount;
            public List<int> librariansIds;
        }
        
        public struct UserData
        {
            public string login;
            public string name;
            public int attribute;
            public string password;
            public UserType type;
            public int id;
        }

        private static List<UserData> usersData = null;
        private static List<Book> booksData = null;
        private static List<DepartmentData> departmentsData = null;

        public static void ChangeUsersFilePath(string path)
        {
            usersData?.Clear();
            usersData = null;
            UsersFilePath = path;
        }
        
        public static List<UserData> LoadAllUsersData()
        {
            if (usersData != null)
                return usersData;
            usersData = new List<UserData>();
            if (!File.Exists(UsersFilePath))
                return usersData;
            using (Stream stream = new FileStream(UsersFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var reader = new BinaryReader(stream, Encoding.Default))
                {
                    var count = reader.ReadInt32();
                    for (var i = 0; i < count; i++)
                    {
                        var user = new UserData
                        {
                            login = reader.ReadString(),
                            name = reader.ReadString(),
                            attribute = reader.ReadInt32(),
                            password = reader.ReadString(),
                            type = (UserType) reader.ReadInt32(),
                            id = reader.ReadInt32()
                        };
                        usersData.Add(user);
                    }
                }
            }
            if (usersData.Count == 0)
                usersData.Add(new UserData()
                {
                    login = "Owner",
                    name = "HeadManager",
                    attribute = 0,
                    password = "Password",
                    type = UserType.HeadManager,
                    id = 1
                });
            return usersData;
        }

        public static void SaveUser(UserData user)
        {
            if (usersData == null)
                usersData = new List<UserData>();
            usersData.Add(user);
            SaveUsersData();
        }

        public static void DeleteUser(string userLogin)
        {
            foreach (var user in usersData)
            {
                if (user.login.Equals(userLogin))
                    usersData.Remove(user);
            }
            SaveUsersData();
        }
        
        public static void SaveUsersData()
        {
            using (Stream stream = new FileStream(UsersFilePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            {
                using (var writer = new BinaryWriter(stream, Encoding.Default))
                {
                    writer.Write(usersData.Count);
                    foreach (var user in usersData)
                    {
                        writer.Write(user.login);
                        writer.Write(user.name);
                        writer.Write(user.attribute);
                        writer.Write(user.password);
                        writer.Write((int)user.type);
                        writer.Write(user.id);
                    }
                }
            }
        }
        
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
                booksData = new List<Book>();
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
        
        public static List<DepartmentData> LoadDepartmentsData()
        {
            if (departmentsData != null)
                return departmentsData;
            departmentsData = new List<DepartmentData>();
            if (!File.Exists(DepartmentsFilePath))
                return departmentsData;
            using (Stream stream = new FileStream(DepartmentsFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var reader = new BinaryReader(stream, Encoding.Default))
                {
                    var count = reader.ReadInt32();
                    for (var i = 0; i < count; i++)
                    {
                        var department = new DepartmentData()
                        {
                            id = reader.ReadInt32(),
                            librariansCount = reader.ReadInt32(),
                            librariansIds = new List<int>()
                        };
                        for (var j = 0; j < department.librariansCount; j++)
                            department.librariansIds.Add(reader.ReadInt32());
                        departmentsData.Add(department);
                    }
                }
            }
            return departmentsData;
        }

        public static void SaveDepartment(DepartmentData department)
        {
            if (departmentsData == null)
                departmentsData = new List<DepartmentData>();
            departmentsData.Add(department);
            SaveDepartmentsData();
        }

        public static void DeleteDepartment(int id)
        {
            foreach (var department in departmentsData)
            {
                if (department.id == id)
                    departmentsData.Remove(department);
            }
            SaveDepartmentsData();
        }
        
        public static void SaveDepartmentsData()
        {
            using (Stream stream = new FileStream(DepartmentsFilePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            {
                using (var writer = new BinaryWriter(stream, Encoding.Default))
                {
                    writer.Write(departmentsData.Count);
                    foreach (var department in departmentsData)
                    {
                        writer.Write(department.id);
                        writer.Write(department.librariansCount);
                        foreach (var id in department.librariansIds)
                        {
                            writer.Write(id);
                        }
                    }
                }
            }
        }
    }
}