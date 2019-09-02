using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ======================================
// = Author: Andrew English             =
// = Date:     2/09/2019                =
// ======================================
// = Description:                       =
// = First iteration of the DT dice     =
// =                                    =
// ======================================

namespace DraganTalamh
{
    /// <summary>
    /// Random dice generator.
    /// </summary>
    /// <remarks>
    /// Simulates the roll of a dice using a random number 
    /// generator.
    /// </remarks>
    public static class DiceHandler
    {
       

        private static Random random = new Random();

        /// <summary>
        /// Random 4 side dice generator.
        /// </summary>
        /// <remarks>
        /// Creates Dice 4 which has the values  
        /// between 1 and 4.
        /// </remarks>
        /// 
        public static int DiceFour()
        {
            
            int diceFour = random.Next(1, 5);
            return diceFour;
        }

        /// <summary>
        /// Random 6 side dice generator.
        /// </summary>
        /// <remarks>
        /// Creates Dice 6 which has the values  
        /// between 1 and 6.
        /// </remarks>
        public static int DiceSix()
        {
          
            int diceSix = random.Next(1, 7);
            return diceSix;
        }

        /// <summary>
        /// Random 8 side dice generator.
        /// </summary>
        /// <remarks>
        /// Creates Dice 8 which has the values  
        /// between 1 and 8.
        /// </remarks>
        public static int DiceEight()
        {
            
            int diceEight = random.Next(1, 9) + 1;
            return diceEight;
        }

        /// <summary>
        /// Random 10 side dice generator.
        /// </summary>
        /// <remarks>
        /// Creates Dice 10 which has the values  
        /// between 1 and 10.
        /// </remarks>
        public static int DiceTen()
        {
          
            int diceTen = random.Next(0, 11);
            return diceTen;
        }

        /// <summary>
        /// Random 100 sided dice generator.
        /// </summary>
        /// <remarks>
        /// Creates Dice 100 which has the values  
        /// between 0 and 90.
        /// </remarks>
        public static int DiceOneHundred()
        {
          
            int diceOneHundred = random.Next(0, 100) + 1;
            return diceOneHundred;
        }


        /// <summary>
        /// Random 12 sided dice generator.
        /// </summary>
        /// <remarks>
        /// Creates Dice 12 which has the values  
        /// between 1 and 13.
        /// </remarks>
        public static int DiceTwelve()
        {
            
            int diceTwelve = random.Next(1, 13);
            return diceTwelve;
        }

        /// <summary>
        /// Random 20 sided dice generator.
        /// </summary>
        /// <remarks>
        /// Creates Dice 20 which has the values  
        /// between 1 and 20.
        /// </remarks>
        public static int DiceTwenty()
        {
            int diceTwenty = random.Next(1, 21);
            return diceTwenty;
        }


    }

   

}


