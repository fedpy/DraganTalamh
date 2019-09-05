using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DraganTalamh.GUI;

namespace DraganTalamh.Handlers
{
    static public class ScreenHandler
    {
        /// <summary>
        /// 
        /// </summary>
        private static UserControl currentScreen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private static List<UserControl> screenHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static void Cancel()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public static void Back()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public static void ShowStartScreen()
        {
            // Add Menu Screen to the Left Panel
            MenuScreenController menuScreen = new MenuScreenController();
            MainForm.GetInstance().LeftPanel.Controls.Add(menuScreen);

            // Add Start Screen to the Right Panel
            StartScreenController startScreen = new StartScreenController();
            MainForm.GetInstance().RightPanel.Controls.Add(startScreen);

            // Update Current Screen
            currentScreen = startScreen;

            // Update Screen History
            List<UserControl> currentScrenHistory = new List<UserControl>();
            currentScrenHistory.Add(startScreen);
            screenHistory = currentScrenHistory;
        }
    }
}
