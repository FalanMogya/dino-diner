using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

/*
 * Order.cs
 * Author: George Widenor
 * Description: Represents a new customer order
 */

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents a new customer order
    /// </summary>
    public class Order
    {
        private ObservableCollection<IOrderItem> items;

        /// <summary>
        /// Gets and add items to the collection of items
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// Gets the subtotal cost
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double cost = 0;
                foreach (IOrderItem item in Items)
                {
                    cost += item.Price;
                }
                return Math.Abs(cost);
            }
        }

        /// <summary>
        /// Gets or Sets the Sales Tax Rate
        /// </summary>
        public double SalesTaxRate { get; protected set; } = 0.01;

        /// <summary>
        /// Gets the Sales Tax Cost
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return (SubtotalCost * SalesTaxRate);
            }
        }

        /// <summary>
        /// Gets the Total Cost
        /// </summary>
        public double TotalCost
        {
            get
            {
                return (SubtotalCost + SalesTaxCost);
            }
        }
    }
}
