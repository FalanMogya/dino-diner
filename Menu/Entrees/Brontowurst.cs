using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

/*
 *  Brontowurst.cs
 *  Author: George Widenor
 *  Description: Define the object Brontowurst with a price, calories, and a ingredients list with options to hold/remove ingredients.
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Define the object Brontowurst
    /// </summary>
    public class Brontowurst : Entree, IOrderItem, INotifyPropertyChanged
    {
        // Backing Variables
		private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// The PropertyChanged event handler; notifies of canges to the Price,
        /// Description, and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // Helperfunction for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!peppers) special.Add("Hold Peppers");
                if (!onions) special.Add("Hold Onion");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Get the ingredients list excluding the ingredients the customer wants held for the Brontowurst
        /// </summary>
        public override List<string> Ingredients
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
        /// Sets the appropriate price and calories for the Brontowurst
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

		/// <summary>
		/// Removes the bun from the Brontowurst
		/// </summary>
		public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

		/// <summary>
		/// Removes the peppers from the Brontowurst
		/// </summary>
		public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

		/// <summary>
		/// Removes the onions from the Brontowurst
		/// </summary>
		public void HoldOnion()
        {
            this.onions = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Contains the entree's description
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Returns the entree identity string
        /// </summary>
        /// <returns>The entree as a string</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
