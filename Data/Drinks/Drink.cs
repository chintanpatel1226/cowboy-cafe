/// <summary>
/// Author:  Chintan Patel
/// Reference: Nathan Bean
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

        /// <summary>
        /// The size of the drink. Default size set to small.
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Whether the drink will have ice. Default set to true.
        /// </summary>
        public abstract bool Ice { get; set; }

        /// <summary>
        /// Event handler for notifiying when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper method to trigger PropertyChanged events
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        protected void InvokePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Returns the name of the menu item.
        /// </summary>
        /// <returns>The name of the menu item.</returns>
        public abstract string Name();
    }
}