using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryApp
{
    public static class FormsManager
    {
        public static Form MainForm { get; set; }
        private static List<Form> formsStack = new List<Form>();

        public static void ChangeForm(Form newForm)
        {
            formsStack.Add(newForm);
            MainForm.Controls.Clear();
            foreach (Control control in newForm.Controls)
            {
                MainForm.Controls.Add(control);
            }
        }

        public static void GoBack()
        {
            if (formsStack.Count <= 0)
                return;
            formsStack[formsStack.Count - 1].Close();
            formsStack.RemoveAt(formsStack.Count - 1);
            Form newForm;
            if (formsStack.Count == 0)
                newForm = new LoginSelectForm(true);
            else
                newForm = formsStack[formsStack.Count - 1];
            MainForm.Controls.Clear();
            foreach (Control control in newForm.Controls)
            {
                MainForm.Controls.Add(control);
            }
        }
    }
}