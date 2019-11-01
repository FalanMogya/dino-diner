﻿using System;
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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        private DinoNuggets dn;

        private int home;

        public CustomizeDinoNuggets(DinoNuggets dn, int home)
        {
            InitializeComponent();
            this.dn = dn;
            this.home = home;
        }

        private void OnAddNuggets(object sender, RoutedEventArgs args)
        {
            dn.AddNugget();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (home == 0)
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else if (home == 1)
            {
                if (NavigationService.CanGoBack)
                {
                    NavigationService.GoBack();
                }
                else
                {
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
            else if (home == 2)
            {
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
    }
}