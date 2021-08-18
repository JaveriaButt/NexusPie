using Models;
using NPIE.Controller;
using System; 
using System.Collections.ObjectModel; 
using System.Windows;
using System.Windows.Controls; 

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
                new System.Threading.Thread(delegate ()
                {


                    (Application.Current.Resources["AppViewModel"] as HomeController).ListOfItems = (Application.Current.Resources["AppViewModel"] as HomeController).BusinessLogic.GetAllProducts();
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text,   Heading = "Code", Width = "80", Property = "ProductCode" });
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text,   Heading = "Name", Width = "*", Property = "ProductName" });
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text,   Heading = "Cast Price", Width = "80", Property = "CastPrice" });
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text,   Heading = "Sale Price", Width = "100", Property = "SalePrice" });
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text,   Heading = "Qunatity", Width = "70", Property = "Quantity" });
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text,   Heading = "Category", Width = "120", Property = "Category" });
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text,   Heading = "Unit", Width = "50", Property = "UnitOfMeasure" });
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text,   Heading = "Vendors", Width = "100", Property = "Vendor" });
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Button, Heading = "Update", Width = "120", Property = "Update" });
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Button, Heading = "Delete" , Width = "120", Property = "Delete" });
                    (Application.Current.Resources["AppViewModel"] as HomeController).CurrentScreen.ColumnsList = gridColumns;
                    (Application.Current.Resources["AppViewModel"] as HomeController).DataGridButtonPressedEvent += GridButtonClicked;

                }).Start();
            }
            catch (Exception ex)
            { }
        }

        RoutedEventHandler GridButtonClicked = new RoutedEventHandler(delegate (object Sender, RoutedEventArgs eve)
        {

            try
            {
                var SelectedButton = (Sender as Button);
                if (SelectedButton.DataContext.GetType() ==  typeof(Product))
                {

                    if(SelectedButton.Name.ToUpper() == "UPDATE")
                    {
                        AddProduct p = new AddProduct();
                        p.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                        p.NProduct = (SelectedButton.DataContext as Product); 
                        p.ShowDialog();

                    }
                    else if (SelectedButton.Name.ToUpper() == "DELETE")
                    {


                    }




                }



            }
            catch (Exception ex) { }



        });


        
        private void addProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProduct p = new AddProduct();
            p.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.Resources["AppViewModel"] as HomeController).DataGridButtonPressedEvent -= GridButtonClicked;
            (Application.Current.Resources["AppViewModel"] as HomeController).CurrentScreen = null;
        }
    }
}
