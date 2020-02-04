using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Author: Chintan Patel
    /// Class: PanDeCampo
    /// Purpose: A class representing the Pan de Campo  entree.
    /// </summary>
    public class PanDeCampo : Side
    {
        /// <summary>
        /// The price of Pan de Campo based on size
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
        /// The calories of Pan de Campo based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 227;
                    case (Size.Medium):
                        return 269;
                    case (Size.Large):
                        return 367;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}