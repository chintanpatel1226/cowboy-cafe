/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the Pecos Pulled Pork entree.
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree.
    /// </summary>
    public class PecosPulledPork : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Invoked anytime a property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private bool bread = true;
        /// <summary>
        /// If Pecos Pulled Pork will have bread.
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { 
                bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If Pecos Pulled Pork will have pickle.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { 
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
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

        /// <summary>
        /// Returns the human-readable name of the menu item
        /// </summary>
        /// <returns>The human-readble name of the menu item</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
