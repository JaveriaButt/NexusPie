﻿using SESDesign.Controller;
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

namespace SESDesign.Screen.ScreenResources
{
    /// <summary>
    /// Interaction logic for DataGrid.xaml
    /// </summary>
    public partial class DataGrid : UserControl
    {
        public DataGrid()
        {
            InitializeComponent();
            this.Loaded += DataGrid_Loaded;
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {

            var list = (Application.Current.Resources["AppViewModel"] as HomeController).DataList;
            dg_DataGrid.ItemsSource =(dynamic)list;
        }
    }
}
