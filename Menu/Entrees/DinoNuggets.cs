using System;
using System.Collections.Generic;
using System.Text;

/*
 * DinoNuggets.cs
 * Author: George Widenor
 * Description: A class made to define the object DinoNuggets with a price, calories per nugget, and methods to add nuggets.
 */

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
		/// <summary>
		/// Public variables that the user can get and set number of nuggets, calorie total and price of the DinoNuggets
		/// </summary>
		public double Price { get; set; }
        public uint Calories { get; set; }
		public int Nuggets { get; set; }

        /// <summary>
        /// Displays the list of ingredients counting the nuggets that have been added
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
        /// The constructor that sets the appropriate price and calories
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
