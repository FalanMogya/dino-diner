using System;
using System.Collections.Generic;
using System.Text;

/*
 * SteakosaurusBurger.cs
 * Author: George Widenor
 * Description: A class made to define the object SteakosaurusBurger with a price, calories, and with a list of ingredients with methods to help hold/remove ingredients.
 */
namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Creates a class to define the object SteakosaurusBurger
    /// </summary>
    public class SteakosaurusBurger
    {
        /// <summary>
        /// Private variable that keep track of if the bun, pickle, ketchup, or mustard is held or add to the SteakosaurusBurger
        /// </summary>
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// Public variables that the user can get and set calorie total and price of the SteakosaurusBurger
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
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor that sets the appropriate price and calories
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
    }
}
