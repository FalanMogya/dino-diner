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
using DinoDiner.Menu.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private CretaceousCombo combo;

        public Side Side { get; set; }

        private int home = 0;

        public SideSelection()
        {
            InitializeComponent();
            BtnAddFries.IsEnabled = true;
            BtnAddMMC.IsEnabled = true;
            BtnAddMS.IsEnabled = true;
            BtnAddTots.IsEnabled = true;
            BtnPickSmall.IsEnabled = false;
            BtnPickMedium.IsEnabled = false;
            BtnPickLarge.IsEnabled = false;
        }

        public SideSelection(Side side, int home)
        {
            InitializeComponent();
            Side = side;
            this.home = home;
            BtnAddFries.IsEnabled = false;
            BtnAddMMC.IsEnabled = false;
            BtnAddMS.IsEnabled = false;
            BtnAddTots.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
        }

        public SideSelection(CretaceousCombo combo, int home)
        {
            InitializeComponent();
            this.combo = combo;
            this.home = home;
            BtnAddFries.IsEnabled = true;
            BtnAddMMC.IsEnabled = true;
            BtnAddMS.IsEnabled = true;
            BtnAddTots.IsEnabled = true;
            BtnPickSmall.IsEnabled = false;
            BtnPickMedium.IsEnabled = false;
            BtnPickLarge.IsEnabled = false;
        }

        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    order.Add(side);
                }
                this.Side = side;
            }
            BtnAddFries.IsEnabled = false;
            BtnAddMMC.IsEnabled = false;
            BtnAddMS.IsEnabled = false;
            BtnAddTots.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
            {
                this.Side.Size = size;
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
                        NavigationService?.Navigate(new CustomizeCombo(combo, combo.Drink, Side));
                    }
                }
            }
        }

        protected void AddFries(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
        }

        protected void AddMMC(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        protected void AddMS(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
        }

        protected void AddTots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }

        protected void OnMakeLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        protected void OnMakeMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        protected void OnMakeSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }
    }
}
