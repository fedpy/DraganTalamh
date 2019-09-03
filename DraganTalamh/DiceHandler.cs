using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ======================================
// = Author: Andrew English             =
// = Date:     3/09/2019                =
// ======================================
// = Description:                       =
// = Second iteration of the DT dice    =
// = Includes ability to roll same dice =
// = twice                              =
// ======================================

namespace DraganTalamh.Extras
{
    /// <summary>
    /// Random dice generator
    /// </summary>
    /// <remarks>
    /// Simulates the roll of a dice using a random number generator.
    /// Enables the ability to roll the same dice a number of times
    /// and get the  sum.
    /// </remarks>
    public static class DiceHandler
    {
        /// <summary>
        /// Instantiate the Random object
        /// </summary>
        private static Random randomNumber = new Random();

        /// <summary>
        /// Random 4 side dice generator
        /// </summary>
        /// <returns>
        /// An integer number between 1 and 4
        /// </returns>
        /// <remarks>
        /// Creates Dice 4 which has the values between 1 and 4
        /// Enables the ability to roll the same dice a number of times
        /// and get the sum.
        /// </remarks>
        public static int DiceFour(int numberOfDiceRolls)
        {

            int result = 0;
            for (int i = 0; i < numberOfDiceRolls; i++)
            {

                result += randomNumber.Next(1, 5);
              
            }
            return result;
        }

        /// <summary>
        /// Random 6 side dice generator
        /// </summary>
        /// <returns>
        /// An integer number between 1 and 6
        /// </returns>
        /// <remarks>
        /// Creates Dice 6 which has the values between 1 and 6
        /// Enables the ability to roll the same dice a number of times
        /// and get the sum.
        /// </remarks>
        public static int DiceSix(int numberOfDiceRolls)
        {
            int result = 0;
            for (int i = 0; i < numberOfDiceRolls; i++)
            {
                result += randomNumber.Next(1, 7);
            }
            return result;
        }

        /// <summary>
        /// Random 8 side dice generator
        /// </summary>
        /// <returns>
        /// An integer number between 1 and 8
        /// </returns>
        /// <remarks>
        /// Creates Dice 8 which has the values between 1 and 8
        /// Enables the ability to roll the same dice a number of times
        /// and get the sum.
        /// </remarks>
        public static int DiceEight(int numberOfDiceRolls)
        {
            int result = 0;
            for (int i = 0; i < numberOfDiceRolls; i++)
            {
                result += randomNumber.Next(1, 9);
            }
            return result;
        }

        /// <summary>
        /// Random 10 side dice generator
        /// </summary>
        /// <returns>
        /// An integer number between 1 and 10
        /// </returns>
        /// <remarks>
        /// Creates Dice 10 which has the values between 1 and 10
        /// Enables the ability to roll the same dice a number of times
        /// and get the sum.
        /// </remarks>
        public static int DiceTen(int numberOfDiceRolls )
        {
            int result = 0;
            for (int i = 0; i < numberOfDiceRolls; i++)
            {
                result += randomNumber.Next(0, 11);
            }
            return result;
        }

        /// <summary>
        /// Random 100 sided dice generator
        /// </summary>
        /// <returns>
        /// An integer number between 0 and 100
        /// </returns>
        /// <remarks>
        /// Creates Dice 100 which has the values between 0 and 100
        /// Enables the ability to roll the same dice a number of times
        /// and get the sum.
        /// </remarks>
        public static int DiceOneHundred(int numberOfDiceRolls)
        {
            int result = 0;
            for (int i = 0; i < numberOfDiceRolls; i++)
            {
                result += randomNumber.Next(0, 101);
            }
            return result;
        }

        /// <summary>
        /// Random 12 sided dice generator
        /// </summary>
        /// <returns>
        /// An integer number between 1 and 12
        /// </returns>
        /// <remarks>
        /// Creates Dice 12 which has the values between 1 and 12
        /// Enables the ability to roll the same dice a number of times
        /// and get the sum.
        /// </remarks>
        public static int DiceTwelve(int numberOfDiceRolls)
        {
            int result = 0;
            for (int i = 0; i < numberOfDiceRolls; i++)
            {
                result += randomNumber.Next(1, 13);
            }
            return result;
        }

        /// <summary>
        /// Random 20 sided dice generator
        /// </summary>
        /// <returns>
        /// An integer number between 1 and 20
        /// </returns>
        /// <remarks>
        /// Creates Dice 20 which has the values between 1 and 20
        /// Enables the ability to roll the same dice a number of times
        /// and get the sum.
        /// </remarks>
        public static int DiceTwenty(int numberOfRolls)
        {
            int result = 0;
            for (int i = 0; i < numberOfRolls; i++)
            {
                result += randomNumber.Next(1, 21);
            }
            return result;
        }

  
    }
}
