using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

/*
 * Drink.cs
 * Author: George Widenor
 * Description: The base class to define all drink classes
 */

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Defines the base class Drink so that all drinks have a price, calories, a ingredients list, a size, Ice, and a method to hold ice.
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The PropertyChanged event handler; notifies of canges to the Price,
        /// Description, and Special properties
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        // Helperfunction for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
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

        protected Size size = Size.Small;

        /// <summary>
        /// Gets and sets the size
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        private bool ice = true;

        /// <summary>
        /// Gets whether ice will be add or not
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }

        /// <summary>
        /// Contains the drink's description
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Removes ice from the drink
        /// </summary>
        public virtual void HoldIce()
        {
            this.ice = false;
            NotifyOfPropertyChange("Special");
        }
    }
}
