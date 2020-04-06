/// <summary>
/// Author: Nathan Bean
/// Edited By: Chintan Patel
/// Class: CIS 400
/// Purpose: A base class representing a side
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions on building a Side
        /// </summary>
        public List<string> SpecialInstructions => new List<string>();

        /// <summary>
        /// Invoked anytime a property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The size of the drink. Default size set to small.
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>2
        /// Helper method to trigger PropertyChanged events
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        protected void InvokePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
