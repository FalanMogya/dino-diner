using System;
using System.Collections.Generic;
using System.Text;

/*
 * DinoNuggets.cs
 * Author: George Widenor
 * Description: Defines the object DinoNuggets with a price, calories per nugget, list of ingredients, and methods to add nuggets.
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Define the object DinoNuggets
    /// </summary>
    public class DinoNuggets
    {
		/// <summary>
		/// Get and set number of nuggets, calorie total and price of the DinoNuggets
		/// </summary>
		public double Price { get; set; }
        public uint Calories { get; set; }
		public int Nuggets { get; set; }

        /// <summary>
        /// Gets the list of ingredients counting the nuggets that have been added
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < this.Nuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories for the DinoNuggets
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = (59 * 6);
			this.Nuggets = 6;
        }

        /// <summary>
        /// Adds a nugget and updates the price and calories.
        /// </summary>
        public void AddNugget()
        {
            this.Nuggets += 1;
            this.Price += .25;
            this.Calories += 59;
        }
    }
}
