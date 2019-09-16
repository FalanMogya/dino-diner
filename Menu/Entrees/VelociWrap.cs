using System;
using System.Collections.Generic;
using System.Text;

/*
 * VelociWrap.cs
 * Author: George Widenor
 * Description: A class made to define the object Veloci-Wrap with a price, calories, and with a list of ingredients with methods to help hold/remove ingredients.
 */
namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Creates a class to define the object Veloci-Wrap
    /// </summary>
    public class VelociWrap
	{
		/// <summary>
		/// Private variable that keep track of if the Ceasar Dressing, Lettuce, or Parmesan Cheese is held or add to the Veloci-Wrap
		/// </summary>
		private bool dressing = true;
		private bool lettuce = true;
		private bool cheese = true;

		/// <summary>
		/// Public variables that the user can get and set calorie total and price of the Veloci-Wrap
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
				List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
				if (dressing) ingredients.Add("Ceasar Dressing");
				if (lettuce) ingredients.Add("Romaine Lettuce");
				if (cheese) ingredients.Add("Parmesan Cheese");
				return ingredients;
			}
		}

		/// <summary>
		/// The constructor that sets the appropriate price and calories
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
