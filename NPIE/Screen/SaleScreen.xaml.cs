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

        ObservableCollection<Product> ItemsForSale = null;
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
                 
                ItemsForSale = (Application.Current.Resources["AppViewModel"] as HomeController).SaleAbleItems = (Application.Current.Resources["AppViewModel"] as HomeController).BusinessLogic.GetAllProducts();
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Width = "4*",    Property = "ProductName", HorizontalAllignment= 0 });
               gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Button,  Width = "*", Property = "REMOVE" }); 
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text,   Width = "*", Property = "Quantity" });
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Button,   Width = "*", Property = "ADD" });
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text,   Width = "*",   Property = "SalePrice" });  
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text,  Width = "*",    Property = "SalePrice" }); 
                (Application.Current.Resources["AppViewModel"] as HomeController).CurrentScreen.ColumnsList = gridColumns;
                (Application.Current.Resources["AppViewModel"] as HomeController).SubmitToScreenEvent += ItemSelected;
                (Application.Current.Resources["AppViewModel"] as HomeController).DataGridButtonPressedEvent += ItemQunatityChanged;
            } 
            catch (Exception ex) { }
        }

        private void NPButtons_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string CategoryFilter = (sender as NPIE.Controls.NPButtons).ContentS;
                (Application.Current.Resources["AppViewModel"] as HomeController).SaleAbleItems =new ObservableCollection<Product>(ItemsForSale.Where(p => p.Category == CategoryFilter));
            }
            catch (Exception ex)
            { }

        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                (Application.Current.Resources["AppViewModel"] as HomeController).ListOfItems.Clear();
            }
            catch (Exception ex)
            { }
        }


        RoutedEventHandler ItemSelected = new RoutedEventHandler(delegate (object sndr, RoutedEventArgs eve )
        {
            try
            {

                var P = (sndr as NPIE.Controls.NPButtons).DataContext as Product;
                var CheckExistance = (Application.Current.Resources["AppViewModel"] as HomeController).ListOfItems.Where(p => p.ProductCode == P.ProductCode).FirstOrDefault();
                if (CheckExistance != null && !string.IsNullOrWhiteSpace(CheckExistance.ProductCode))
                {
                    CheckExistance.Quantity++;
                }
                else
                {
                    P.Quantity = 1;
                    (Application.Current.Resources["AppViewModel"] as HomeController).ListOfItems.Add(P);
                }


            }
            catch (Exception ex)
            { }
        
        });

        RoutedEventHandler ItemQunatityChanged = new RoutedEventHandler(delegate (object sndr, RoutedEventArgs ev) {
            try
            {




            }
            catch (Exception e)
            { } 
        });

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            try
            {
                (Application.Current.Resources["AppViewModel"] as HomeController).SubmitToScreenEvent -= ItemSelected;
            }
            catch (Exception ex)
            { }

        }
    }
}
