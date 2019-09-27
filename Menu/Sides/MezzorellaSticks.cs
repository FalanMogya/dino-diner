using System;
using System.Collections.Generic;
using System.Text;

/*
 * MezzorellaSticks.cs
 * Author: George Widenor
 * Description: Defines the side MezzorellaSticks with a price, calories, a ingredients list, and a size
 */

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Defines the side MezzorellaSticks
    /// </summary>
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Get the ingredients list for MezzorellaSticks
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
            }
        }

        private Size size;

        /// <summary>
        /// Gets or sets the size for the MezzorellaSticks
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
                        Calories = 720;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                }
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories for the MezzorellaSticks
        /// </summary>
        public MezzorellaSticks()
        {
            this.Price = 0.99;
            this.Calories = 540;
        }
    }
}
