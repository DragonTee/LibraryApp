using System.Collections.Generic;
using System.Linq;

namespace LibraryApp
{
    public static class DepartmentListExtensions
    {
        public static List<Department> ConvertToDepartmentsLists(this List<DepartmentDataManager.DepartmentData> departmentsData) =>
            departmentsData.Select(departmentData =>
            {
                var newDepartment = new Department(departmentData.id);
                departmentData.librariansIds.ForEach(librarianId => newDepartment.AddLibrarian(librarianId));
                return newDepartment;
            }).ToList();
    }
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

        private readonly List<Department> departments;
        public List<Department> GetDepartmentsList => departments;

        public DepartmentList()
        {
            var departmentsData = DepartmentDataManager.LoadDepartmentsData();
            departments = departmentsData.ConvertToDepartmentsLists();
        }

        public void DeleteDepartment(Department department)
        {
            foreach (var librarian in department.GetLibrarians())
            {
                UsersDataManager.DeleteLibrarian(librarian);
            }
            departments.Remove(department);
            DepartmentDataManager.DeleteDepartment(department.Id);
        }

        public int CreateNewDepartment()
        {
            var id = departments.Max(department => department.Id) + 1;
            var newDepartment = new Department(id);
            departments.Add(newDepartment);
            var newDepartmentData = new DepartmentDataManager.DepartmentData()
            {
                id = id,
                librariansCount = 0,
                librariansIds = new List<int>()
            };
            DepartmentDataManager.SaveDepartment(newDepartmentData);
            return id;
        }
    }
}