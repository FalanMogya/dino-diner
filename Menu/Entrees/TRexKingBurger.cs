using System;
using System.Collections.Generic;
using System.Text;

/*
 * TRexKingBurger.cs
 * Author: George Widenor
 * Description: A class made to define the object TRexKingBurger with a price, calories, and with a list of ingredients with methods to help hold/remove ingredients.
 */
namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Creates a class to define the object TRexKingBurger
    /// </summary>
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
				if (bun) ingredients.Add("Whole Wheat Bun");
				if (lettuce) ingredients.Add("Lettuce");
				if (tomato) ingredients.Add("Tomato");
				if (onion) ingredients.Add("Onion");
				if (pickle) ingredients.Add("Pickle");
				if (ketchup) ingredients.Add("Ketchup");
				if (mustard) ingredients.Add("Mustard");
				if (mayo) ingredients.Add("Mayo");
				return ingredients;
			}
		}

		/// <summary>
		/// The constructor that sets the appropriate price and calories
		/// </summary>
		public TRexKingBurger()
		{
			this.Price = 8.45;
			this.Calories = 728;
		}

		/// <summary>
		/// Removes the bun from the TRexKingBurger
		/// </summary>
		public void HoldBun()
		{
			this.bun = false;
		}

		/// <summary>
		/// Removes the lettuce from the TRexKingBurger
		/// </summary>
		public void HoldLettuce()
		{
			this.lettuce = false;
		}

		/// <summary>
		/// Removes the tomato from the TRexKingBurger
		/// </summary>
		public void HoldTomato()
		{
			this.tomato = false;
		}

		/// <summary>
		/// Removes the onion from the TRexKingBurger
		/// </summary>
		public void HoldOnion()
		{
			this.onion = false;
		}

		
		/// <summary>
		/// Removes the pickle from the TRexKingBurger
		/// </summary>
		public void HoldPickle()
		{
			this.pickle = false;
		}

		/// <summary>
		/// Removes the ketchup from the TRexKingBurger
		/// </summary>
		public void HoldKetchup()
		{
			this.ketchup = false;
		}

		/// <summary>
		/// Removes the mustard from the TRexKingBurger
		/// </summary>
		public void HoldMustard()
		{
			this.mustard = false;
		}

		/// <summary>
		/// Removes the mayo from the TRexKingBurger
		/// </summary>
		public void HoldMayo()
		{
			this.mayo = false;
		}
	}
}
