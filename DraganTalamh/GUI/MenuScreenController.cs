using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DraganTalamh.Handlers;

namespace DraganTalamh.GUI
{
    public partial class MenuScreenController : UserControl
    {
        public MenuScreenController()
        {
            InitializeComponent();
        }

        private void OnMainScreenButtonClick(object sender, EventArgs e)
        {
            MainForm.GetInstance().RightPanel.Controls.RemoveAt(0); //The RightPanel will always have one UserControl in its list of controls
            ScreenHandler.ShowStartScreen();
        }

        private void OnRaceScreenButtonClick(object sender, EventArgs e)
        {
            ScreenHandler.ShowRaceScreen();
        }
    }
}
