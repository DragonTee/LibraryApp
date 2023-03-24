using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LibraryApp
{
    public static class DepartmentDataManager
    {
        public static string DepartmentsFilePath { get; private set; } = "DepartmentsData.dat";
        public struct DepartmentData
        {
            public int id;
            public int librariansCount;
            public List<int> librariansIds;
        }

        private static List<DepartmentData> departmentsData = null;

        public static List<DepartmentData> LoadDepartmentsData()
        {
            if (departmentsData != null)
                return departmentsData;
            departmentsData = new List<DepartmentData>();
            if (!File.Exists(DepartmentsFilePath))
                return departmentsData;
            using (Stream stream = new FileStream(DepartmentsFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var reader = new BinaryReader(stream, Encoding.Default))
                {
                    var count = reader.ReadInt32();
                    for (var i = 0; i < count; i++)
                    {
                        var department = new DepartmentData()
                        {
                            id = reader.ReadInt32(),
                            librariansCount = reader.ReadInt32(),
                            librariansIds = new List<int>()
                        };
                        for (var j = 0; j < department.librariansCount; j++)
                            department.librariansIds.Add(reader.ReadInt32());
                        departmentsData.Add(department);
                    }
                }
            }
            return departmentsData;
        }

        public static void AddLibrarianToDepartment(int departmentId, int librarianId)
        {
            if (departmentsData == null)
                departmentsData = new List<DepartmentData>();
            foreach (var data in departmentsData)
            {
                if (data.id == departmentId)
                {
                    var newData = data;
                    newData.librariansCount += 1;
                    newData.librariansIds.Add(librarianId);
                    departmentsData.Remove(data);
                    departmentsData.Add(newData);
                    break;
                }
            }
            SaveDepartmentsDataToFile();
        }

        public static void RemoveLibrarianFromDepartment(int departmentId, int librarianId)
        {
            if (departmentsData == null)
                LoadDepartmentsData();
            foreach (var data in departmentsData)
            {
                if (data.id == departmentId)
                {
                    var newData = data;
                    newData.librariansCount -= 1;
                    newData.librariansIds.Remove(librarianId);
                    departmentsData.Remove(data);
                    departmentsData.Add(newData);
                    break;
                }
            }
            SaveDepartmentsDataToFile();
        }

        public static void SaveDepartment(DepartmentData department)
        {
            if (departmentsData == null)
                departmentsData = new List<DepartmentData>();
            departmentsData.Add(department);
            SaveDepartmentsDataToFile();
        }

        public static void DeleteDepartment(int id)
        {
            foreach (var department in departmentsData)
            {
                if (department.id == id)
                {
                    departmentsData.Remove(department);
                    break;
                }
            }
            SaveDepartmentsDataToFile();
        }

        public static void SaveDepartmentsDataToFile(string filePath = null)
        {
            var path = filePath ?? DepartmentsFilePath;

            using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            {
                using (var writer = new BinaryWriter(stream, Encoding.Default))
                {
                    writer.Write(departmentsData.Count);
                    foreach (var department in departmentsData)
                    {
                        writer.Write(department.id);
                        writer.Write(department.librariansCount);
                        foreach (var id in department.librariansIds)
                        {
                            writer.Write(id);
                        }
                    }
                }
            }
        }
    }
}
