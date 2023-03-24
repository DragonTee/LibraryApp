using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryApp
{
    public static class FormsManager
    {
        public static Form MainForm { get; set; }
        private static readonly List<Form> formsStack = new List<Form>();

        public static void ChangeForm(Form newForm)
        {
            formsStack.Add(newForm);
            newForm.Show();
            newForm.Location = MainForm.Location;
            newForm.Size = MainForm.Size;
            MainForm.Hide();
            if (formsStack.Count > 1)
            {
                formsStack[formsStack.Count - 2].Hide();
                newForm.Location = formsStack[formsStack.Count - 2].Location;
                newForm.Size = formsStack[formsStack.Count - 2].Size;
            }

            /*MainForm.Controls.Clear();
            foreach (Control control in newForm.Controls)
            {
                MainForm.Controls.Add(control);
            }*/
        }

        public static void GoBack()
        {
            if (formsStack.Count <= 0)
                return;
            var oldLocation = formsStack[formsStack.Count - 1].Location;
            var oldSize = formsStack[formsStack.Count - 1].Size;
            formsStack[formsStack.Count - 1].Close();
            formsStack.RemoveAt(formsStack.Count - 1);
            Form newForm;
            if (formsStack.Count == 0)
            {
                newForm = MainForm;
            }
            else
                newForm = formsStack[formsStack.Count - 1];
            newForm.Show();
            newForm.Location = oldLocation;
            newForm.Size = oldSize;
        }
    }
}