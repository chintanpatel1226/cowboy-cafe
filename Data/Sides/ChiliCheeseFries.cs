/// <summary>
/// Author: Nathan Bean
/// Edited By: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the Chili Cheese Fries side.
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Chili Cheese Fries side.
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// The price of Chili Cheese Fries based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.99;
                    case (Size.Medium):
                        return 2.99;
                    case (Size.Large):
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories of Chili Cheese Fries based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 433;
                    case (Size.Medium):
                        return 524;
                    case (Size.Large):
                        return 610;
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
            return Size.ToString() + " Chili Cheese Fries";
        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string Name()
        {
            return "Chili Cheese Fries";
        }
    }
}
