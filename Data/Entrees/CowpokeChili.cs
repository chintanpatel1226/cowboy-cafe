﻿/// <summary>
/// Author: Nathan Bean
/// Edited By: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the Cowpoke Chili entree.
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree.
    /// </summary>
    public class CowpokeChili : Entree
    {

        private bool cheese = true;
        /// <summary>
        /// If the chili is topped with cheese.
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set {
                cheese = value;
                InvokePropertyChanged("Cheese");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool sourCream = true;
        /// <summary>
        /// If the chili is topped with sour cream.
        /// </summary>
        public bool SourCream
        {
            get { return sourCream; }
            set { 
                sourCream = value;
                InvokePropertyChanged("SourCream");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool greenOnions = true;
        /// <summary>
        /// If the chili is topped with green onions.
        /// </summary>
        public bool GreenOnions
        {
            get { return greenOnions; }
            set { 
                greenOnions = value;
                InvokePropertyChanged("GreenOnions");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool tortillaStrips = true;
        /// <summary>
        /// If the chili is topped with tortilla strips.
        /// </summary>
        public bool TortillaStrips
        {
            get { return tortillaStrips; }
            set { 
                tortillaStrips = value;
                InvokePropertyChanged("TortillaStrips");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// The price of the chili.
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.10;
            }
        }

        /// <summary>
        /// The calories of the chili.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 171;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chili.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!sourCream) instructions.Add("hold sour cream");
                if (!greenOnions) instructions.Add("hold green onions");
                if (!tortillaStrips) instructions.Add("hold tortilla strips");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the human-readable name of the menu item
        /// </summary>
        /// <returns>The human-readble name of the menu item</returns>
        public override string ToString()
        {
            return "Cowpoke Chili";
        }
    }
}

