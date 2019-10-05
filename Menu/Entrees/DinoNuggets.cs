using System;
using System.Collections.Generic;
using System.Text;

/*
 * DinoNuggets.cs
 * Author: George Widenor
 * Description: Defines the object DinoNuggets with a price, calories per nugget, ingredients list, and a option to add nuggets.
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Define the object DinoNuggets
    /// </summary>
    public class DinoNuggets : Entree
    {
        private int nuggets = 6;

        /// <summary>
        /// Gets the ingredients list counting the nuggets that have been added for the DinoNuggets
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < this.nuggets; i++)
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

        /// <summary>
        /// Gets DinoNuggets
        /// </summary>
        /// <returns>Dino-Nuggets</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
