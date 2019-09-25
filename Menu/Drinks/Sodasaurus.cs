using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        public SodasaurusFlavor Flavor { get; set; }

        private Size size = Size.Small;

        public Size Size
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
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        break;
                    case Size.Small:
                        Price = 1.50;
                        break;
                }
            }
        }

        public double Price { get; set; }

        public Sodasaurus()
        {
            this.Size = Size.Small;
            this.Price = 1.50;
        }

    }
}
