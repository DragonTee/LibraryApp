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
            heads.Add(new DepartmentHead(name, heads.Count, 0));
        }
        
        public void AddDepartmentHead(string name, int departmentId)
        {
            heads.Add(new DepartmentHead(name, heads.Count, departmentId));
            DataManager.SaveUser(new DataManager.UserData()
            {
                name = name,
                login = name,
                attribute = departmentId,
                password = name,
                id = heads.Count - 1,
                type = DataManager.UserType.DepartmentHead
            });
        }

        public void DeleteDepartmentHead(int id)
        {
            if (id >= heads.Count)
                return;
            DataManager.DeleteUser(heads[id].Name);
            heads.Remove(heads[id]);            
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