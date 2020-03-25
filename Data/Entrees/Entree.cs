/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: Abstract base class for Entree
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstract base class for Entree
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Gets the price of an entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the number of calories of an entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions for an entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get;}
    }
}
