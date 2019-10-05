using System;
using System.Collections.Generic;
using System.Text;
/*
 * Water.cs
 * Author: George Widenor
 * Description:
 */

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Defines the drink Water
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Gets and sets whether lemon will be added to the Water
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// Gets the ingredients list including lemon if added for the Water
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets and sets the size for the Water
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
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Small:
                        Price = 0.10;
                        Calories = 0;
                        break;
                }
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories, and make sure there is no lemon initially
        /// </summary>
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;
            this.Lemon = false;
        }

        /// <summary>
        /// Adds lemon to the Water
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }

        /// <summary>
        /// Gets TyrannoTea with the size
        /// </summary>
        /// <returns>"size" TyrannoTea</returns>
        public override string ToString()
        {
            switch (this.Size)
            {
                case Size.Large:
                    return "Large Water";
                case Size.Medium:
                    return "Medium Water";
                case Size.Small:
                    return "Small Water";
                default:
                    return "Error";
            }
        }
    }
}
