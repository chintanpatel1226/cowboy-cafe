using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Dakota Double Burger entree.
    /// </summary>
    class DakotaDoubleBurger
    {
        private bool tomato = true;
        /// <summary>
        /// If the burger is topped with tomato.
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        private bool lettuce = true;
        /// <summary>
        /// If the burger is topped with lettuce.
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        private bool mayo = true;
        /// <summary>
        /// If the burger is topped with mayo.
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <summary>
        /// The price of the burger.
        /// </summary>
        public double Price
        {
            get { return 5.20; }
        }

        /// <summary>
        /// The calories of the burger.
        /// </summary>
        public uint Calories
        {
            get { return 464; }
        }

        /// <summary>
        /// Special instructions for the preparation of the burger.
        /// </summary>
        public List<string> SpecialInstruction
        {
            get
            {
                var instructions = new List<string>();

                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");

                return instructions;
            }
        }


    }
}
