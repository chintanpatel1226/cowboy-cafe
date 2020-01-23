using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class represting the Rustler's Ribs entree.
    /// </summary>
    public class RustlersRibs
    {
        /// <summary>
        /// The price of ribs.
        /// </summary>
        public double Price
        {
            get { return 7.50; }
        }

        /// <summary>
        /// The calore of ribs.
        /// </summary>
        public uint Calories
        {
            get { return 894; }
        }

        /// <summary>
        /// Special instructions for the preparation of Rusler's Ribs.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }
    }
}
