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
        }

        public void AddDepartmentHead(string name)
        {
            heads.Add(new DepartmentHead(name, heads.Count, 0));
        }

        public void DeleteDepartmentHead(int id)
        {
            if (id >= heads.Count)
                return;
            heads.Remove(heads[id]);
        }

        public void SetHeadDepartmentId(int headId, int departmentId)
        {
            if (headId >= heads.Count)
                return;
            heads[headId].DepartmentId = departmentId;
        }
        
    }
}