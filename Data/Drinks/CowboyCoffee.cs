/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the Cowboy Coffee drink.
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee Drink.
    /// </summary>
    public class CowboyCoffee : Drink
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
                InvokePropertyChanged("Size");
            }
        }

        private bool roomForCream = false;
        /// <summary>
        /// If Cowboy Coffee will have room for cream.
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream;}
            set { 
                roomForCream = value;
                InvokePropertyChanged("RoomForCream");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool decaf = false;
        /// <summary>
        /// If Cowboy Coffee will be decaf.
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { 
                decaf = value;
                InvokePropertyChanged("Decaf");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool ice = false;
        /// <summary>
        /// If Cowboy Coffee will have ice.
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
        /// The prices of Cowboy Coffee based on size.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 0.60;
                    case (Size.Medium):
                        return 1.10;
                    case (Size.Large):
                        return 1.60;
                    default:
                        throw new NotImplementedException("Price not available");
                }
            }
            
        }
        
        /// <summary>
        /// The number of calories of Cowboy Coffee based on size.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 3;
                    case (Size.Medium):
                        return 5;
                    case (Size.Large):
                        return 7;
                    default:
                        throw new NotImplementedException("Calories not available");
                }
            }
        }

        /// <summary>
        /// Special instructions to prepare the Cowboy Coffee.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (ice) instructions.Add("Add Ice");
                if (roomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the human-readable name of the menu item
        /// </summary>
        /// <returns>The human-readble name of the menu item</returns>
        public override string ToString()
        {
            switch (Decaf)
            {
                case true:
                    return Size + " Decaf Cowboy Coffee";
                case false:
                    return Size + " Cowboy Coffee";
                default:
                    throw new NotImplementedException("Name not available");
            }
        }
    }
}