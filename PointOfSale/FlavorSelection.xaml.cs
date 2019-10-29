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
        public Sodasaurus Soda { get; set; }

        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            Soda = soda;
        }

        private void SelectFlavor(SodasaurusFlavor flavor)
        {
            if (Soda != null)
            {
                this.Soda.Flavor = flavor;
                NavigationService?.Navigate(new DrinkSelection(Soda));
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
