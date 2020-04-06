/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the Corn Dodgers side.
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Corn Dodgers side.
    /// </summary>
    public class CornDodgers : Side
    {

        /// <summary>
        /// The price of Corn Dodgers based on size
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
        /// The calories of Corn Dodgers based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 512;
                    case (Size.Medium):
                        return 685;
                    case (Size.Large):
                        return 717;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private Size size;
        /// <summary>
        /// The size of the side. Default size set to small.
        /// </summary>
        public Size Size
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
            return Size + " Corn Dodgers";
        }
    }
}