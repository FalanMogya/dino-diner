using System;
using System.Collections.Generic;
using System.Text;

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
    public class VelociWrap : Entree
	{
		private bool dressing = true;
		private bool lettuce = true;
		private bool cheese = true;

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
		}

		/// <summary>
		/// Removes the lettuce from the Veloci-Wrap
		/// </summary>
		public void HoldLettuce()
		{
			this.lettuce = false;
		}

		/// <summary>
		/// Removes the cheese from the Veloci-Wrap
		/// </summary>
		public void HoldCheese()
		{
			this.cheese = false;
		}
	}
}
