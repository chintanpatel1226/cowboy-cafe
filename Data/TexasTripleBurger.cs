using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree.
    /// </summary>
    class TexasTripleBurger
    {
        private bool bacon = true;
        /// <summary>
        /// If the burger is topped with bacon.
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }

        private bool egg = true;
        /// <summary>
        /// If the burger is topped with egg.
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /// <summary>
        /// The price of the burger.
        /// </summary>
        public double Price
        {
            get { return 6.45; }
        }

        /// <summary>
        /// The calories of the burger.
        /// </summary>
        public uint Calories
        {
            get { return 698; }
        }

        /// <summary>
        /// Special instructions for the preparation of the burger.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");

                return instructions;
            }
        }


    }
}
