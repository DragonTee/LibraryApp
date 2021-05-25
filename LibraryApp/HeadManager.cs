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
            DepartmentList.Instance.AddDepartment();
        }

        public void DeleteDepartment(int id)
        {
            DepartmentList.Instance.DeleteDepartment(id);
        }

        public void DeleteDepartmentHead(int id)
        {
            DepartmentHeadsList.Instance.DeleteDepartmentHead(id);
        }

        public List<DepartmentHead> GetDepartmentHeads()
        {
            return DepartmentHeadsList.Instance.GetDepartmentHeads;
        }

        public List<Department> GetDepartmentsList()
        {
            return DepartmentList.Instance.GetDepartmentsList;
        }

        public void AddDepartmentHead(string name)
        {
            DepartmentHeadsList.Instance.AddDepartmentHead(name);
        }

        public void SetHeadDepartment(int headId, int departmentId)
        {
            DepartmentHeadsList.Instance.SetHeadDepartmentId(headId, departmentId);
        }
    }
}