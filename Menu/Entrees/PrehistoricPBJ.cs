using System.Collections.Generic;

/*
 *  PrehistoricPBJ.cs
 *  Author: George Widenor
 *  Description: A class made to define the object PrehistoricPBJ with a price, calories, and a list of ingredients with methods to remove some ingredients from the PrehistoricPBJ.
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Creates a class to define the object PrehistoricPBJ
    /// </summary>
    public class PrehistoricPBJ
    {
        /// <summary>
		/// Private variable that keep track of if the peanut butter or jelly is held or add to the PrehistoricPBJ
		/// </summary>
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
		/// Public variables that the user can get and set calorie total and price of the PrehistoricPBJ
		/// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// Displays the list of ingredients excluding the ingredients the customer wants held
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor that sets the appropriate price and calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
		/// Removes the peanut butter from the PrehistoricPBJ
		/// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
		/// Removes the jelly from the PrehistoricPBJ
		/// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
