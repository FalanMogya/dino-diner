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
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl1.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public NavigationService NavigationService { get; set; }

        public OrderControl()
        {
            InitializeComponent();
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (OrderItems.SelectedItem is Brontowurst bw)
            {
                NavigationService?.Navigate(new CustomizeBrontowurst(bw, 1));
            }
            else if (OrderItems.SelectedItem is DinoNuggets dn)
            {
                NavigationService?.Navigate(new CustomizeDinoNuggets(dn, 1));
            }
            else if (OrderItems.SelectedItem is SteakosaurusBurger sb)
            {
                NavigationService?.Navigate(new CustomizeSteakosaurusBurger(sb, 1));
            }
            else if (OrderItems.SelectedItem is TRexKingBurger trex)
            {
                NavigationService?.Navigate(new CustomizeTRexKingBurger(trex, 1));
            }
            else if (OrderItems.SelectedItem is PrehistoricPBJ pbj)
            {
                NavigationService?.Navigate(new CustomizePrehistoricPBJ(pbj, 1));
            }
            else if (OrderItems.SelectedItem is VelociWrap vw)
            {
                NavigationService?.Navigate(new CustomizeVelociWrap(vw, 1));
            }
            else if (OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side, 1));
            }
            else if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink, 1));
            }
            else if (OrderItems.SelectedItem is CretaceousCombo combo)
            {
                NavigationService?.Navigate(new CustomizeCombo(combo, combo.Drink, combo.Side));
            }
        }

        private void OnRemoveItem(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }
    }
}
