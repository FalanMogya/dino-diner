using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

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
    public class Order : INotifyPropertyChanged
    {
        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// An event handler for property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyAllPropertiesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        /// <summary>
        /// Gets and add items to the collection of items
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

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
                return Math.Max(cost, 0);
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

        public Order()
        {

        }
        
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertiesChanged();
        }

        /// <summary>
        /// Adds a new item to our order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertiesChanged();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyAllPropertiesChanged();
            }
            return removed;
        }
    }
}
