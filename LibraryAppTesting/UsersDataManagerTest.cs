using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LibraryApp;
using NUnit.Framework;

namespace LibraryAppTesting
{
    public class UsersDataManagerTest
    {
        private string initialPath;
        private string testPath = "DataTest.test";

        [SetUp]
        public void SetUp()
        {
            initialPath = UsersDataManager.UsersFilePath;
            UsersDataManager.ChangeUsersFilePath(testPath);
        }
        
        [Test]
        public void Test1()
        {
            UsersDataManager.UserData data;
            data.login = "a";
            data.name = "a";
            data.password = "a";
            data.type = UsersDataManager.UserType.Reader;
            data.attribute = 0;
            data.id = 0;
            UsersDataManager.SaveUser(data);
            var users = UsersDataManager.LoadAllUsersData();
            Assert.IsTrue(users.Where(user => user.Equals(data)).Count() == 1);
        }
        
        [Test]
        public void Test2()
        {
            UsersDataManager.UserData data;
            data.login = "a";
            data.name = "a";
            data.password = "a";
            data.type = UsersDataManager.UserType.Reader;
            data.attribute = 0;
            data.id = 0;
            UsersDataManager.SaveUser(data);
            UsersDataManager.SaveUser(data);
            UsersDataManager.SaveUser(data);
            UsersDataManager.SaveUser(data);
            var users = UsersDataManager.LoadAllUsersData();
            Assert.IsTrue(users.Where(user => user.Equals(data)).Count() == 4);
        }

        [TearDown]
        public void TearDown()
        {
            File.Delete(testPath);
            UsersDataManager.ChangeUsersFilePath(initialPath);
        }
    }
}