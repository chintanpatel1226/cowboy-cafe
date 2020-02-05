/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the Angry Chicken entree.
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree.
    /// </summary>
    public class AngryChicken : Entree
    {
        /// <summary>
        /// The price of the Angry Chicken
        /// </summary>
        public override double Price
        {
            get { return 5.99; }
        }

        /// <summary>
        /// The calories of the Angry Chicken
        /// </summary>
        public override uint Calories
        {
            get { return 190; }
        }

        private bool bread = true;
        /// <summary>
        /// If the sandwich has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the sandwich has a pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// Special instructions for the preparation of the sandwich.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
    }
}
