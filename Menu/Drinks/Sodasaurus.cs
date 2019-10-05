using System;
using System.Collections.Generic;
using System.Text;

/*  
 * Sodasaurus.cs
 * Author: George Widenor
 * Description: Defines the drink Sodasaurus with a price, calories, flavor, ingredients list, and size
 */

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Defines the drink Sodasaurus
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Gets and sets the flavor for the Sodasaurus
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

        /// <summary>
        /// Gets the ingredients list for the Sodasaurus
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
                return ingredients;
            }
        }

        /// <summary>
        /// Gets and sets the size for the Sodasaurus
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
                        Price = 2.50;
                        Calories = 208;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                }
            }
        }

        /// <summary>
        /// Sets the appropriate price and calories for the Sodasaurus
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
        }

        /// <summary>
        /// Gets Sodasaurus with the flavor and size
        /// </summary>
        /// <returns>"size" "flavor" Sodasaurus</returns>
        public override string ToString()
        {
            switch (this.Flavor)
            {
                case SodasaurusFlavor.Cola:
                    switch (this.Size)
                    {
                        case Size.Large:
                            return "Large Cola Sodasaurus";
                        case Size.Medium:
                            return "Medium Cola Sodasaurus";
                        case Size.Small:
                            return "Small Cola Sodasaurus";
                        default:
                            return "Error";
                    }
                case SodasaurusFlavor.Orange:
                    switch (this.Size)
                    {
                        case Size.Large:
                            return "Large Orange Sodasaurus";
                        case Size.Medium:
                            return "Medium Orange Sodasaurus";
                        case Size.Small:
                            return "Small Orange Sodasaurus";
                        default:
                            return "Error";
                    }
                case SodasaurusFlavor.Vanilla:
                    switch (this.Size)
                    {
                        case Size.Large:
                            return "Large Vanilla Sodasaurus";
                        case Size.Medium:
                            return "Medium Vanilla Sodasaurus";
                        case Size.Small:
                            return "Small Vanilla Sodasaurus";
                        default:
                            return "Error";
                    }
                case SodasaurusFlavor.Chocolate:
                    switch (this.Size)
                    {
                        case Size.Large:
                            return "Large Chocolate Sodasaurus";
                        case Size.Medium:
                            return "Medium Chocolate Sodasaurus";
                        case Size.Small:
                            return "Small Chocolate Sodasaurus";
                        default:
                            return "Error";
                    }
                case SodasaurusFlavor.RootBeer:
                    switch (this.Size)
                    {
                        case Size.Large:
                            return "Large RootBeer Sodasaurus";
                        case Size.Medium:
                            return "Medium RootBeer Sodasaurus";
                        case Size.Small:
                            return "Small RootBeer Sodasaurus";
                        default:
                            return "Error";
                    }
                case SodasaurusFlavor.Cherry:
                    switch (this.Size)
                    {
                        case Size.Large:
                            return "Large Cherry Sodasaurus";
                        case Size.Medium:
                            return "Medium Cherry Sodasaurus";
                        case Size.Small:
                            return "Small Cherry Sodasaurus";
                        default:
                            return "Error";
                    }
                case SodasaurusFlavor.Lime:
                    switch (this.Size)
                    {
                        case Size.Large:
                            return "Large Lime Sodasaurus";
                        case Size.Medium:
                            return "Medium Lime Sodasaurus";
                        case Size.Small:
                            return "Small Lime Sodasaurus";
                        default:
                            return "Error";
                    }
                default:
                    return "Error";
            }
        }
    }
}
