/// <summary>
/// Author: Chintan Patel
/// Reference: Nathan Bean
/// Class: CIS 400
/// Purpose: Abstract base class for Entree
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstract base class for Entree
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of an entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the number of calories of an entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions for an entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get;}

        /// <summary>
        /// Event handler for notifiying when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
