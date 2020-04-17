/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the Water drink.
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Water drink.
    /// </summary>
    public class Water : Drink
    {

        private Size size;
        /// <summary>
        /// The size of the drink. Default size set to small.
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

        private bool lemon = false;
        /// <summary>
        /// If the Water drink will contain lemon.
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { 
                lemon = value;
                InvokePropertyChanged("Lemon");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool ice = true;
        /// <summary>
        /// If the Water drink will contain ice.
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { 
                ice = value;
                InvokePropertyChanged("Ice");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// The price of the Water based on the size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
                    default:
                        return 0.12;
                }
            }
        }

        /// <summary>
        /// The number of calories of the Water drink based on the size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// Special instructions required to make the Water drink.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                
                if(!ice) instructions.Add("Hold Ice");
                if(lemon) instructions.Add("Add Lemon");

                return instructions;
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
                    return "Small Water";
                case (Size.Medium):
                    return "Medium Water";
                case (Size.Large):
                    return "Large Water";
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string Name => "Water";
    }
}