using System.Collections.Generic;
using System.ComponentModel;

/*
 * JurassicJava.cs
 * Author: George Widenor
 * Description: Defines the drink JurassicJava with a price, calories, room for cream, decaf, ingredients list, size, and ice
 */

namespace DinoDiner.Menu.Drinks

{
    /// <summary>
    /// Defines the drink JurassicJava
    /// </summary>
    public class JurassicJava : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The PropertyChanged event handler; notifies of canges to the Price,
        /// Description, and Special properties
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

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
                if (Ice) special.Add("Add Ice");
                if (RoomForCream) special.Add("Room For Cream");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Gets or sets whether the JurassicJava will have room for cream
        /// </summary>
        public bool RoomForCream { get; set; }

        private bool decaf;

        /// <summary>
        /// Gets or sets whether the JurassicJava will be decaf
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Gets the ingredients list for JurassicJava
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }

        /// <summary>
        /// Gets and set the size for the JurassicJava
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Small:
                        Price = 0.49;
                        Calories = 2;
                        break;
                }
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories, and make sure there is no ice, no room for cream, and it's not decaf initially for the JurassicJava
        /// </summary>
        public JurassicJava()
        {
            this.Price = 0.49;
            this.Calories = 2;
            this.Ice = false;
            this.RoomForCream = false;
            this.Decaf = false;
        }

        /// <summary>
        /// Leaves room for cream for the JurassicJava
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Adds Ice to the JurassicJava
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Returns the drink identity string
        /// </summary>
        /// <returns>The drink as a string</returns>
        public override string ToString()
        {
            if (this.Decaf)
            {
                return $"{Size} Decaf Jurassic Java";
            }
            else
            {
                return $"{Size} Jurassic Java";
            }
        }
    }
}
