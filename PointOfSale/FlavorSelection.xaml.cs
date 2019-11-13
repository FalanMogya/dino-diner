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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public CretaceousCombo Combo { get; set; }

        public Sodasaurus Soda { get; set; }

        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            Soda = soda;
        }

        public FlavorSelection(CretaceousCombo combo, Sodasaurus soda)
        {
            InitializeComponent();
            Combo = combo;
            Soda = soda;
        }

        private void SelectFlavor(SodasaurusFlavor flavor)
        {
            if (Soda != null)
            {
                this.Soda.Flavor = flavor;
                if (Combo != null)
                {
                    NavigationService?.Navigate(new DrinkSelection(Combo, Soda, 2));
                }
                else
                {
                    NavigationService?.Navigate(new DrinkSelection(Soda, 0));
                }
            }
        }

        protected void OnMakeCherry(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Cherry);
        }

        protected void OnMakeChocolate(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Chocolate);
        }

        protected void OnMakeCola(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Cola);
        }

        protected void OnMakeLime(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Lime);
        }

        protected void OnMakeOrange(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Orange);
        }

        protected void OnMakeRootBeer(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.RootBeer);
        }

        protected void OnMakeVanilla(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Vanilla);
        }
    }
}
