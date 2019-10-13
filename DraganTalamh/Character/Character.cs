// ======================================
// = Author:                            =
// = Date:                              =
// ======================================
// = Description:                       =
// =    A class to represent a          =
// =    charcater.                       =
// ======================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraganTalamh.Character
{
    class Character
    {
        /// <summary>
        /// The character's name
        /// </summary>
        private string name { get; set; }

        /// <summary>
        /// A short representing the characters current level
        /// </summary>
        private short level { get; set; }

        /// <summary>
        /// Integer representing the characters current health 
        /// </summary>
        private int health { get; set; }

        /// <summary>
        /// An array of shorts represting the characters different ability points
        /// </summary>
        private short[] abilityPoints { get; set; }

        /// <summary>
        /// The characters race
        /// </summary>
        private CharacterRace characterRace { get; set; }

        /// <summary>
        /// This class this character belongs to
        /// </summary>
        private CharacterClass characterClass { get; set; }
    }
}
