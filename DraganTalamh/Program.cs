using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DraganTalamh.GUI;

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

            // TODO: Display the appropriate panels here
            // TODO: Left Panel and the appropriate screen
            // TODO: Right Panel and the appropriate screen
            // TODO: Bottom Panel should not be visible here

            // Execute the application
            Application.Run(MainForm.GetInstance());
        }
    }
}
