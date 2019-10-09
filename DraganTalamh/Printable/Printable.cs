// ======================================
// = Author:                            =
// = Date:                              =
// ======================================
// = Description:                       =
// =    A class that stores and         =
// =    retrieves files used by the     =
// =    application.                    =
// ======================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraganTalamh.Printable
{
    public abstract class Printable
    {
        /// <summary>
        /// This is the path of the directory where saved character sheets get stored
        /// </summary>
        private string path { get; set; }

        /// <summary>
        /// Opens a previously saved charcter sheet
        /// </summary>
        public void open()
        {

        }

        /// <summary>
        /// Opens the native print dialog to allow the user to make paper copies
        /// </summary>
        public void print()
        {

        }

        /// <summary>
        /// Saves the file to the users machine
        /// </summary>
        public void save()
        {

        }
    }
}
