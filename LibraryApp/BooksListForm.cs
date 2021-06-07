using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class BooksListForm : Form
    {
        private List<BooksListRow> childForms;
        public BooksListForm(List<Book> books)
        {
            InitializeComponent();
            foreach (var book in books)
            {
                var newRow = new BooksListRow(book);
                childForms.Add(newRow);
                
                Control mainPanel = null;
                foreach (Control control in Controls)
                {
                    if (control.Name.Equals("TablePanel"))
                    {
                        mainPanel = control;
                        break;
                    }
                }
                if (mainPanel == null) return;
                
                foreach (Control control in newRow.Controls)
                {
                    mainPanel.Controls.Add(control);    
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            foreach (var form in childForms)
            {
                form.Close();
            }
        }
    }
}