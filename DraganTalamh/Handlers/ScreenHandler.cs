// ======================================
// = Author:                            =
// = Date:                              =
// ======================================
// = Description:                       =
// =    A static class with methods     =
// =    for navigation.                 =
// ======================================

using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DraganTalamh.GUI;

namespace DraganTalamh.Handlers
{
    static public class ScreenHandler
    {
        /// <summary>
        /// This property will reference the current screen user control loaded
        /// in the RightPanel of the Main form.
        /// </summary>
        private static UserControl currentScreen { get; set; }

        /// <summary>
        /// screenHistory will hold a list of the visited user control screens. 
        /// </summary>
        private static List<UserControl> screenHistory { get; set; }

        /// <summary>
        /// If user hits Cancel button, the start up screen is going to be loaded.
        /// ScreenHandler properties will be reset.
        /// </summary>
        public static void Cancel()
        {          
            MainForm.GetInstance().RightPanel.Controls.Remove(currentScreen);
            ShowStartScreen();
        }

        /// <summary>
        /// This method will load the previous user control screen in the RightPanel if any.
        /// </summary>
        public static void Back()
        {
            int previousScreenIndex = screenHistory.IndexOf(currentScreen)-1;

            if (previousScreenIndex > 0)
            {
                MainForm.GetInstance().RightPanel.Controls.Remove(currentScreen);
                MainForm.GetInstance().RightPanel.Controls.Add(screenHistory.ElementAt(previousScreenIndex));

                currentScreen = screenHistory.ElementAt(previousScreenIndex);                
            }
            else if (previousScreenIndex == 0)
            {
                Cancel();
            }
            
        }

        /// <summary>
        /// The method adds Menu, Start and Bottom screens to their relevant containers
        /// and assigns the property fields.
        /// </summary>
        public static void ShowStartScreen()
        {
            MenuScreenController menuScreen = new MenuScreenController();
            MainForm.GetInstance().LeftPanel.Controls.Add(menuScreen);

            StartScreenController startScreen = new StartScreenController();
            MainForm.GetInstance().RightPanel.Controls.Add(startScreen);

            if (MainForm.GetInstance().BottomPanel.HasChildren)
            {
                MainForm.GetInstance().BottomPanel.Controls.RemoveAt(0);
            }
            
            currentScreen = startScreen;

            List<UserControl> currentScrenHistory = new List<UserControl>();
            currentScrenHistory.Add(startScreen);
            screenHistory = currentScrenHistory;
        }

        /// <summary>
        /// This method displays the Pagination screen control in the BottomPanel.
        /// Creates a new RaceScreenController and updates the properties currentScreen
        /// and screenHistory with their new values. 
        /// </summary>
        public static void ShowRaceScreen()
        {
            if (!MainForm.GetInstance().BottomPanel.HasChildren)
            {
                PaginationScreenController paginationScreen = new PaginationScreenController();
                MainForm.GetInstance().BottomPanel.Controls.Add(paginationScreen);
            }
            
            RaceScreenController raceScreen = new RaceScreenController();

            if (!currentScreen.GetType().Equals(raceScreen.GetType()))
            {
                MainForm.GetInstance().RightPanel.Controls.Remove(currentScreen);
                MainForm.GetInstance().RightPanel.Controls.Add(raceScreen);

                screenHistory.Add(raceScreen);

                currentScreen = raceScreen;
            }
        }
    }
}
