﻿/// <summary>
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

        /// <summary>
        /// The subtotal of the items ordered.
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
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
                return Subtotal + (Subtotal * tax);
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

        /// <summary>
        /// Invokes item changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

        /// <summary>
        /// Prints the receipt.
        /// </summary>
        /// <param name="cash"></param>
        /// <param name="paid"></param>
        /// <param name="change"></param>
        /// <returns></returns>
        public string Receipt(bool cash, double paid, double change)
        {
            string receipt = "";
            receipt += OrderNumber + "\n";
            receipt += DateTime.Now.ToString() + "\n\n";
            foreach (IOrderItem item in Items)
            {
                receipt += string.Format("{0}   ${1:#.00}\n", item.ToString(), item.Price);
                foreach (string instruction in item.SpecialInstructions)
                {
                    receipt += "   " + instruction + "\n";
                }
            }
            receipt += "\n\n";
            receipt += string.Format("Subtotal   ${0:#.00}\n", Subtotal);
            receipt += string.Format("Total      ${0:#.00}\n", TotalWithTax);
            if (cash)
            {
                receipt += string.Format("\nTotal Paid     ${0:#.00}\n", paid);
                receipt += string.Format("Total Change   ${0:#.00}\n", change);
                receipt += string.Format("Tendered       ${0:#.00}\n", paid - change);
                receipt += "CASH TENDERED\n\n";
            }
            else
            {
                receipt += string.Format("Tendered   ${0:#.00}\n", TotalWithTax);
                receipt += "CREDIT TENDERED\n\n";
            }
            receipt += "------------------------------\n\n";
            return receipt;
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
