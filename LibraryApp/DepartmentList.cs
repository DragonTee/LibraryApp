using System.Collections.Generic;

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
            return;
        }

        public void AddDepartment()
        {
            return;
        }
    }
}