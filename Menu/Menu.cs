using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    public class Menu
    {
        public List<IMenuItem> AvaliableMenuItems
        {
            get
            {
                List<IMenuItem> avaliable = new List<IMenuItem>();
                avaliable.Add(new JurassicJava());
                avaliable.Add(new Sodasaurus());
                avaliable.Add(new Tyrannotea());
                avaliable.Add(new Water());
                avaliable.Add(new Brontowurst());
                avaliable.Add(new DinoNuggets());
                avaliable.Add(new PrehistoricPBJ());
                avaliable.Add(new PterodactylWings());
                avaliable.Add(new SteakosaurusBurger());
                avaliable.Add(new TRexKingBurger());
                avaliable.Add(new VelociWrap());
                avaliable.Add(new Fryceritops());
                avaliable.Add(new MeteorMacAndCheese());
                avaliable.Add(new MezzorellaSticks());
                avaliable.Add(new Triceritots());
                avaliable.Add(new CretaceousCombo(new Brontowurst()));
                avaliable.Add(new CretaceousCombo(new DinoNuggets()));
                avaliable.Add(new CretaceousCombo(new PrehistoricPBJ()));
                avaliable.Add(new CretaceousCombo(new PterodactylWings()));
                avaliable.Add(new CretaceousCombo(new SteakosaurusBurger()));
                avaliable.Add(new CretaceousCombo(new TRexKingBurger()));
                avaliable.Add(new CretaceousCombo(new VelociWrap()));
                return avaliable;
            }
        }

        public List<IMenuItem> AvaliableEntrees
        {
            get
            {
                List<IMenuItem> avaliable = new List<IMenuItem>();
                avaliable.Add(new Brontowurst());
                avaliable.Add(new DinoNuggets());
                avaliable.Add(new PrehistoricPBJ());
                avaliable.Add(new PterodactylWings());
                avaliable.Add(new SteakosaurusBurger());
                avaliable.Add(new TRexKingBurger());
                avaliable.Add(new VelociWrap());
                return avaliable;
            }
        }

        public List<IMenuItem> AvaliableSides
        {
            get
            {
                List<IMenuItem> avaliable = new List<IMenuItem>();
                avaliable.Add(new Fryceritops());
                avaliable.Add(new MeteorMacAndCheese());
                avaliable.Add(new MezzorellaSticks());
                avaliable.Add(new Triceritots());
                return avaliable;
            }
        }

        public List<IMenuItem> AvaliableDrinks
        {
            get
            {
                List<IMenuItem> avaliable = new List<IMenuItem>();
                avaliable.Add(new JurassicJava());
                avaliable.Add(new Sodasaurus());
                avaliable.Add(new Tyrannotea());
                avaliable.Add(new Water());
                return avaliable;
            }
        }

        public List<IMenuItem> AvaliableCombos
        {
            get
            {
                List<IMenuItem> avaliable = new List<IMenuItem>();
                avaliable.Add(new CretaceousCombo(new Brontowurst()));
                avaliable.Add(new CretaceousCombo(new DinoNuggets()));
                avaliable.Add(new CretaceousCombo(new PrehistoricPBJ()));
                avaliable.Add(new CretaceousCombo(new PterodactylWings()));
                avaliable.Add(new CretaceousCombo(new SteakosaurusBurger()));
                avaliable.Add(new CretaceousCombo(new TRexKingBurger()));
                avaliable.Add(new CretaceousCombo(new VelociWrap()));
                return avaliable;
            }
        }

        public List<string> PossibleIngredients
        {
            get
            {
                List<string> avaliable = new List<string>();
                foreach (string ingredients in new Brontowurst().Ingredients)
                {
                    if (!avaliable.Contains(ingredients))
                    {
                        avaliable.Add(ingredients);
                    }
                }
                foreach (string ingredients in new DinoNuggets().Ingredients)
                {
                    if (!avaliable.Contains(ingredients))
                    {
                        avaliable.Add(ingredients);
                    }
                }
                foreach (string ingredients in new PrehistoricPBJ().Ingredients)
                {
                    if (!avaliable.Contains(ingredients))
                    {
                        avaliable.Add(ingredients);
                    }
                }
                foreach (string ingredients in new PterodactylWings().Ingredients)
                {
                    if (!avaliable.Contains(ingredients))
                    {
                        avaliable.Add(ingredients);
                    }
                }
                foreach (string ingredients in new SteakosaurusBurger().Ingredients)
                {
                    if (!avaliable.Contains(ingredients))
                    {
                        avaliable.Add(ingredients);
                    }
                }
                foreach (string ingredients in new TRexKingBurger().Ingredients)
                {
                    if (!avaliable.Contains(ingredients))
                    {
                        avaliable.Add(ingredients);
                    }
                }
                foreach (string ingredients in new Fryceritops().Ingredients)
                {
                    if (!avaliable.Contains(ingredients))
                    {
                        avaliable.Add(ingredients);
                    }
                }
                foreach (string ingredients in new MeteorMacAndCheese().Ingredients)
                {
                    if (!avaliable.Contains(ingredients))
                    {
                        avaliable.Add(ingredients);
                    }
                }
                foreach (string ingredients in new MezzorellaSticks().Ingredients)
                {
                    if (!avaliable.Contains(ingredients))
                    {
                        avaliable.Add(ingredients);
                    }
                }
                foreach (string ingredients in new Triceritots().Ingredients)
                {
                    if (!avaliable.Contains(ingredients))
                    {
                        avaliable.Add(ingredients);
                    }
                }
                foreach (string ingredients in new PterodactylWings().Ingredients)
                {
                    if (!avaliable.Contains(ingredients))
                    {
                        avaliable.Add(ingredients);
                    }
                }
                foreach (string ingredients in new JurassicJava().Ingredients)
                {
                    if (!avaliable.Contains(ingredients)) {
                        avaliable.Add(ingredients);
                    }
                }
                foreach (string ingredients in new Sodasaurus().Ingredients)
                {
                    if (!avaliable.Contains(ingredients))
                    {
                        avaliable.Add(ingredients);
                    }
                }
                foreach (string ingredients in new Tyrannotea().Ingredients)
                {
                    if (!avaliable.Contains(ingredients))
                    {
                        avaliable.Add(ingredients);
                    }
                }
                foreach (string ingredients in new Water().Ingredients)
                {
                    if (!avaliable.Contains(ingredients))
                    {
                        avaliable.Add(ingredients);
                    }
                }
                return avaliable;
            }
        }

        public static List<IMenuItem> Search(List<IMenuItem> menu, string searchString)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IOrderItem item in menu)
            {
                if (item.Description.ToLower().Contains(searchString.ToLower()))
                {
                    results.Add((IMenuItem)item);
                }
            }

            return results;
        }

        public static List<IMenuItem> FilterByMinPrice(List<IMenuItem> menu, double minPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in menu)
            {
                if (minPrice <= item.Price)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        public static List<IMenuItem> FilterByMaxPrice(List<IMenuItem> menu, double maxPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in menu)
            {
                if (maxPrice >= item.Price)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        public static List<IMenuItem> FilterByIngredients(List<IMenuItem> menu, List<string> ingredients)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            bool good;

            foreach (IMenuItem item in menu)
            {
                good = true;

                foreach (string ingredient in ingredients)
                {
                    if (item.Ingredients.Contains(ingredient))
                    {
                        good = false;
                    }
                }

                if (good)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < AvaliableMenuItems.Count; i++)
            {
                str += AvaliableMenuItems[i].ToString() + "\n";
            }

            return str;
        }
    }
}
