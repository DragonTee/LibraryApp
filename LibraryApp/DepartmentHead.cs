using System.Collections.Generic;

namespace LibraryApp
{
    public class DepartmentHead
    {
        private int departmentId;
        private int id;
        private string name;

        public int Id => id;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int DepartmentId
        {
            get => departmentId;
            set => departmentId = value;
        }

        public DepartmentHead(string name, int id, int departmentId)
        {
            this.name = name;
            this.id = id;
            this.departmentId = departmentId;
        }
        
        public void AddLibrarian(string name)
        {
            foreach (var department in DepartmentList.Instance.GetDepartmentsList)
            {
                if (department.Id == departmentId)
                {
                    department.AddLibrarian(name);
                    break;
                }
            }
        }

        public void RemoveLibrarian(int id)
        {
            foreach (var department in DepartmentList.Instance.GetDepartmentsList)
            {
                if (department.Id == departmentId)
                {
                    department.RemoveLibrarian(id);
                    break;
                }
            }
        }
        
        public List<Librarian> GetLibrariansList()
        {
            foreach (var department in DepartmentList.Instance.GetDepartmentsList)
            {
                if (department.Id == departmentId)
                {
                    return department.GetLibrarians();
                }
            }
            return new List<Librarian>();
        }
    }
}