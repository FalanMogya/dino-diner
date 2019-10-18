using System;
using System.Collections.Generic;
using System.Text;

/*
 * IOrderItem.cs
 * Author: George Widenor
 * Description: Defines the base requirements for all order item that they must have a price, description, and special instructions for the food preparation 
 */

namespace DinoDiner.Menu
{
    /// <summary>
    /// Defines the base requirements for all order items
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Gets the Price
        /// </summary>
        double Price
        {
            get;
        }

        /// <summary>
        /// Gets the item's description
        /// </summary>
        string Description
        {
            get;
        }

        /// <summary>
        /// Contains any special instructions for the food preparation
        /// </summary>
        string[] Special
        {
            get;
        }
    }
}
