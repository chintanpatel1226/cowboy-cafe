/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the Pan de Campo side.
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pan de Campo side.
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

        private Size size;
        /// <summary>
        /// The size of the side. Default size set to small.
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                InvokePropertyChanged("Price");
                InvokePropertyChanged("Calories");
                InvokePropertyChanged("Size");
            }
        }

        /// <summary>
        /// Returns the human-readable name of the menu item
        /// </summary>
        /// <returns>The human-readble name of the menu item</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case (Size.Small):
                    return "Small Pan de Campo";
                case (Size.Medium):
                    return "Medium Pan de Campo";
                case (Size.Large):
                    return "Large Pan de Campo";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}