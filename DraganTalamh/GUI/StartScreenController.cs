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
    public partial class StartScreenController : UserControl
    {
        public StartScreenController()
        {
            InitializeComponent();
        }

        private void OnCreateNewCharacterButtonClick(object sender, EventArgs e)
        {
            ScreenHandler.ShowRaceScreen();
        }
    }
}
