using System.Collections.Generic;
using System.Linq;

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

        private List<Department> ConvertDepartmentsData(List<DataManager.DepartmentData> departmentsData) =>
            departmentsData.Select(departmentData =>
            {
                var newDepartment = new Department(departmentData.id);
                departmentData.librariansIds.ForEach(librarianId => newDepartment.AddLibrarian(librarianId));
                return newDepartment;
            }).ToList();
        
        public DepartmentList()
        {
            var departmentsData = DataManager.LoadDepartmentsData();
            departments = ConvertDepartmentsData(departmentsData);
        }

        public void DeleteDepartment(Department department)
        {
            foreach (var librarian in department.GetLibrarians())
            {
                DataManager.DeleteUser(librarian.Name);
            }
            departments.Remove(department);
            DataManager.DeleteDepartment(department.Id);
        }

        public int AddDepartment()
        {
            var id = departments.Max(department => department.Id) + 1;
            var newDepartment = new Department(id);
            departments.Add(newDepartment);
            var newDepartmentData = new DataManager.DepartmentData()
            {
                id = id,
                librariansCount = 0,
                librariansIds = new List<int>()
            };
            DataManager.SaveDepartment(newDepartmentData);
            return id;
        }
    }
}