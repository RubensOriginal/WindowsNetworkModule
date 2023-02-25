using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsInterface
{
    static class Program
    {
        public static MenuTrayForm menuTrayForm { get; private set; }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form form = new IconTrayForm();
            form.Hide();

            menuTrayForm = new MenuTrayForm();
            menuTrayForm.Hide();
            
            Application.Run();
        }
    }
}