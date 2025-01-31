﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

/*
 * VelociWrap.cs
 * Author: George Widenor
 * Description: Define the object Veloci-Wrap with a price, calories, and with a ingredients list with options to hold/remove ingredients.
 */
namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Define the object Veloci-Wrap
    /// </summary>
    public class VelociWrap : Entree, IOrderItem, INotifyPropertyChanged
	{
        // Backing variables
		private bool dressing = true;
		private bool lettuce = true;
		private bool cheese = true;

        /// <summary>
        /// The PropertyChanged event handler; notifies of canges to the Price,
        /// Description, and Special properties
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        // Helperfunction for notifying of property changes
        protected override void NotifyOfPropertyChange(string propertyName)
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
                if (!dressing) special.Add("Hold Dressing");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!cheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Gets the ingredients list excluding the ingredients the customer wants held for the Veloci-Wrap
        /// </summary>
        public override List<string> Ingredients
		{
			get
			{
				List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
				if (dressing) ingredients.Add("Ceasar Dressing");
				if (lettuce) ingredients.Add("Romaine Lettuce");
				if (cheese) ingredients.Add("Parmesan Cheese");
				return ingredients;
			}
		}

		/// <summary>
		/// Sets the appropriate price and calories for the Veloci-Wrap
		/// </summary>
		public VelociWrap()
		{
			this.Price = 6.86;
			this.Calories = 356;
		}

		/// <summary>
		/// Removes the dressing from the Veloci-Wrap
		/// </summary>
		public void HoldDressing()
		{
			this.dressing = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

		/// <summary>
		/// Removes the lettuce from the Veloci-Wrap
		/// </summary>
		public void HoldLettuce()
		{
			this.lettuce = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

		/// <summary>
		/// Removes the cheese from the Veloci-Wrap
		/// </summary>
		public void HoldCheese()
		{
			this.cheese = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Returns the entree identity string
        /// </summary>
        /// <returns>The entree as a string</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
