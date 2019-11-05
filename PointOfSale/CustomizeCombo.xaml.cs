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
using DinoDiner.Menu.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        public CretaceousCombo Combo { get; set; }

        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            Combo = combo;
        }

        public CustomizeCombo(CretaceousCombo combo, Drink drink, Side side)
        {
            InitializeComponent();
            Combo = combo;
            Combo.Drink = drink;
            Combo.Side = side;
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Combo != null)
            {
                this.Combo.Size = size;
                NavigationService?.Navigate(new MenuCategorySelection());
            }
        }

        private void SelectDrink(object sender, RoutedEventArgs args)
        {
            if (Combo != null)
            {
                NavigationService?.Navigate(new DrinkSelection(Combo, 2));
            }
        }

        private void SelectSide(object sender, RoutedEventArgs args)
        {
            if (Combo != null)
            {
                NavigationService?.Navigate(new SideSelection(Combo, 2));
            }
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
    }
}
