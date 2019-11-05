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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        private PrehistoricPBJ pbj;

        private CretaceousCombo combo;

        private int home;

        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj, int home)
        {
            InitializeComponent();
            this.pbj = pbj;
            this.home = home;
        }

        public CustomizePrehistoricPBJ(CretaceousCombo combo, int home)
        {
            InitializeComponent();
            this.combo = combo;
            this.home = home;
        }

        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            if (pbj != null)
            {
                pbj.HoldPeanutButter();
            }
            else if (combo != null)
            {
                if (combo.Entree is PrehistoricPBJ pbj)
                {
                    pbj.HoldPeanutButter();
                    combo.Entree = pbj;
                }
            }
        }

        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            if (pbj != null)
            {
                pbj.HoldJelly();
            }
            else if (combo != null)
            {
                if (combo.Entree is PrehistoricPBJ pbj)
                {
                    pbj.HoldJelly();
                    combo.Entree = pbj;
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
