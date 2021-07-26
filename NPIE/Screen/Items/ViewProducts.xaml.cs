using Models;
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

                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Product Name", Width="150",Property= "ProductName" }); 
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Cast Price", Width="150", Property= "CastPrice" }); 
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Sale Price", Width="200" ,Property= "SalePrice" }); 
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Category", Width="200" ,Property= "Category" }); 
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Button, Heading = "Action",Width="200", }); 
                gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "ABC5",Width="200" });
                dg_Products.ColumnsList = gridColumns;

                ObservableCollection<Product> Viewableitems = new ObservableCollection<Product>();

                Viewableitems.Add(new Product() { ProductName="Knife" , CastPrice="150",SalePrice="200", Category="ABC" });
                Viewableitems.Add(new Product() { ProductName="Mouse" , CastPrice="150",SalePrice="200", Category="ABC" });
                Viewableitems.Add(new Product() { ProductName="Table" , CastPrice="150",SalePrice="200", Category="ABC" });
                Viewableitems.Add(new Product() { ProductName="Perfume" , CastPrice="150",SalePrice="200", Category="ABC" });
                Viewableitems.Add(new Product() { ProductName="Key" , CastPrice="150",SalePrice="200", Category="ABC" });

                dg_Products.dg_DataGrid.ItemsSource = Viewableitems;





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
    }
}
