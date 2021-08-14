using Models;
using NPIE.Controller;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace NPIE.Screen.Items
{
    /// <summary>
    /// Interaction logic for ViewProducts.xaml
    /// </summary>
    public partial class ViewProducts : UserControl
    {
        public ViewProducts()
        {
            InitializeComponent();
            this.Loaded += ViewProducts_Loaded;
        }
        public ObservableCollection<GridColumn> gridColumns = new ObservableCollection<GridColumn>();
        private void ViewProducts_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {

                (Application.Current.Resources["AppViewModel"] as HomeController).ListOfItems =  (Application.Current.Resources["AppViewModel"] as HomeController).BusinessLogic.GetAllProducts();

                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Code", Width="80",Property= "ProductCode" });  
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Name", Width="120",Property= "ProductName" }); 
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Cast Price", Width="80", Property= "CastPrice" });
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Sale Price", Width="100", Property= "SalePrice" }); 
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Qunatity", Width="70" ,Property= "Quantity" }); 
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Category", Width="120" ,Property= "Category" }); 
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Unit", Width="50" ,Property= "UnitOfMeasure" }); 
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Vendors", Width="100" ,Property= "Vendor" }); 
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Button, Heading = "Action",Width="120",Property= "Delete" }); 
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "ABC5" });
                (Application.Current.Resources["AppViewModel"] as HomeController).CurrentScreen.ColumnsList = gridColumns; 
            }
            catch (Exception ex)
            { }
        }


        void LoadProducts()
        {
            try
            {

               // dgGridEng.col

            }
            catch (Exception ex)
            { }
        }

        private void addProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProduct p = new AddProduct();
            p.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.Resources["AppViewModel"] as HomeController).CurrentScreen = null;
        }
    }
}
