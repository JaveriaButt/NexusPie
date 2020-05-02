using Models;
using System;
using System.Collections.Generic;
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

namespace SESDesign.ScreenResources
{
    /// <summary>
    /// Interaction logic for AddDepartment.xaml
    /// </summary>
    public partial class AddDepartment : UserControl
    {
        public AddDepartment()
        {
            InitializeComponent();
            DataGridBinding();
        }
        DepartmentS dep;
        private void EMSButtons_Click(object sender, RoutedEventArgs e)
        {
            dep = new DepartmentS();
            dep.DepName = tb_depName.Text;
            dep.DepHOD = tb_hodName.Text;
            var res = DAL.DAL1.SaveDepartmentInfo(dep);
            DataGridBinding();
        }

        DataTable Data = new DataTable();
        private void DataGridBinding()
        {
            List<DepartmentS> list = DAL.DAL1.GetDepartment();
            DepGird.Columns.Clear();
            Data = new DataTable();
            DepGird.ItemsSource = Data.AsDataView();
            Data.Columns.Add("Delete");
            Data.Columns.Add("ID");
            Data.Columns.Add("Dep Name");
            Data.Columns.Add("Dep HOD");
            Data.Columns[2].ReadOnly = false;
            Data.Columns[3].ReadOnly = false;
            foreach (var x in list)
            {
                Data.Rows.Add(new object[] {"Delete",x.DepID,x.DepName, x.DepHOD });
            }
            DepGird.ItemsSource = Data.AsDataView();
        }
        int index=-1;
        int id = 0;
        private void DepGird_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid _DataGrid = sender as DataGrid;
            index = _DataGrid.SelectedIndex;
            if(index!=-1)
            {
                id = Convert.ToInt32(Data.Rows[index].ItemArray[1]);
                tb_depName.Text = Data.Rows[index].ItemArray[2].ToString();
                tb_hodName.Text = Data.Rows[index].ItemArray[3].ToString();
            }
        }

        private void UpdateButtons_Click(object sender, RoutedEventArgs e)
        {
            if (id!=0)
            {
                dep = new DepartmentS();
                dep.DepID = id.ToString();
                dep.DepName = tb_depName.Text;
                dep.DepHOD = tb_hodName.Text;
                var res = DAL.DAL1.UpdateDepartmentInfo(dep);
                DataGridBinding();
            }
            id = 0;
            tb_depName.Clear();
            tb_hodName.Clear();
        }
    }
}
