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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        private CretaceousCombo combo;

        private Brontowurst bw = null;

        private int home;

        public CustomizeBrontowurst(Brontowurst bw, int home)
        {
            InitializeComponent();
            this.bw = bw;
            this.home = home;
        }

        public CustomizeBrontowurst(CretaceousCombo combo, int home)
        {
            InitializeComponent();
            this.combo = combo;
            this.home = home;
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            if (bw != null)
            {
                bw.HoldBun();
            }
            else if (combo != null)
            {
                if (combo.Entree is Brontowurst bw)
                {
                    bw.HoldBun();
                    combo.Entree = bw;
                }
            }
        }

        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            if (bw != null)
            {
                bw.HoldPeppers();
            }
            else if (combo != null)
            {
                if (combo.Entree is Brontowurst bw)
                {
                    bw.HoldPeppers();
                    combo.Entree = bw;
                }
            }
        }

        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            if (bw != null)
            {
                bw.HoldOnion();
            }
            else if (combo != null)
            {
                if (combo.Entree is Brontowurst bw)
                {
                    bw.HoldOnion();
                    combo.Entree = bw;
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
