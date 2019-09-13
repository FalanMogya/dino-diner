using System;
using System.Collections.Generic;
using System.Text;

/*
 * TRexKingBurger.cs
 * Author: George Widenor
 * Description: A class made to define the object TRexKingBurger with a price, calories per nugget, and with a list of ingredients with methods to help hold/remove ingredients.
 */
namespace Menu.Entrees
{
    public class TRexKingBurger
    {
        /// <summary>
        /// Private variable that keep track of if the bun, lettuce, tomato, onion, pickle, ketchup, mustard, or mayo is held or add to the TRexKingBurger
        /// </summary>
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        /// <summary>
        /// Public variables that the user can get and set calorie total and price of the TRexKingBurger
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
                List<string> ingredients = new List<string>();
                for (int i = 0; i < 3; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }
            }
        }

    }
}
