﻿using System;
using System.Collections.Generic;
using System.Text;

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
    public abstract class Entree
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
    }
}
