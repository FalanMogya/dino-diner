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

        private CretaceousCombo combo;

        private int home;

        public CustomizeTRexKingBurger(TRexKingBurger trex, int home)
        {
            InitializeComponent();
            this.trex = trex;
            this.home = home;
        }

        public CustomizeTRexKingBurger(CretaceousCombo combo, int home)
        {
            InitializeComponent();
            this.combo = combo;
            this.home = home;
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            if (trex != null)
            {
                trex.HoldBun();
            }
            else if (combo != null)
            {
                if (combo.Entree is TRexKingBurger trex)
                {
                    trex.HoldBun();
                    combo.Entree = trex;
                }
            }
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            if (trex != null)
            {
                trex.HoldLettuce();
            }
            else if (combo != null)
            {
                if (combo.Entree is TRexKingBurger trex)
                {
                    trex.HoldLettuce();
                    combo.Entree = trex;
                }
            }
        }

        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            if (trex != null)
            {
                trex.HoldTomato();
            }
            else if (combo != null)
            {
                if (combo.Entree is TRexKingBurger trex)
                {
                    trex.HoldTomato();
                    combo.Entree = trex;
                }
            }
        }

        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            if (trex != null)
            {
                trex.HoldOnion();
            }
            else if (combo != null)
            {
                if (combo.Entree is TRexKingBurger trex)
                {
                    trex.HoldOnion();
                    combo.Entree = trex;
                }
            }
        }

        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            if (trex != null)
            {
                trex.HoldPickle();
            }
            else if (combo != null)
            {
                if (combo.Entree is TRexKingBurger trex)
                {
                    trex.HoldPickle();
                    combo.Entree = trex;
                }
            }
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            if (trex != null)
            {
                trex.HoldKetchup();
            }
            else if (combo != null)
            {
                if (combo.Entree is TRexKingBurger trex)
                {
                    trex.HoldKetchup();
                    combo.Entree = trex;
                }
            }
        }

        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            if (trex != null)
            {
                trex.HoldMustard();
            }
            else if (combo != null)
            {
                if (combo.Entree is TRexKingBurger trex)
                {
                    trex.HoldMustard();
                    combo.Entree = trex;
                }
            }
        }

        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            if (trex != null)
            {
                trex.HoldMayo();
            }
            else if (combo != null)
            {
                if (combo.Entree is TRexKingBurger trex)
                {
                    trex.HoldMayo();
                    combo.Entree = trex;
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
