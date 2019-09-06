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
            //If user hits Cancel button, the start up screen is going to be loaded
            //ScreenHandler properties will be reset
            MainForm.GetInstance().RightPanel.Controls.Remove(currentScreen);
            ShowStartScreen();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Back()
        {
           //Getting the previous screen's index from the list of screens
            int previousScreenIndex = screenHistory.IndexOf(currentScreen)-1;

            //Checking if the index is not out of range
            if (previousScreenIndex>=0){

                //Setting the RightPanel to display the previous screen
                MainForm.GetInstance().RightPanel.Controls.Remove(currentScreen);
                MainForm.GetInstance().RightPanel.Controls.Add(screenHistory.ElementAt(previousScreenIndex));

                //setting the currentScreen property to the previously viewed screen
                currentScreen = screenHistory.ElementAt(previousScreenIndex);
            }
            
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

            //Removes the Bottom Screen 
            if (MainForm.GetInstance().BottomPanel.HasChildren)
            {
                MainForm.GetInstance().BottomPanel.Controls.RemoveAt(0);
            }
            
            // Update Current Screen
            currentScreen = startScreen;

            // Update Screen History
            List<UserControl> currentScrenHistory = new List<UserControl>();
            currentScrenHistory.Add(startScreen);
            screenHistory = currentScrenHistory;
        }

        public static void ShowRaceScreen()
        {
            //Displaying the BottomPanel
            PaginationScreenController paginationScreen = new PaginationScreenController();
            MainForm.GetInstance().BottomPanel.Controls.Add(paginationScreen);

            //Creating new RaceScreenCotroller object - a new screen for selecting a race
            RaceScreenController raceScreen = new RaceScreenController();

            //Removing the current screen from the main form's RightPanel and inserting the raceScreen on its place
            MainForm.GetInstance().RightPanel.Controls.Remove(currentScreen);
            MainForm.GetInstance().RightPanel.Controls.Add(raceScreen);

            //Setting the currentScreen to point to the raceScreen and add raceScreen to the screenHistory list
            currentScreen = raceScreen;
            screenHistory.Add(raceScreen);

           
        }
    }
}
