using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DraganTalamh.Handlers;

namespace DraganTalamh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles for the application
            Application.EnableVisualStyles();

            // Set the default rendering engine
            Application.SetCompatibleTextRenderingDefault(false);

            // Load the Start Screen and Menu Screen
            ScreenHandler.ShowStartScreen();

            // Execute the application
            Application.Run(MainForm.GetInstance());
        }
    }
}
