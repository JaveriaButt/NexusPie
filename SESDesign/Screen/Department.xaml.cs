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

namespace SESDesign.Screen
{
    /// <summary>
    /// Interaction logic for AddDepartment.xaml
    /// </summary>
    public partial class Department : UserControl,INotifyPropertyChanged
    { 
       
        public Department()
        {

            InitializeComponent();
            this.Loaded += Department_Loaded;

        }

        private void Department_Loaded(object sender, RoutedEventArgs e)
        {
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon = new ObservableCollection<GridColumn>();
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon.Add(new GridColumn { Width= "*",  ColumnType = ColumnTypes.Text,  Heading="HOD" ,Property= "DepHOD" });
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon.Add(new GridColumn { Width = "*", ColumnType = ColumnTypes.Text ,Heading ="Department Name" ,Property="DepName" });
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon.Add(new GridColumn { Width = "*", ColumnType = ColumnTypes.Button, IconWidth = 250, IconHeight = 100, Heading = "Update Record", Property="Update"  });
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon.Add(new GridColumn { Width = "*", ColumnType = ColumnTypes.Button, IconWidth = 250, IconHeight = 100, Heading = "Delete Record"  ,Property="Delete" });
 
            (Application.Current.Resources["AppViewModel"] as HomeController).DataList = DAL.DAL1.GetDepartment(); 
            DataGRid.Content = new Screen.ScreenResources.DataGrid();

            (Application.Current.Resources["AppViewModel"] as HomeController).CurrentScreen.SendClickEvent += CurrentScreen_SendClickEvent;
        }

        private void CurrentScreen_SendClickEvent(object sender, RoutedEventArgs e)
        {
            if (sender != null)
            {
                string EventSender = (sender as ClickResponse).SENDER; 
                if (EventSender == "Update")
                { 
                    UpdateDepartment((sender as ClickResponse).DataObject as DepartmentS);
                }
                else if (EventSender == "Delete")
                {

                }
            }
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



        private void UpdateDepartment(DepartmentS RecToUpdate)
        {
            try
            {
                tb_depName.Text = RecToUpdate.DepName;
                tb_hodName.Text = RecToUpdate.DepHOD;
                tb_DepID.Text = RecToUpdate.DepID; 

            }
            catch(Exception ex)
            { }

        }




      

        private void DepGird_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid _DataGrid = sender as DataGrid;
            //index = _DataGrid.SelectedIndex;
            //if (index != -1)
            //{
            //    //id = Convert.ToInt32(Data.Rows[index].ItemArray[1]);
            //    //tb_depName.Text = Data.Rows[index].ItemArray[2].ToString();
            //    //tb_hodName.Text = Data.Rows[index].ItemArray[3].ToString();
            //}
        }

        private void UpdateButtons_Click(object sender, RoutedEventArgs e)
        {
           
            //    dep = new DepartmentS();
            //    dep.DepID = id.ToString();
            //    //dep.DepName = tb_depName.Text;
            //    //dep.DepHOD = tb_hodName.Text;
            //    var res = DAL.DAL1.UpdateDepartmentInfo(dep);
            //    //DataGridBinding();
            //}
            //id = 0;
            ////tb_depName.Clear();
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
