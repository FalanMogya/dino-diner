using System.Collections.Generic;
using System.ComponentModel;

/*
 *  PrehistoricPBJ.cs
 *  Author: George Widenor
 *  Description: Define the object PrehistoricPBJ with a price, calories, and a ingredients list with options to hold/remove ingredients.
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Define the object PrehistoricPBJ
    /// </summary>
    public class PrehistoricPBJ : Entree, IOrderItem, INotifyPropertyChanged
    {
        // Backing variables
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// The PropertyChanged event handler; notifies of canges to the Price,
        /// Description, and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Helperfunction for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Gets the ingredients list excluding the ingredients the customer wants held for PrehistoricPBJ
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories for the PrehistoricPBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
		/// Removes the peanut butter from the PrehistoricPBJ
		/// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
		/// Removes the jelly from the PrehistoricPBJ
		/// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
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
            return "Prehistoric PB&J";
        }
    }
}
