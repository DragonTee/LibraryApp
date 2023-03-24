using System;
using System.Collections.Generic;
using System.Linq;

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
            var users = UsersDataManager.LoadAllUsersData();
            foreach (var user in users)
            {
                if (user.type == UsersDataManager.UserType.DepartmentHead)
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
            var newDepartmentHeadId = heads.Max(head => head.Id) + 1;
            heads.Add(new DepartmentHead(name, newDepartmentHeadId, departmentId));
            UsersDataManager.SaveUser(new UsersDataManager.UserData()
            {
                name = name,
                login = name,
                attribute = departmentId,
                password = name,
                id = newDepartmentHeadId,
                type = UsersDataManager.UserType.DepartmentHead
            });
        }

        public void DeleteDepartmentHead(DepartmentHead head)
        {
            UsersDataManager.DeleteUser(head.Name);
            heads.Remove(head);            
        }

        public void SetHeadDepartmentId(int headId, int departmentId)
        {
            if (headId >= heads.Count)
                return;
            UsersDataManager.DeleteUser(heads[headId].Name);
            heads[headId].DepartmentId = departmentId;
            UsersDataManager.SaveUser(new UsersDataManager.UserData()
            {
                name = heads[headId].Name,
                login = heads[headId].Name,
                attribute = heads[headId].DepartmentId,
                password = heads[headId].Name,
                id = headId,
                type = UsersDataManager.UserType.DepartmentHead
            });
        }
        
    }
}