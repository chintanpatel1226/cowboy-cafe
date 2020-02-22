/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the Jerked Soda drink.
/// </summary>
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda drink.
    /// </summary>
    public class JerkedSoda : Drink
    {
        private SodaFlavor flavor;
        /// <summary>
        /// What flavor the Jerked Soda will contain.
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
        
        private bool ice = true;
        /// <summary>
        /// If the Jerked Soda will have ice.
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        
        /// <summary>
        /// The price of the Jerked Soda based on the size.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.59;
                    case (Size.Medium):
                        return 2.10;
                    case (Size.Large):
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
            
        }
        
        /// <summary>
        /// The number of calories of the Jerked Soda based on the size.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 110;
                    case (Size.Medium):
                        return 146;
                    case (Size.Large):
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Special instructions to prepare the Jerked Soda.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                
                if(!ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the human-readable name of the menu item
        /// </summary>
        /// <returns>The human-readble name of the menu item</returns>
        public override string ToString()
        {
            switch (flavor)
            {
                case SodaFlavor.BirchBeer:
                    return Size + " Birch Beer Jerked Soda";
                case SodaFlavor.CreamSoda:
                    return Size + " Cream Soda Jerked Soda";
                case SodaFlavor.OrangeSoda:
                    return Size + " Orange Soda Jerked Soda";
                case SodaFlavor.RootBeer:
                    return Size + " Root Beer Jerked Soda";
                case SodaFlavor.Sarsparilla:
                    return Size + " Sarsparilla Jerked Soda";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}