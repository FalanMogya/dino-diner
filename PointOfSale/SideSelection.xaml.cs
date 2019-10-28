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

        public Side Side { get; set; }

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

        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
            BtnAddFries.IsEnabled = false;
            BtnAddMMC.IsEnabled = false;
            BtnAddMS.IsEnabled = false;
            BtnAddTots.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
        }

        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Add(side);
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
                NavigationService?.Navigate(new MenuCategorySelection());
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
