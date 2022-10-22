using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_FINAL
{
    internal static class Program
    {
        // These attributes are global so that they can be used everywhere and only have one
        // Using concepts discussed here: https://stackoverflow.com/questions/1293926/c-sharp-winforms-global-variables
        public static int goalAttempts = 0;
        public static int goalPoints = 0;
        public static int acheivedAttempts = 0;
        public static int acheivedPoints = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHome());
        }
    }
}
