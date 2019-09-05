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


            //Creating the user control objects
            StartScreenController startScreen = new StartScreenController();
            MenuScreenController menuScreen = new MenuScreenController();
            

            //Adding the control objects to the left and right panels
            MainForm.GetInstance().LeftPanel.Controls.Add(menuScreen);
            MainForm.GetInstance().RightPanel.Controls.Add(startScreen);
            

            // Execute the application
            Application.Run(MainForm.GetInstance());
        }
    }
}
