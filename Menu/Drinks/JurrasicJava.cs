using System;
using System.Collections.Generic;
using System.Text;

/*
 * JurrasicJava.cs
 * Author: George Widenor
 * Description: Defines the drink JurrasicJava with a price, calories, room for cream, decaf, ingredients list, size, and ice
 */

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Defines the drink JurrasicJava
    /// </summary>
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Gets or sets whether the JurrasicJava will have room for cream
        /// </summary>
        public bool RoomForCream { get; set; }

        /// <summary>
        /// Gets or sets whether the JurrasicJava will be decaf
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// Gets the ingredients list for JurrasicJava
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }

        /// <summary>
        /// Gets and set the size for the JurrasicJava
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
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories, and make sure there is no ice, no room for cream, and it's not decaf initially for the JurrassicJava
        /// </summary>
        public JurrasicJava()
        {
            this.Price = 0.49;
            this.Calories = 2;
            this.Ice = false;
            this.RoomForCream = false;
            this.Decaf = false;
        }

        /// <summary>
        /// Leaves room for cream for the JurrassicJava
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }

        /// <summary>
        /// Adds Ice to the JurrassicJava
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }

        /// <summary>
        /// Gets the name Jurrassic Java
        /// </summary>
        /// <returns>The name Jurrassic Java</returns>
        public override string ToString()
        {
            return "Jurrassic Java";
        }
    }
}
