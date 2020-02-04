﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Author: Chintan Patel
    /// Class: PecosPulledPork
    /// Purpose: A class representing the Pecos Pulled Pork entree.
    /// </summary>
    public class PecosPulledPork : Entree
    {
        private bool bread = true;
        /// <summary>
        /// If Pecos Pulled Pork will have bread.
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If Pecos Pulled Pork will have pickle.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// The price of Pecos Pulled Pork.
        /// </summary>
        public override double Price
        {
            get { return 5.88; }
        }

        /// <summary>
        /// The calories of Pecos Pulled Pork.
        /// </summary>
        public override uint Calories
        {
            get { return 528; }
        }

        /// <summary>
        /// Special instructions for the prepartion of Pecos Pulled Pork.
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
