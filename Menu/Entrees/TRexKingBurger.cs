using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

/*
 * TRexKingBurger.cs
 * Author: George Widenor
 * Description: Define the object TRexKingBurger with a price, calories, and with a ingredients list with options to hold/remove ingredients.
 */
namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Define the object TRexKingBurger
    /// </summary>
	public class TRexKingBurger : Entree, IOrderItem, INotifyPropertyChanged
	{
        // Backing Variables
		private bool bun = true;
		private bool lettuce = true;
		private bool tomato = true;
		private bool onion = true;
		private bool pickle = true;
		private bool ketchup = true;
		private bool mustard = true;
		private bool mayo = true;

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
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                if (!onion) special.Add("Hold Onion");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Gets the ingredients list excluding the ingredients the customer wants held for the TRexKingBurger
        /// </summary>
        public override List<string> Ingredients
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
		/// Sets the appropriate price and calories for the TRexKingBurger
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
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

		/// <summary>
		/// Removes the lettuce from the TRexKingBurger
		/// </summary>
		public void HoldLettuce()
		{
			this.lettuce = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

		/// <summary>
		/// Removes the tomato from the TRexKingBurger
		/// </summary>
		public void HoldTomato()
		{
			this.tomato = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

		/// <summary>
		/// Removes the onion from the TRexKingBurger
		/// </summary>
		public void HoldOnion()
		{
			this.onion = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

		
		/// <summary>
		/// Removes the pickle from the TRexKingBurger
		/// </summary>
		public void HoldPickle()
		{
			this.pickle = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

		/// <summary>
		/// Removes the ketchup from the TRexKingBurger
		/// </summary>
		public void HoldKetchup()
		{
			this.ketchup = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

		/// <summary>
		/// Removes the mustard from the TRexKingBurger
		/// </summary>
		public void HoldMustard()
		{
			this.mustard = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

		/// <summary>
		/// Removes the mayo from the TRexKingBurger
		/// </summary>
		public void HoldMayo()
		{
			this.mayo = false;
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
            return "T-Rex King Burger";
        }
    }
}
