using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
using DinoDiner.Menu.Entrees;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> category { get; set; } = new List<string>();

        [BindProperty]
        public double minPrice { get; set; } = 0;

        [BindProperty]
        public double maxPrice { get; set; } = 20;

        [BindProperty]
        public List<string> ingredients { get; set; } = new List<string>();

        public List<IMenuItem> Combos { get; set; }

        [BindProperty]
        public bool combo { get; set; } = true;

        public List<IMenuItem> Entrees { get; set; }

        [BindProperty]
        public bool entree { get; set; } = true;

        public List<IMenuItem> Sides { get; set; }

        [BindProperty]
        public bool side { get; set; } = true;

        [BindProperty]
        public List<IMenuItem> Drinks { get; set; }

        [BindProperty]
        public bool drink { get; set; } = true;

        public List<string> Ingredients { get; set; }

        public void OnGet()
        {
            Menu = new Menu();

            Combos = Menu.AvaliableCombos;
            Entrees = Menu.AvaliableEntrees;
            Sides = Menu.AvaliableSides;
            Drinks = Menu.AvaliableDrinks;
            Ingredients = Menu.PossibleIngredients;
        }

        public void OnPost(string search, List<string> category, double minPrice, double maxPrice, List<string> ingredients)
        {
            Menu = new Menu();

            Combos = Menu.AvaliableCombos;
            Entrees = Menu.AvaliableEntrees;
            Sides = Menu.AvaliableSides;
            Drinks = Menu.AvaliableDrinks;
            Ingredients = Menu.PossibleIngredients;

            if (search != null)
            {
                this.search = search;
                if (Combos != null)
                {
                    Combos = Menu.Search(Combos, search);
                }
                if (Entrees != null)
                {
                    Entrees = Menu.Search(Entrees, search);
                }
                if (Sides != null)
                {
                    Sides = Menu.Search(Sides, search);
                }
                if (Drinks != null)
                {
                    Drinks = Menu.Search(Drinks, search);
                }
            }

            if (category.Count > 0)
            {
                this.category = category;
                if (category.Contains("Combo"))
                {
                    combo = true;
                } else
                {
                    combo = false;
                }
                if (category.Contains("Entree"))
                {
                    entree = true;
                } else
                {
                    entree = false;
                }
                if (category.Contains("Side"))
                {
                    side = true;
                } else
                {
                    side = false;
                }
                if (category.Contains("Drink"))
                {
                    drink = true;
                } else
                {
                    drink = false;
                }
            }

            this.minPrice = minPrice;
            Combos = Menu.FilterByMinPrice(Combos, minPrice);
            Entrees = Menu.FilterByMinPrice(Entrees, minPrice);
            Sides = Menu.FilterByMinPrice(Sides, minPrice);
            Drinks = Menu.FilterByMinPrice(Drinks, minPrice);


            this.maxPrice = maxPrice;
            Combos = Menu.FilterByMaxPrice(Combos, maxPrice);
            Entrees = Menu.FilterByMaxPrice(Entrees, maxPrice);
            Sides = Menu.FilterByMaxPrice(Sides, maxPrice);
            Drinks = Menu.FilterByMaxPrice(Drinks, maxPrice);

            if (ingredients.Count > 0)
            {
                this.ingredients = ingredients;
                Combos = Menu.FilterByIngredients(Combos, ingredients);
                Entrees = Menu.FilterByIngredients(Entrees, ingredients);
                Sides = Menu.FilterByIngredients(Sides, ingredients);
                Drinks = Menu.FilterByIngredients(Drinks, ingredients);
            }
        }
    }
}