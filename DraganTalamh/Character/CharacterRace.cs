// ======================================
// = Author:                            =
// = Date:                              =
// ======================================
// = Description:                       =
// =    A class that represents a       =
// =    characters race.                =
// ======================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraganTalamh.Character
{
    class CharacterRace
    {
        /// <summary>
        /// Name of this race
        /// </summary>
        private string name { get; set; }

        /// <summary>
        /// The filepath to image for this race
        /// </summary>
        private string imagePath { get; set; }

        /// <summary>
        /// Description of this race
        /// </summary>
        private string description { get; set; }

        /// <summary>
        /// A list of abilities for this race
        /// </summary>
        private List<string> racialAbilities { get; set; }

        /// <summary>
        /// A list of traits for this race
        /// </summary>
        private List<short> racialTraits { get; set; }
    }
}
