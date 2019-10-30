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

        public Drink Drink { get; set; } = new Sodasaurus();

        public Side Side { get; set; } = new Fryceritops();

        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            Combo = combo;
        }

        public CustomizeCombo(CretaceousCombo combo, Drink drink, Side side)
        {
            InitializeComponent();
            Combo = combo;
            Drink = drink;
            Side = side;
        }

        private void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        private void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }
    }
}
