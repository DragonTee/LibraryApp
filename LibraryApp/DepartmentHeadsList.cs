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
            return;
        }

        public void DeleteDepartmentHead(int id)
        {
            return;
        }

        public void SetHeadDepartmentId(int departmentId)
        {
            return;
        }
        
    }
}