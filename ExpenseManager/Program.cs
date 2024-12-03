using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (FirstInstance)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            }
            else
            {
                MessageBox.Show("La aplicación ya se está ejecutando");
                Application.Exit();
            }

        }
        private static bool FirstInstance
        {
            get
            {
                // Verifying if an instance of the app already exists
                System.Threading.Mutex mutex;
                string mutex_name = "Main";
                bool new_instance;
                mutex = new System.Threading.Mutex(true, mutex_name, out new_instance);
                return new_instance;
            }
        }
    }
}
