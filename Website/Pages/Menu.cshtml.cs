using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;

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

        public IEnumerable<IMenuItem> MenuItems { get; set; }

        public IEnumerable<IMenuItem> Combos { get; set; }

        public IEnumerable<IMenuItem> Entrees { get; set; }

        public IEnumerable<IMenuItem> Sides { get; set; }

        public IEnumerable<IMenuItem> Drinks { get; set; }

        public IEnumerable<string> Ingredients { get; set; }

        public void OnGet()
        {
            Menu = new Menu();
            MenuItems = Menu.AvaliableMenuItems.OfType<IMenuItem>();
            Combos = MenuItems.OfType<CretaceousCombo>();
            Entrees = MenuItems.OfType<Entree>();
            Sides = MenuItems.OfType<Side>();
            Drinks = MenuItems.OfType<Drink>();
            Ingredients = Menu.PossibleIngredients;
        }

        public void OnPost(string search, List<string> category, double minPrice, double maxPrice, List<string> ingredients)
        {
            Menu = new Menu();

            MenuItems = Menu.AvaliableMenuItems.OfType<IMenuItem>();
            Ingredients = Menu.PossibleIngredients;

            if (search != null)
            {
                this.search = search;
                MenuItems = MenuItems.OfType<IOrderItem>().Where(item => item.Description.ToLower().Contains(search.ToLower())).OfType<IMenuItem>();
            }

            this.minPrice = minPrice;
            MenuItems = MenuItems.Where(item => item.Price >= minPrice);


            this.maxPrice = maxPrice;
            MenuItems = MenuItems.Where(item => item.Price <= maxPrice);

            if (ingredients.Count > 0)
            {
                this.ingredients = ingredients;
                foreach (string ingredient in ingredients)
                {
                    MenuItems = MenuItems.Where(item => !item.Ingredients.Contains(ingredient));
                }
            }

            if (category.Count > 0)
            {
                this.category = category;
                if (category.Contains("Combo"))
                {
                    Combos = MenuItems.OfType<CretaceousCombo>();
                }
                if (category.Contains("Entree"))
                {
                    Entrees = MenuItems.OfType<Entree>();
                }
                if (category.Contains("Side"))
                {
                    Sides = MenuItems.OfType<Side>();
                }
                if (category.Contains("Drink"))
                {
                    Drinks = MenuItems.OfType<Drink>();
                }
            }
            else
            {
                Combos = MenuItems.OfType<CretaceousCombo>();
                Entrees = MenuItems.OfType<Entree>();
                Sides = MenuItems.OfType<Side>();
                Drinks = MenuItems.OfType<Drink>();
            }
        }
    }
}