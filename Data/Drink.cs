/// <summary>
/// Author:  Chintan Patel
/// Class: CIS 400
/// Purpose: A base class representing a drink
/// </summary>
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing drink.
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Invoked anytime a property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the drink.
        /// </summary>
        public abstract double Price { get; }
        
        /// <summary>
        /// The number of calories of the drink.
        /// </summary>
        public abstract uint Calories { get; }
        
        /// <summary>
        /// The special instructions to prepare the drink.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        private Size size;
        /// <summary>
        /// The size of the drink. Default size set to small.
        /// </summary>
        public virtual Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        /// <summary>
        /// Whether the drink will have ice. Default set to true.
        /// </summary>
        public abstract bool Ice { get; set; }

    }
}