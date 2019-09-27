using System;
using System.Collections.Generic;
using System.Text;

/*
 * MeteorMacAndCheese.cs
 * Author: George Widenor
 * Description: Defines the side MeteorMacAndCheese with a price, calories, a ingredients list, and a size
 */

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Defines the side MeteorMacAndCheese
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// Get the ingredients list for MeteorMacAndCheese
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
            }
        }

        private Size size;

        /// <summary>
        /// Gets or sets the size for the MeteorMacAndCheese
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
                        Calories = 520;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        break;
                }
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories for the MeteorMacAndCheese
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Price = 0.99;
            this.Calories = 420;
        }
    }
}
