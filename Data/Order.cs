/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the Order class.
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Order class.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Invoked any time a property changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// List of order items.
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Creates an IEnumerable copy of the list of orders.
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        private double subtotal;
        /// <summary>
        /// The subtotal of the items ordered.
        /// </summary>
        public double Subtotal
        {
            get
            {
                if (subtotal <= 0)
                {
                    subtotal = 0;
                }
                foreach (IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        private double tax = 0.16;
        /// <summary>
        /// The total with tax.
        /// </summary>
        public double TotalWithTax
        {
            get
            {
                double val = Subtotal * tax;
                return Subtotal + val;
            }
        }

        /// <summary>
        /// The base number that starts as the order number.
        /// </summary>
        static private uint lastOrderNumber = 0;

        /// <summary>
        /// The number of the last order which increments with the creation of a new order.
        /// </summary>
        public uint OrderNumber => lastOrderNumber;

        /// <summary>
        /// Adds an item to the order with the total cost.
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            if (item is INotifyPropertyChanged pcitem)
            {
                pcitem.PropertyChanged += OnItemChanged;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Removes an item to the order and from the total cost.
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            if (item is INotifyPropertyChanged pcitem)
            {
                pcitem.PropertyChanged -= OnItemChanged;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

        /// <summary>
        /// Public constructor
        /// </summary>
        public Order()
        {
            lastOrderNumber++;
        }
    }
}
