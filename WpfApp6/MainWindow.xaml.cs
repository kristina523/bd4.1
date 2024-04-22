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

namespace WpfApp6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void customers_Click(object sender, RoutedEventArgs e)
        {
            TablesPage.Content = new CustomersPage();
        }

        private void vehicles_Click(object sender, RoutedEventArgs e)
        {
            TablesPage.Content = new VehiclesPage();
        }

        private void brands_Click(object sender, RoutedEventArgs e)
        {
            TablesPage.Content = new BrandsPage();
        }

        private void orders_Click(object sender, RoutedEventArgs e)
        {
            TablesPage.Content = new OrdersPage();
        }
    }
}