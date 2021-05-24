using System.Collections.Generic;

namespace LibraryApp
{
    public class HeadManager
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public void CreateNewDepartment()
        {
            return;
        }

        public void DeleteDepartment(int id)
        {
            return;
        }

        public void DeleteDepartmentHead(int id)
        {
            return;
        }

        public List<DepartmentHead> GetDepartmentHeads()
        {
            return null;
        }

        public List<Department> GetDepartmentsList()
        {
            return null;
        }

        public void AddDepartmentHead(string name)
        {
            return;
        }

        public void SetHeadDepartment(int headId, int departmentId)
        {
            return;
        }
    }
}