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

        private CretaceousCombo combo;

        private int home;

        public CustomizeSteakosaurusBurger(SteakosaurusBurger sb, int home)
        {
            InitializeComponent();
            this.sb = sb;
            this.home = home;
        }

        public CustomizeSteakosaurusBurger(CretaceousCombo combo, int home)
        {
            InitializeComponent();
            this.combo = combo;
            this.home = home;
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            if (sb != null)
            {
                sb.HoldBun();
            }
            else if (combo != null)
            {
                if (combo.Entree is SteakosaurusBurger sb)
                {
                    sb.HoldBun();
                    combo.Entree = sb;
                }
            }
        }

        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            if (sb != null)
            {
                sb.HoldPickle();
            }
            else if (combo != null)
            {
                if (combo.Entree is SteakosaurusBurger sb)
                {
                    sb.HoldPickle();
                    combo.Entree = sb;
                }
            }
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            if (sb != null)
            {
                sb.HoldKetchup();
            }
            else if (combo != null)
            {
                if (combo.Entree is SteakosaurusBurger sb)
                {
                    sb.HoldKetchup();
                    combo.Entree = sb;
                }
            }
        }

        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            if (sb != null)
            {
                sb.HoldMustard();
            }
            else if (combo != null)
            {
                if (combo.Entree is SteakosaurusBurger sb)
                {
                    sb.HoldMustard();
                    combo.Entree = sb;
                }
            }
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (home == 0)
            {
                NavigationService?.Navigate(new MenuCategorySelection());
            }
            else if (home == 1)
            {
                if (NavigationService.CanGoBack)
                {
                    NavigationService?.GoBack();
                }
                else
                {
                    NavigationService?.Navigate(new MenuCategorySelection());
                }
            }
            else if (home == 2)
            {
                if (combo != null)
                {
                    NavigationService?.Navigate(new CustomizeCombo(combo));
                }
            }
        }
    }
}
