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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        private TRexKingBurger trex;

        private int home;

        public CustomizeTRexKingBurger(TRexKingBurger trex, int home)
        {
            InitializeComponent();
            this.trex = trex;
            this.home = home;
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            trex.HoldBun();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            trex.HoldLettuce();
        }

        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            trex.HoldTomato();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            trex.HoldOnion();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            trex.HoldPickle();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            trex.HoldKetchup();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            trex.HoldMustard();
        }

        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            trex.HoldMayo();
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
