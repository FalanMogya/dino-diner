using System.Collections.Generic;

/*
 *  PrehistoricPBJ.cs
 *  Author: George Widenor
 *  Description: Define the object PrehistoricPBJ with a price, calories, and a list of ingredients with options to hold/remove ingredients.
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Define the object PrehistoricPBJ
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// Gets the list of ingredients excluding the ingredients the customer wants held for PrehistoricPBJ
        /// </summary>
        public override List<string> Ingredients
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
        /// Sets the appropriate price and calories for the PrehistoricPBJ
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
