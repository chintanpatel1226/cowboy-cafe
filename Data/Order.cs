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
        private uint lastOrderNumber = 0;

        /// <summary>
        /// List of order items.
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items => items.ToArray();

        private double subtotal = 0;
        public double Subtotal => subtotal;

        public uint OrderNumber => lastOrderNumber++;

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
