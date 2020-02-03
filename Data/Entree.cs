using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstract base class for Entree
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// Gets the price of an entree
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// Gets the number of calories of an entree
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// Gets the special instructions for an entree
        /// </summary>
        public List<string> SpecialInstructions { get;}
    }
}
