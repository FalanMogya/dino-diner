using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

/*
 * Fryceritops.cs
 * Author: George Widenor
 * Description: Defines the side Fryceritops with a price, calories, a ingredients list, and a size
 */

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Defines the side Fryceritops
    /// </summary>
    public class Fryceritops : Side, IOrderItem, INotifyPropertyChanged
    {
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
                return special.ToArray();
            }
        }

        /// <summary>
        /// Get the ingredients list for Fryceritops
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        }

        private Size size;

        /// <summary>
        /// Gets or sets the size for the Fryceritops
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                }
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Description");
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories for the Fryceritops
        /// </summary>
        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
        }

        /// <summary>
        /// Returns the side identity string
        /// </summary>
        /// <returns>The side as a string</returns>
        public override string ToString()
        {
            return $"{Size} Fryceritops";
        }
    }
}
