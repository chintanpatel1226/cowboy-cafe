using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// The number of the last order.
        /// </summary>
        private uint lastOrderNumber;

        /// <summary>
        /// List of order items.
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items => items.ToArray();

        private double subtotal;
        public double Subtotal => subtotal;

        public uint OrderNumber { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    
        public void Add(IOrderItem item)
        {
            subtotal += item.Price;
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(IOrderItem item)
        {
            subtotal -= item.Price;
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
