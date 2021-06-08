using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class LibrariansListForm : Form
    {
        List<Librarian> librariansList;
        private DepartmentHead departmentManager;
        private List<LibrariansListRow> childForms = new List<LibrariansListRow>();
        
        public LibrariansListForm(List<Librarian> librarians, DepartmentHead manager)
        {
            InitializeComponent();
            departmentManager = manager;
            librariansList = librarians;
            BackBtn.Click += (sender, args) =>
            {
                FormsManager.GoBack();
            };
            LoadRows();
        }

        public void RemoveLibrarian(Librarian librarian)
        {
            departmentManager.RemoveLibrarian(librarian.Id);
            LoadRows();
        }

        private void LoadRows()
        {
            foreach (var form in childForms)
            {
                form.Close();
            }
            TablePanel.Controls.Clear();
            childForms.Clear();
            foreach (var librarian in librariansList)
            {
                var newRow = new LibrariansListRow(librarian, this);
                childForms.Add(newRow);
                foreach (Control control in newRow.Controls)
                {
                    TablePanel.Controls.Add(control);
                }
            }
        }
    }
}