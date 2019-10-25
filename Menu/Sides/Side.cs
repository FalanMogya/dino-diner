using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

/*
 * Side.cs
 * Author: George Widenor
 * Description: The base class to define all side classes
 */

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Defines the base class side so that all sides have a price, calories, ingredients list, and a size.
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem
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
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Contains the side's description
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }
    }
}
