using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraganTalamh
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// This instance variable will point to the one and only
        /// instance of a MainForm object created.
        /// </summary>
        private static MainForm mainForm = null;

        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This method checks if there is already a MainForm object created and returns its instance.
        /// If there isn't any, then it creates it and returns it.
        /// </summary>
        /// <returns>A singleton instance of a MainForm object.</returns>
        public static MainForm GetInstance()
        {
            if (mainForm != null)
            {
                return mainForm;
            }
            else
            {
                mainForm = new MainForm();
                return mainForm;
            }
        }
    }
}
