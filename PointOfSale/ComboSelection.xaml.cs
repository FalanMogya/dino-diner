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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        private void SelectCombo(CretaceousCombo combo) { 
            if (DataContext is Order order)
            {
                order.Add(combo);
            }
        }

        protected void AddBrontoCombo(object sender, RoutedEventArgs args)
        {
            Brontowurst bw = new Brontowurst();
            CretaceousCombo combo = new CretaceousCombo(bw);
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeBrontowurst(bw, 2));
        }

        protected void AddNuggetsCombo(object sender, RoutedEventArgs args)
        {
            DinoNuggets dn = new DinoNuggets();
            CretaceousCombo combo = new CretaceousCombo(dn);
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeDinoNuggets(dn, 2));
        }

        protected void AddSteakosaurusCombo(object sender, RoutedEventArgs args)
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            CretaceousCombo combo = new CretaceousCombo(sb);
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeSteakosaurusBurger(sb, 2));
        }

        protected void AddTrexCombo(object sender, RoutedEventArgs args)
        {
            TRexKingBurger trex = new TRexKingBurger();
            CretaceousCombo combo = new CretaceousCombo(trex);
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeTRexKingBurger(trex, 2));
        }

        protected void AddWingsCombo(object sender, RoutedEventArgs args)
        {
            PterodactylWings pw = new PterodactylWings();
            CretaceousCombo combo = new CretaceousCombo(pw);
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeCombo());
        }

        protected void AddPBJCombo(object sender, RoutedEventArgs args)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            CretaceousCombo combo = new CretaceousCombo(pbj);
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj, 2));
        }

        protected void AddWrapCombo(object sender, RoutedEventArgs args)
        {
            VelociWrap vw = new VelociWrap();
            CretaceousCombo combo = new CretaceousCombo(vw);
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeVelociWrap(vw, 2));
        }
    }
}
