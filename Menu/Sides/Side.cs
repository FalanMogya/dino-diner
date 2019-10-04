using System;
using System.Collections.Generic;
using System.Text;

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
    public abstract class Side : IMenuItem
    {
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

    }
}
