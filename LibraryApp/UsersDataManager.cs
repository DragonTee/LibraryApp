using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LibraryApp
{
    public static class UsersDataManager
    {
        public static string UsersFilePath { get; private set; } = "UsersData.dat";

        public enum UserType
        {
            Reader = 1,
            Librarian = 2,
            DepartmentHead = 3,
            HeadManager = 4
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

        public static void ChangeUsersFilePath(string path)
        {
            usersData?.Clear();
            usersData = null;
            UsersFilePath = path;
        }

        private static UserData CreateDefaultOwnerUser()
        {
            return new UserData()
            {
                login = "Owner",
                name = "HeadManager",
                attribute = 0,
                password = "Password",
                type = UserType.HeadManager,
                id = 1
            };
        }

        public static List<UserData> LoadAllUsersData()
        {
            if (usersData != null)
                return usersData;
            usersData = new List<UserData>();
            if (!File.Exists(UsersFilePath))
            {
                return new List<UserData>()
                {
                    CreateDefaultOwnerUser(),
                };
            }
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

            return usersData;
        }

        public static void SaveUser(UserData user)
        {
            if (usersData == null)
            {
                usersData = LoadAllUsersData();
            }
            if (usersData.Count == 0)
            {
                usersData.Add(CreateDefaultOwnerUser());
            }
            usersData.Add(user);
            SaveUsersDataToFile();
        }

        public static void DeleteDepartmentHead(DepartmentHead departmentHead)
        {
            DeleteUser(departmentHead.Name);
        }

        public static void DeleteLibrarian(Librarian librarian)
        {
            DeleteUser(librarian.Name);
        }

        public static void DeleteReader(ReaderUser readerUser)
        {
            DeleteUser(readerUser.Name);
        }

        private static void DeleteUser(string userLogin)
        {
            foreach (var user in usersData)
            {
                if (user.login.Equals(userLogin))
                {
                    usersData.Remove(user);
                    break;
                }
            }
            SaveUsersDataToFile();
        }

        private static void SaveUsersDataToFile(string filePath = null)
        {
            var path = filePath ?? UsersFilePath;

            using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
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
    }
}