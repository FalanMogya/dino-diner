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
            OrderControl.NavigationService = OrderUI.NavigationService;
        }

        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            BindDataContextToPage();
        }

        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            BindDataContextToPage();
        }

        private void BindDataContextToPage()
        {
            if (OrderUI.Content is FrameworkElement element)
            {
                element.DataContext = OrderUI.DataContext;
            }
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (OrderUI.NavigationService.CanGoBack)
            {
                OrderUI.NavigationService.GoBack();
            }
            else
            {
                OrderUI.NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
