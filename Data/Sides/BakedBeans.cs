/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: c
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Baked Beans entree.
    /// </summary>
    public class BakedBeans : Side
    {

        /// <summary>
        /// The price of Baked Beans based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.59;
                    case (Size.Medium):
                        return 1.79;
                    case (Size.Large):
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        
        /// <summary>
        /// The calories of Baked Beans based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 312;
                    case (Size.Medium):
                        return 378;
                    case (Size.Large):
                        return 410;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns the human-readable name of the menu item
        /// </summary>
        /// <returns>The human-readble name of the menu item</returns>
        public override string ToString()
        {
            return Size + " Baked Beans";
        }
    }
}