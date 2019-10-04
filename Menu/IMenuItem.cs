using System;
using System.Collections.Generic;
using System.Text;

/*
 *  IMenuItem.cs
 *  Author: George Widenor
 *  Description: Defines the base requirements for all menu item that they must have a price, calories, and ingredients list
 */

namespace DinoDiner.Menu
{
    /// <summary>
    /// Defines the base requirements for all menu items
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Gets the Price
        /// </summary>
        double Price
        {
            get;
        }

        /// <summary>
        /// Gets the Calories
        /// </summary>
        uint Calories
        {
            get;
        }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        List<string> Ingredients
        {
            get;
        }
    }
}
