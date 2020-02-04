using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Author: Chintan Patel
    /// Class: RustlersRibs
    /// Purpose: A class representing the Rustler's Ribs entree.
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
    }
}
