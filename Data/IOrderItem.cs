﻿/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the IOrderItem interface.
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order;
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of this order item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The special instructions for this order item.
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// The number of calories this order item.
        /// </summary>
        uint Calories { get; }
    }
}
