using System;
using System.Collections.Generic;
using System.Text;

/*
 * Triceritots.cs
 * Author: George Widenor
 * Description: Defines the side Triceritots with a price, calories, and a list of ingredients
 */

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        /// <summary>
        /// Get the list of ingredients for Triceritots
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt",  "Vegetable Oil" };
            }
        }

        private Size size;

        /// <summary>
        /// Gets or sets the size for the Triceritots
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                }
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories for the Triceritots
        /// </summary>
        public Triceritots()
        {
            this.Price = 0.99;
            this.Calories = 352;
        }
    }
}
