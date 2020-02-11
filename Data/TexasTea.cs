/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the Texas Tea drink.
/// </summary>
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink.
    /// </summary>
    public class TexasTea : Drink
    {
        private bool sweet = true;
        /// <summary>
        /// If the Texas Tea will be sweet.
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }
        private bool lemon = false;
        /// <summary>
        /// If the Texas Tea will have lemon.
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }
        
        private bool ice = true;
        /// <summary>
        /// If the Texas Tea will have ice.
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
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

                return instructions;
            }
        }
    }
}