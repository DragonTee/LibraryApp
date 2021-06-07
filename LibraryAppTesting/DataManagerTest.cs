using System;
using System.Collections.Generic;
using System.IO;
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
            initialPath = DataManager.FilePath;
            DataManager.ChangeFilePath(testPath);
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
            DataManager.SaveUsersData();
            var users = DataManager.LoadAllUsersData();
            if (users.Count == 1)
            {
                if (users[0].Equals(data))
                {
                    Assert.Pass();
                    return;
                }
            }
            Assert.Fail();
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
            DataManager.SaveUsersData();
            var users = DataManager.LoadAllUsersData();
            if (users.Count == 4)
            {
                if (users[0].Equals(data) && users[1].Equals(data) && users[2].Equals(data) && users[3].Equals(data))
                {
                    Assert.Pass();
                    return;
                }
            }
            Assert.Fail();
        }

        [TearDown]
        public void TearDown()
        {
            File.Delete(testPath);
            DataManager.ChangeFilePath(initialPath);
        }
    }
}