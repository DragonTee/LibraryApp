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
            var departmentData = DataManager.LoadDepartmentsData();
            foreach (var department in departmentData)
            {
                var newDepartment = new Department(department.id);
                foreach (var id in department.librariansIds)
                {
                    newDepartment.AddLibrarian(id.ToString());
                }
                departments.Add(newDepartment);
            }
        }

        public void DeleteDepartment(int id)
        {
            departments.Remove(departments[id]);
            DataManager.DeleteDepartment(id);
        }

        public int AddDepartment()
        {
            var id = departments.Count;
            var newDepartment = new Department(id);
            departments.Add(newDepartment);
            DataManager.SaveDepartment(new DataManager.DepartmentData()
            {
                id = id,
                librariansCount = 0,
                librariansIds = new List<int>()
            });
            return id;
        }
    }
}