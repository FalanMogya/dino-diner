using System.Collections.Generic;

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
    public class JurassicJava : Drink
    {
        /// <summary>
        /// Gets or sets whether the JurassicJava will have room for cream
        /// </summary>
        public bool RoomForCream { get; set; }

        /// <summary>
        /// Gets or sets whether the JurassicJava will be decaf
        /// </summary>
        public bool Decaf { get; set; }

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
        }

        /// <summary>
        /// Adds Ice to the JurassicJava
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }

        /// <summary>
        /// Gets Jurrassic Java with the decaf and size
        /// </summary>
        /// <returns>"decaf" "size" Jurassic Java</returns>
        public override string ToString()
        {
            if (this.Decaf)
            {
                switch (this.Size)
                {
                    case Size.Large:
                        return "Large Decaf Jurassic Java";
                    case Size.Medium:
                        return "Medium Decaf Jurassic Java";
                    case Size.Small:
                        return "Small Decaf Jurassic Java";
                    default:
                        return "Error";
                }
            }
            else
            {
                switch (this.Size)
                {
                    case Size.Large:
                        return "Large Jurassic Java";
                    case Size.Medium:
                        return "Medium Jurassic Java";
                    case Size.Small:
                        return "Small Jurassic Java";
                    default:
                        return "Error";
                }
            }
        }
    }
}
