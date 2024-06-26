﻿using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp6.CarShowroom2DataSetTableAdapters;

namespace WpfApp6
{
    public partial class CustomersPage : Page
    {
        CustomersTableAdapter context = new CustomersTableAdapter();
        public CustomersPage()
        {
            InitializeComponent();
            customersDgr.ItemsSource = context.GetData();
            Cbx.ItemsSource = context.GetData();
            Cbx.DisplayMemberPath = "CustomerSurname";

        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            customersDgr.ItemsSource = context.SearchByEmail(SearchTxt.Text);
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            customersDgr.ItemsSource = context.GetData();
        }

        private void Cbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Cbx.SelectedItem != null)
            {
                var id = (int)(Cbx.SelectedItem as DataRowView).Row[0];
                customersDgr.ItemsSource = context.FillterByCustomer(id);
            }
        }
    }
}