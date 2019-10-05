using System;
using System.Collections.Generic;
using System.Text;

/*
 * PterodactylWings.cs
 * Author: George Widenor
 * Description: Define the object PterodactylWings with a price, calories, and with a ingredients list.
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Define the object PterodactylWings
    /// </summary>
    public class PterodactylWings : Entree
    {

        /// <summary>
        /// Gets the ingredients list for the PterodactylWings
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories for the PterodactylWings
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// Gets PterodactylWings
        /// </summary>
        /// <returns>Pterodactyl Wings</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
