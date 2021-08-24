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

namespace NPIE.Screen.Catagories
{
    /// <summary>
    /// Interaction logic for Catagoriess.xaml
    /// </summary>
    public partial class Catagoriess : UserControl
    {
        public Catagoriess()
        {
            InitializeComponent();
            Load();
        }
        public ObservableCollection<GridColumn> gridColumns = new ObservableCollection<GridColumn>();

        void Load()
        {
            try
            {
                new System.Threading.Thread(delegate ()
                {


                    (Application.Current.Resources["AppViewModel"] as HomeController).ListOfCatagory = (Application.Current.Resources["AppViewModel"] as HomeController).BusinessLogic.GetAllCatagories();
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Code", Width = "80", Property = "CatagoryId" });
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Catagory Name", Width = "*", Property = "CatagoryName" });
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Description", Width = "80", Property = "Description" });
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Text, Heading = "Is Active?", Width = "100", Property = "IsPresent" });
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Button, Heading = "Update", Width = "120", Property = "Update" });
                    gridColumns.Add(new GridColumn { ColumnType = ColumnTypes.Button, Heading = "Delete", Width = "120", Property = "Delete" });
                    (Application.Current.Resources["AppViewModel"] as HomeController).CurrentScreen.ColumnsList = gridColumns;
                    (Application.Current.Resources["AppViewModel"] as HomeController).DataGridButtonPressedEvent += GridButtonClicked;

                }).Start();
            }
            catch (Exception ex)
            { }
        }
        RoutedEventHandler GridButtonClicked = new RoutedEventHandler(delegate (object Sender, RoutedEventArgs eve)
        {

        });
        private void dg_catagories_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
