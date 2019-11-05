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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        private VelociWrap vw;

        private CretaceousCombo combo;

        private int home;

        public CustomizeVelociWrap(VelociWrap vw, int home)
        {
            InitializeComponent();
            this.vw = vw;
            this.home = home;
        }

        public CustomizeVelociWrap(CretaceousCombo combo, int home)
        {
            InitializeComponent();
            this.combo = combo;
            this.home = home;
        }

        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            if (vw != null)
            {
                vw.HoldDressing();
            }
            else if (combo != null)
            {
                if (combo.Entree is VelociWrap vw)
                {
                    vw.HoldDressing();
                    combo.Entree = vw;
                }
            }
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            if (vw != null)
            {
                vw.HoldLettuce();
            }
            else if (combo != null)
            {
                if (combo.Entree is VelociWrap vw)
                {
                    vw.HoldLettuce();
                    combo.Entree = vw;
                }
            }
        }

        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            if (vw != null)
            {
                vw.HoldCheese();
            }
            else if (combo != null)
            {
                if (combo.Entree is VelociWrap vw)
                {
                    vw.HoldCheese();
                    combo.Entree = vw;
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
