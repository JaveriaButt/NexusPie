using Models;
using NPIE.Controller;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace NPIE.Screen
{
    /// <summary>
    /// Interaction logic for SaleScreen.xaml
    /// </summary>
    public partial class SaleScreen : UserControl
    {
        public SaleScreen()
        {
            InitializeComponent();
           
        }

       
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            new System.Threading.Thread(delegate () {
                LoadButtons();
            }).Start();
           
        }
        public ObservableCollection<GridColumn> gridColumns = new ObservableCollection<GridColumn>();
        void LoadButtons()
        {
            try
            { 

                (Application.Current.Resources["AppViewModel"] as HomeController).SaleAbleItems = (Application.Current.Resources["AppViewModel"] as HomeController).BusinessLogic.GetAllProducts();
                (Application.Current.Resources["AppViewModel"] as HomeController).ListOfItems = (Application.Current.Resources["AppViewModel"] as HomeController).BusinessLogic.GetAllProducts();
                 

                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Width = "4*",    Property = "ProductName", HorizontalAllignment= 0 });

                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Button,  Width = "*", Property = "REMOVE" }); 
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text,   Width = "*", Property = "Quantity" });
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Button,   Width = "*", Property = "ADD" });
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text,   Width = "*",   Property = "SalePrice" });  
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text,  Width = "*",    Property = "SalePrice" }); 
                (Application.Current.Resources["AppViewModel"] as HomeController).CurrentScreen.ColumnsList = gridColumns;
            } 
            catch (Exception ex) { }
        }

    }
}
