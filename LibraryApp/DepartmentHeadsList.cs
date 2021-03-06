using System;
using System.Collections.Generic;

namespace LibraryApp
{
    public class DepartmentHeadsList
    {
        private static DepartmentHeadsList instance;

        public static DepartmentHeadsList Instance
        {
            get
            {
                if (instance == null)
                    instance = new DepartmentHeadsList();
                return instance;
            }
        }

        private List<DepartmentHead> heads;
        public List<DepartmentHead> GetDepartmentHeads => heads;

        public DepartmentHeadsList()
        {
            heads = new List<DepartmentHead>();
            var users = DataManager.LoadAllUsersData();
            foreach (var user in users)
            {
                if (user.type == DataManager.UserType.DepartmentHead)
                    heads.Add(new DepartmentHead(user.name, user.id, user.attribute));
            }
        }

        public void AddDepartmentHead(string name)
        {
            int maxId = 0;
            foreach (var head in heads)
            {
                maxId = Math.Max(maxId, head.Id);
            }
            maxId += 1;
            heads.Add(new DepartmentHead(name, maxId, 0));
        }
        
        public void AddDepartmentHead(string name, int departmentId)
        {
            int maxId = 0;
            foreach (var head in heads)
            {
                maxId = Math.Max(maxId, head.Id);
            }
            maxId += 1;
            heads.Add(new DepartmentHead(name, maxId, departmentId));
            DataManager.SaveUser(new DataManager.UserData()
            {
                name = name,
                login = name,
                attribute = departmentId,
                password = name,
                id = maxId,
                type = DataManager.UserType.DepartmentHead
            });
        }

        public void DeleteDepartmentHead(DepartmentHead head)
        {
            DataManager.DeleteUser(head.Name);
            heads.Remove(head);            
        }

        public void SetHeadDepartmentId(int headId, int departmentId)
        {
            if (headId >= heads.Count)
                return;
            DataManager.DeleteUser(heads[headId].Name);
            heads[headId].DepartmentId = departmentId;
            DataManager.SaveUser(new DataManager.UserData()
            {
                name = heads[headId].Name,
                login = heads[headId].Name,
                attribute = heads[headId].DepartmentId,
                password = heads[headId].Name,
                id = headId,
                type = DataManager.UserType.DepartmentHead
            });
        }
        
    }
}