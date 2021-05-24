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
            return;
        }

        public void RemoveLibrarian(int id)
        {
            return;
        }
        
        public List<Librarian> GetLibrariansList()
        {
            return null;
        }
    }
}