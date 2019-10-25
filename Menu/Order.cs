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
        /// <summary>
        /// An event handler for property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets and add items to the collection of items
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

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
            Items = new ObservableCollection<IOrderItem>();
            Items.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            Items.Add(item);
        }

        public void Remove(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            Items.Remove(item);
        }
    }
}
