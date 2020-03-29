/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the Rustler's Ribs entree.
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree.
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of ribs.
        /// </summary>
        public override double Price
        {
            get { return 7.50; }
        }

        /// <summary>
        /// The calore of ribs.
        /// </summary>
        public override uint Calories
        {
            get { return 894; }
        }

        /// <summary>
        /// Special instructions for the preparation of Rusler's Ribs.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// Returns the human-readable name of the menu item
        /// </summary>
        /// <returns>The human-readble name of the menu item</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
