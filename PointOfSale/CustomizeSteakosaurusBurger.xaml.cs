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
using DinoDiner.Menu.Entrees;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        private SteakosaurusBurger sb;

        private int home;

        public CustomizeSteakosaurusBurger(SteakosaurusBurger sb, int home)
        {
            InitializeComponent();
            this.sb = sb;
            this.home = home;
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            sb.HoldBun();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            sb.HoldPickle();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            sb.HoldKetchup();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            sb.HoldMustard();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (home == 0)
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else if (home == 1)
            {
                if (NavigationService.CanGoBack)
                {
                    NavigationService.GoBack();
                }
                else
                {
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
            else if (home == 2)
            {
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
    }
}
