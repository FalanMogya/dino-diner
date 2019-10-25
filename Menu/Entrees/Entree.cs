using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

/*
 * Entree.cs
 * Author: George Widenor
 * Description: The base class to define all entree classes
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Defines the base class of Entree so all entrees get a price, calories, and a ingredients list
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem
    {
        /// <summary>
        /// The PropertyChanged event handler; notifies of canges to the Price,
        /// Description, and Special properties
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        // Helperfunction for notifying of property changes
        protected virtual void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Contains the entree's description
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }
    }
}
