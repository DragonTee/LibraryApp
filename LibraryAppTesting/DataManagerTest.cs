using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LibraryApp;
using NUnit.Framework;

namespace LibraryAppTesting
{
    public class DataManagerTest
    {
        private string initialPath;
        private string testPath = "DataTest.test";

        [SetUp]
        public void SetUp()
        {
            initialPath = DataManager.UsersFilePath;
            DataManager.ChangeUsersFilePath(testPath);
        }
        
        [Test]
        public void Test1()
        {
            DataManager.UserData data;
            data.login = "a";
            data.name = "a";
            data.password = "a";
            data.type = DataManager.UserType.Reader;
            data.attribute = 0;
            data.id = 0;
            DataManager.SaveUser(data);
            var users = DataManager.LoadAllUsersData();
            Assert.IsTrue(users.Where(user => user.Equals(data)).Count() == 1);
        }
        
        [Test]
        public void Test2()
        {
            DataManager.UserData data;
            data.login = "a";
            data.name = "a";
            data.password = "a";
            data.type = DataManager.UserType.Reader;
            data.attribute = 0;
            data.id = 0;
            DataManager.SaveUser(data);
            DataManager.SaveUser(data);
            DataManager.SaveUser(data);
            DataManager.SaveUser(data);
            var users = DataManager.LoadAllUsersData();
            Assert.IsTrue(users.Where(user => user.Equals(data)).Count() == 4);
        }

        [TearDown]
        public void TearDown()
        {
            File.Delete(testPath);
            DataManager.ChangeUsersFilePath(initialPath);
        }
    }
}