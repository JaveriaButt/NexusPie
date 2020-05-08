using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Models;
using System.Collections.ObjectModel;
using System.Windows.Controls.Primitives;
using System.Data;
using System.Windows.Media.Effects;
using SESDesign.Controller;
using System.Collections.Specialized;
using System.ComponentModel;

namespace SESDesign.ScreenResources
{
    /// <summary>
    /// Interaction logic for AddDepartment.xaml
    /// </summary>
    public partial class AddDepartment : UserControl,INotifyPropertyChanged
    { 
       
        public AddDepartment()
        {

            InitializeComponent();
            this.Loaded += AddDepartment_Loaded;

        }

        private void AddDepartment_Loaded(object sender, RoutedEventArgs e)
        {
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon = new ObservableCollection<GridColumn>();
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon.Add(new GridColumn { Width="*",ColumnType = ColumnTypes.Text ,Heading="HOD",ID="DepID",Property= "DepID" });
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon.Add(new GridColumn { Width = "*", ColumnType = ColumnTypes.Text ,Heading ="Department Name",ID="DepName" ,Property="DepName" });
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon.Add(new GridColumn { Width = "*", ColumnType = ColumnTypes.Button, Heading = "Update Record",   });
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon.Add(new GridColumn { Width = "*", ColumnType = ColumnTypes.Button, Heading = "Delete Record"   });



            (Application.Current.Resources["AppViewModel"] as HomeController).DataList = DAL.DAL1.GetDepartment(); 
            DataGRid.Content = new Screen.ScreenResources.DataGrid();

        }

        DepartmentS dep;
        private void EMSButtons_Click(object sender, RoutedEventArgs e)
        {
            dep = new DepartmentS();
            //dep.DepName = tb_depName.Text;
            //dep.DepHOD = tb_hodName.Text;
            var res = DAL.DAL1.SaveDepartmentInfo(dep);
            // DataGridBinding();
        }

        DataTable Data = new DataTable();
        //private void DataGridBinding()
        //{
        //    List<DepartmentS> list = DAL.DAL1.GetDepartment();
        //    DepGird.Columns.Clear();
        //    Data = new DataTable();
        //    DepGird.ItemsSource = Data.AsDataView();
        //    Data.Columns.Add("Delete");
        //    Data.Columns.Add("ID");
        //    Data.Columns.Add("Dep Name");
        //    Data.Columns.Add("Dep HOD");
        //    Data.Columns[2].ReadOnly = false;
        //    Data.Columns[3].ReadOnly = false;
        //    foreach (var x in list)
        //    {
        //        Data.Rows.Add(new object[] {"Delete",x.DepID,x.DepName, x.DepHOD });
        //    }
        //    DepGird.ItemsSource = Data.AsDataView();
        //}
        int index = -1;
        int id = 0;

        private void DepGird_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid _DataGrid = sender as DataGrid;
            index = _DataGrid.SelectedIndex;
            if (index != -1)
            {
                //id = Convert.ToInt32(Data.Rows[index].ItemArray[1]);
                //tb_depName.Text = Data.Rows[index].ItemArray[2].ToString();
                //tb_hodName.Text = Data.Rows[index].ItemArray[3].ToString();
            }
        }

        private void UpdateButtons_Click(object sender, RoutedEventArgs e)
        {
            if (id != 0)
            {
                dep = new DepartmentS();
                dep.DepID = id.ToString();
                //dep.DepName = tb_depName.Text;
                //dep.DepHOD = tb_hodName.Text;
                var res = DAL.DAL1.UpdateDepartmentInfo(dep);
                //DataGridBinding();
            }
            id = 0;
            //tb_depName.Clear();
            //tb_hodName.Clear();
        }

        
        private void CloseClick(object sender, RoutedEventArgs e)
        {

        }


        #region Property Changed Event
        //Event 
        public event PropertyChangedEventHandler PropertyChanged;

        //Property Changed Method
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }
   
}
