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

namespace NPIE.Screen.ScreenResources
{
    /// <summary>
    /// Interaction logic for DataGrid.xaml
    /// </summary>
    public partial class NP_DataGrid : UserControl
    {
        public NP_DataGrid()
        {
            InitializeComponent();  
            this.Loaded += DataGrid_Loaded;
        }

        public ObservableCollection<GridColumn> ColumnsList { get; set; } = new ObservableCollection<GridColumn>();
        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            //ColumnsList.Add(new GridColumn() { Heading="COLOUMN1"  ,ColumnType = ColumnTypes.Text,Width="200"}); 
            //ColumnsList.Add(new GridColumn() { Heading="COLOUMN1"  ,ColumnType = ColumnTypes.Text,Width="200"}); 
            //ColumnsList.Add(new GridColumn() { Heading="COLOUMN1"  ,ColumnType = ColumnTypes.Text,Width="200"}); 
            //ColumnsList.Add(new GridColumn() { Heading="COLOUMN1"  ,ColumnType = ColumnTypes.Text,Width="200"}); 
            //ColumnsList.Add(new GridColumn() { Heading="COLOUMN1"  ,ColumnType = ColumnTypes.Text,Width="200"}); 
        }
    }
}
