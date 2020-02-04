using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Author: Chintan Patel
    /// Class: CornDodgers
    /// Purpose: A class representing the Corn Dodgers Fries entree.
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
    }
}