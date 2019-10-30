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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {

        public EntreeSelection()
        {
            InitializeComponent();
        }

        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
            }
        }

        protected void AddBronto(object sender, RoutedEventArgs args)
        {
            Brontowurst bw = new Brontowurst();
            SelectEntree(bw);
            NavigationService.Navigate(new CustomizeBrontowurst(bw, 0));
        }

        protected void AddNuggets(object sender, RoutedEventArgs args)
        {
            DinoNuggets dn = new DinoNuggets();
            SelectEntree(dn);
            NavigationService.Navigate(new CustomizeDinoNuggets(dn, 0));
        }

        protected void AddSteakosaurus(object sender, RoutedEventArgs args)
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            SelectEntree(sb);
            NavigationService.Navigate(new CustomizeSteakosaurusBurger(sb, 0));
        }

        protected void AddTrex(object sender, RoutedEventArgs args)
        {
            TRexKingBurger trex = new TRexKingBurger();
            SelectEntree(trex);
            NavigationService.Navigate(new CustomizeTRexKingBurger(trex, 0));
        }

        protected void AddWings(object sender, RoutedEventArgs args)
        {
            PterodactylWings pw = new PterodactylWings();
            SelectEntree(pw);
            NavigationService.Navigate(new MenuCategorySelection());
        }

        protected void AddPBJ(object sender, RoutedEventArgs args)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            SelectEntree(pbj);
            NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj, 0));
        }

        protected void AddWrap(object sender, RoutedEventArgs args)
        {
            VelociWrap vw = new VelociWrap();
            SelectEntree(vw);
            NavigationService.Navigate(new CustomizeVelociWrap(vw, 0));
        }
    }
}
