using System;
using System.Collections.Generic;
using System.Text;

/*
 * PterodactylWings.cs
 * Author: George Widenor
 * Description: A class made to define the object PterodactylWings with a price, calories, and with a list of ingredients.
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Creates a class to define the object PterodactylWings
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// Public variables that the user can get and set calorie total and price of the PterodactylWings
        /// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// Displays the list of ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor that sets the appropriate price and calories
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
