// ======================================
// = Author:                            =
// = Date:                              =
// ======================================
// = Description:                       =
// =    A class that represents a       =
// =    characters class.                =
// ======================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraganTalamh.Character
{
    class CharacterClass
    {
        /// <summary>
        /// Name of character's class
        /// </summary>
        private string name { get; set; }

        /// <summary>
        /// String containing a filepath to this class' image
        /// </summary>
        private string imagePath { get; set; }

        /// <summary>
        /// Description of this class
        /// </summary>
        private string description { get; set; }

        /// <summary>
        /// A short representing the hit dice for this character
        /// </summary>
        private short hitDice { get; set; }

        /// <summary>
        /// A list of special abilities unique to this class
        /// </summary>
        private List<ClassAbilities> classAbilities { get; set; }
    }
}
