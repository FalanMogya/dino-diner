using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

/*
 * PterodactylWings.cs
 * Author: George Widenor
 * Description: Define the object PterodactylWings with a price, calories, and with a ingredients list.
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Define the object PterodactylWings
    /// </summary>
    public class PterodactylWings : Entree, IOrderItem, INotifyPropertyChanged
    {
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
                return special.ToArray();
            }
        }

        /// <summary>
        /// Gets the ingredients list for the PterodactylWings
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories for the PterodactylWings
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
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
            return "Pterodactyl Wings";
        }
    }
}
