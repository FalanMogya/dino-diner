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
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Order order = (Order)DataContext;
            order.Items.Add(new Fryceritops());
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = DinoDiner.Menu.Size.Medium;
            order.Items.Add(tea);
        }

        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {

        }

        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {

        }

        private void SetFrameDataContext()
        {
            FrameworkElement conten = OrderInterface.Content as FrameworkElement;
        }
    }
}
