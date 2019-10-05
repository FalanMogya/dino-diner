using System;
using System.Collections.Generic;
using System.Text;

/*
 * SteakosaurusBurger.cs
 * Author: George Widenor
 * Description: Define the object SteakosaurusBurger with a price, calories, and with a ingredients list with options to hold/remove ingredients.
 */
namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Define the object SteakosaurusBurger
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// Gets the ingredients list excluding the ingredients the customer wants held for the SteakosaurusBurger
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories for the SteakosaurusBurger
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Removes the bun from the SteakosaurusBurger
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Removes the pickle from the SteakosaurusBurger
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Removes the ketchup from the SteakosaurusBurger
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Removes the mustard from the SteakosaurusBurger
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Gets SteakosaurusBurger
        /// </summary>
        /// <returns>Steakosaurus Burger</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
