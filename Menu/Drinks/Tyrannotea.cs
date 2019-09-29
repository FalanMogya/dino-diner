using System;
using System.Collections.Generic;
using System.Text;

/*
 * Tyrannotea.cs
 * Author: George Widenor
 * Description: Defines the drink Tyrannotea with a price, calories, sweetener, lemon, ingredients list, and size 
 */

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Defines the drink Tyrannotea
    /// </summary>
    public class Tyrannotea : Drink
    {
        private bool sweet = false;

        /// <summary>
        /// Gets and sets whether the Tyrannotea will be sweetened
        /// </summary>
        public bool Sweet {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                switch (size)
                {
                    case Size.Large:
                        if (Sweet)
                        {
                            Calories = 64;
                        }
                        else
                        {
                            Calories = 32;
                        }
                        break;
                    case Size.Medium:
                        if (Sweet)
                        {
                            Calories = 32;
                        }
                        else
                        {
                            Calories = 16;
                        }
                        break;
                    case Size.Small:
                        if (Sweet)
                        {
                            Calories = 16;
                        }
                        else
                        {
                            Calories = 8;
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Gets and sets whether lemon will be added to the Tyrannotea
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// Gets the ingredients list including sugar and lemon if they are added for the Tyrannotea
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (Lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets and sets the size for the Tyrannotea
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
                        Price = 1.99;
                        if (Sweet)
                        {
                            Calories = 64;
                        } else
                        {
                            Calories = 32;
                        }
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        if (Sweet)
                        {
                            Calories = 32;
                        } else
                        {
                            Calories = 16;
                        }
                        break;
                    case Size.Small:
                        Price = 0.99;
                        if (Sweet)
                        {
                            Calories = 16;
                        } else
                        {
                            Calories = 8;
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories, and makes sure there is no lemon or sweetener initially for the Tyrannotea
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
            this.Lemon = false;
        }

        /// <summary>
        /// Adds lemon to the Tyrannotea
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }
    }
}
