using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrulyMail
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MessageBox.Show("This is not an application.");
            //Application.Run(new EditorForm());
        }
    }
}