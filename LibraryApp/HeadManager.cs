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

        public int CreateNewDepartment()
        {
            return DepartmentList.Instance.CreateNewDepartment();
        }

        public void DeleteDepartment(Department department)
        {
            DepartmentList.Instance.DeleteDepartment(department);
        }

        public void DeleteDepartmentHead(DepartmentHead head)
        {
            DepartmentHeadsList.Instance.DeleteDepartmentHead(head);
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
        
        public void AddDepartmentHead(string name, int departmentId)
        {
            DepartmentHeadsList.Instance.AddDepartmentHead(name, departmentId);
        }

        public void SetHeadDepartment(int headId, int departmentId)
        {
            DepartmentHeadsList.Instance.SetHeadDepartmentId(headId, departmentId);
        }
    }
}