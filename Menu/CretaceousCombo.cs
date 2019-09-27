using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        public Entree Entree { get; set; }
        public Side Side { get; set; }
        public Drink Drink { get; set; }

        private Size size = Size.Small;

        public Size Size {
            get
            {
                return size;
            }
            set
            {
                size = value;
                Side.Size = value;
                Drink.Size = value;
            }
        }

        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        public override string ToString()
        {
            return $"";
        }

        private CretaceousCombo() { }

        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            //Side = new Fryceritops();
            //Drink = new Sodasaurus();
        }
    }
}
