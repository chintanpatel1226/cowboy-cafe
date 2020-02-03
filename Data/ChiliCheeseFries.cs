using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Chilli Cheese Fries entree
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// The price of Chilli Cheese Fries based on size
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
        /// The calories of Chilli Cheese Fries based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 434;
                    case (Size.Medium):
                        return 524;
                    case (Size.Large):
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

    }
}
