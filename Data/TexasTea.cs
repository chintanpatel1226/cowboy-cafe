/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the Texas Tea drink.
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink.
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// Invoked anytime a property is changed.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        private bool sweet = true;
        /// <summary>
        /// If the Texas Tea will be sweet.
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set { 
                sweet = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sweet"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool lemon = false;
        /// <summary>
        /// If the Texas Tea will have lemon.
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { 
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        
        private bool ice = true;
        /// <summary>
        /// If the Texas Tea will have ice.
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { 
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        
        /// <summary>
        /// The price of the Texas Tea based on the size.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.00;
                    case (Size.Medium):
                        return 1.50;
                    case (Size.Large):
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
            
        }
        
        /// <summary>
        /// The number of calories of the Texas Tea based on size.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return sweet ? (uint) 10 : 5;
                    case (Size.Medium):
                        return sweet ? (uint) 22 : 11;
                    case (Size.Large):
                        return sweet ? (uint) 36 : 18;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        
        /// <summary>
        /// Special instructions required to make the Texas Tea.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                
                if(!ice) instructions.Add("Hold Ice");
                if(lemon) instructions.Add("Add Lemon");
                if (!sweet) instructions.Add("Not Implemented");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the human-readable name of the menu item
        /// </summary>
        /// <returns>The human-readble name of the menu item</returns>
        public override string ToString()
        {
            switch (sweet)
            {
                case true:
                    return Size + " Texas Sweet Tea";
                case false:
                    return Size + " Texas Plain Tea";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}