using System.Collections.Generic;
using System.Security.Principal;

namespace LibraryApp
{
    public class DepartmentList
    {
        private static DepartmentList instance;

        public static DepartmentList Instance
        {
            get
            {
                if (instance == null)
                    instance = new DepartmentList();
                return instance;
            }
        }

        private List<Department> departments;
        public List<Department> GetDepartmentsList => departments;
        
        public DepartmentList()
        {
            departments = new List<Department>();
        }

        public void DeleteDepartment(int id)
        {
            departments.Remove(departments[id]);
        }

        public int AddDepartment()
        {
            var id = departments.Count;
            departments.Add(new Department(id));
            return id;
        }
    }
}