using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            for (int i = 0; i < 101 ; i++)
            {
                Console.WriteLine(DiceHandler.DiceTwenty());
            }
           
        }
    }
}
