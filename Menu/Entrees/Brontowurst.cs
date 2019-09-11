using System;
using System.Collections.Generic;
using System.Text;

/*
 *  Brontowurst.cs
 *  Author: George Widenor
 *  Description: A class made to define the object brontowurst with a price, calories, and a list of ingredients with methods to remove some ingredients from the Brontowurst.
 */

namespace Menu.Entrees
{
    public class Brontowurst
    {
        /// <summary>
        /// Private variable that keep track off if the bun, peppers, or onion is want to be added to the brontowurst
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// Public variables that the user can get and set calorie total and price of the brontowurst
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
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor that sets the appropriate price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 483;
        }

        /// <summary>
        /// Removes the bun from the list of ingredients
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Removes the peppers from the Brontowurst
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Removes the onions from the Brontowurst
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
