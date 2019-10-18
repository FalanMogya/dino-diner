﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

/*  
 * Sodasaurus.cs
 * Author: George Widenor
 * Description: Defines the drink Sodasaurus with a price, calories, flavor, ingredients list, and size
 */

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Defines the drink Sodasaurus
    /// </summary>
    public class Sodasaurus : Drink, IOrderItem
    {
        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Gets and sets the flavor for the Sodasaurus
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

        /// <summary>
        /// Gets the ingredients list for the Sodasaurus
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
                return ingredients;
            }
        }

        /// <summary>
        /// Gets and sets the size for the Sodasaurus
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                }
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories for the Sodasaurus
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
        }

        /// <summary>
        /// Returns the drink identity string
        /// </summary>
        /// <returns>The drink as a string</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
        }
    }
}
