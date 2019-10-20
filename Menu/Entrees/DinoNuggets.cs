using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

/*
 * DinoNuggets.cs
 * Author: George Widenor
 * Description: Defines the object DinoNuggets with a price, calories per nugget, ingredients list, and a option to add nuggets.
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Define the object DinoNuggets
    /// </summary>
    public class DinoNuggets : Entree, IOrderItem, INotifyPropertyChanged
    {
        // Backing Variables
        private int nuggets = 6;

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
                if (nuggets - 6 > 0) special.Add((nuggets - 6) + " Extra Nuggets");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Gets the ingredients list counting the nuggets that have been added for the DinoNuggets
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < this.nuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories for the DinoNuggets
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = (59 * 6);
        }

        /// <summary>
        /// Adds a nugget and updates the price and calories.
        /// </summary>
        public void AddNugget()
        {
            this.nuggets += 1;
            this.Price += .25;
            this.Calories += 59;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Price");
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
            return "Dino-Nuggets";
        }
    }
}
