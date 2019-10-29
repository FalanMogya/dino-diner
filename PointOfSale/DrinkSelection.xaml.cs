using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public Drink Drink { get; set; }

        public DrinkSelection()
        {
            InitializeComponent();
            BtnAddSoda.IsEnabled = true;
            BtnAddTea.IsEnabled = true;
            BtnAddJava.IsEnabled = true;
            BtnAddWater.IsEnabled = true;
            BtnPickSmall.IsEnabled = false;
            BtnPickMedium.IsEnabled = false;
            BtnPickLarge.IsEnabled = false;
            BtnFlavor.Visibility = Visibility.Hidden;
            BtnFlavor.IsEnabled = false;
            BtnDecaf.Visibility = Visibility.Hidden;
            BtnDecaf.IsEnabled = false;
            BtnSweet.Visibility = Visibility.Hidden;
            BtnSweet.IsEnabled = false;
            BtnLemon.IsEnabled = false;
            BtnHoldIce.IsEnabled = false;
            BtnAddIce.Visibility = Visibility.Hidden;
            BtnAddIce.IsEnabled = false;
        }

        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
            BtnAddSoda.IsEnabled = false;
            BtnAddTea.IsEnabled = false;
            BtnAddJava.IsEnabled = false;
            BtnAddWater.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
            BtnFlavor.Visibility = Visibility.Hidden;
            BtnFlavor.IsEnabled = false;
            BtnDecaf.Visibility = Visibility.Hidden;
            BtnDecaf.IsEnabled = false;
            BtnSweet.Visibility = Visibility.Hidden;
            BtnSweet.IsEnabled = false;
            BtnLemon.IsEnabled = false;
            BtnHoldIce.IsEnabled = false;
            BtnAddIce.Visibility = Visibility.Hidden;
            BtnAddIce.IsEnabled = false;

            if (drink is Sodasaurus)
            {
                BtnFlavor.Visibility = Visibility.Visible;
                BtnFlavor.IsEnabled = true;
                BtnHoldIce.IsEnabled = true;
            }
            else if (drink is Tyrannotea)
            {
                BtnSweet.Visibility = Visibility.Visible;
                BtnSweet.IsEnabled = true;
                BtnLemon.IsEnabled = true;
                BtnHoldIce.IsEnabled = true;
            }
            else if (drink is JurassicJava)
            {
                BtnDecaf.Visibility = Visibility.Visible;
                BtnDecaf.IsEnabled = true;
                BtnHoldIce.Visibility = Visibility.Hidden;
                BtnAddIce.Visibility = Visibility.Visible;
                BtnAddIce.IsEnabled = true;
            }
            else if (drink is Water)
            {
                BtnLemon.IsEnabled = true;
                BtnHoldIce.IsEnabled = true;
            }
        }

        private void SelectDrink(Drink drink)
        {
            if (DataContext is Order order)
            {
                order.Add(drink);
                this.Drink = drink;
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
            {
                this.Drink.Size = size;
                NavigationService?.Navigate(new MenuCategorySelection());
            }
        }
        
        protected void AddSoda(object sender, RoutedEventArgs args)
        {
            SelectDrink(new Sodasaurus());
            BtnAddSoda.IsEnabled = false;
            BtnAddTea.IsEnabled = false;
            BtnAddJava.IsEnabled = false;
            BtnAddWater.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
            BtnFlavor.Visibility = Visibility.Visible;
            BtnFlavor.IsEnabled = true;
            BtnHoldIce.IsEnabled = true;
        }

        protected void AddTea(object sender, RoutedEventArgs args)
        {
            SelectDrink(new Tyrannotea());
            BtnAddSoda.IsEnabled = false;
            BtnAddTea.IsEnabled = false;
            BtnAddJava.IsEnabled = false;
            BtnAddWater.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
            BtnSweet.Visibility = Visibility.Visible;
            BtnSweet.IsEnabled = true;
            BtnLemon.IsEnabled = true;
            BtnHoldIce.IsEnabled = true;
        }

        protected void AddJava(object sender, RoutedEventArgs args)
        {
            SelectDrink(new JurassicJava());
            BtnAddSoda.IsEnabled = false;
            BtnAddTea.IsEnabled = false;
            BtnAddJava.IsEnabled = false;
            BtnAddWater.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
            BtnDecaf.Visibility = Visibility.Visible;
            BtnDecaf.IsEnabled = true;
            BtnHoldIce.Visibility = Visibility.Hidden;
            BtnAddIce.Visibility = Visibility.Visible;
            BtnAddIce.IsEnabled = true;
        }

        protected void AddWater(object sender, RoutedEventArgs args)
        {
            SelectDrink(new Water());
            BtnAddSoda.IsEnabled = false;
            BtnAddTea.IsEnabled = false;
            BtnAddJava.IsEnabled = false;
            BtnAddWater.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
            BtnLemon.IsEnabled = true;
            BtnHoldIce.IsEnabled = true;
        }

        protected void OnMakeLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        protected void OnMakeMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        protected void OnMakeSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        protected void FlavorSelect(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                NavigationService.Navigate(new FlavorSelection(soda));
            }
        }

        protected void MakeDecaf(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava java)
            {
                if (java.Decaf)
                {
                    java.Decaf = false;
                }
                else
                {
                    java.Decaf = true;
                }
            }
        }

        protected void MakeSweet(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea tea)
            {
                if (tea.Sweet)
                {
                    tea.Sweet = false;
                }
                else
                {
                    tea.Sweet = true;
                }
            }
        }

        protected void AddLemon(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea tea)
            {
                tea.AddLemon();
                BtnLemon.IsEnabled = false;
            }
            else if (Drink is Water water)
            {
                water.AddLemon();
                BtnLemon.IsEnabled = false;
            }
        }

        protected void HoldIce(object sender, RoutedEventArgs args)
        {
            Drink.HoldIce();
            BtnHoldIce.IsEnabled = false;
        }

        protected void AddIce(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava java)
            {
                java.AddIce();
                BtnAddIce.IsEnabled = false;
            }
        }
    }
}
