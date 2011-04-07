using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CookImplement;

namespace MabiCooker2
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
            Form RunningApp = new MabiCooker();
            if (!MabiCooker.isLoaded) Application.Exit();
            else Application.Run(RunningApp);
        }
    }
}
