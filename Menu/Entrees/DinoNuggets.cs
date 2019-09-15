using System;
using System.Collections.Generic;
using System.Text;

/*
 * DinoNuggets.cs
 * Author: George Widenor
 * Description: A class made to define the object DinoNuggets with a price, calories per nugget, and methods to add nuggets.
 */

namespace Menu.Entrees
{
    public class DinoNuggets
    {
		/// <summary>
		/// Private variable that keep track of the number of nuggets in the DinoNuggets
		/// </summary>
		private int nuggets = 6;

		/// <summary>
		/// Public variables that the user can get and set calorie total and price of the DinoNuggets
		/// </summary>
		public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// Displays the list of ingredients counting the nuggets that have been added
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < nuggets; i++)
                {
                    ingredients.Add("Chicken Nuggets");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor that sets the appropriate price and calories
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = (6 * 59);
        }

        /// <summary>
        /// Adds a nugget and updates the price and calories.
        /// </summary>
        public void AddNugget()
        {
            this.nuggets += 1;
            this.Price += .25;
            this.Calories += 59;
        }
    }
}
