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
using System.Windows.Threading;

namespace NPIE.Screen.ScreenResources
{
    /// <summary>
    /// Interaction logic for DataGrid.xaml
    /// </summary>
    public partial class NP_SaleGrid : UserControl
    {
        public NP_SaleGrid()
        {
            InitializeComponent();
           
        }

        public ObservableCollection<GridColumn> ColumnsList = new ObservableCollection<GridColumn>();
        public ObservableCollection<object> GridItems = new ObservableCollection<object>();
        private void dgGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (dgGrid.CurrentCell != null && dgGrid.CurrentCell.Column != null && dgGrid.CurrentCell.Column is DataGridTextColumn)
                {
                    dynamic TextBlock = (dgGrid.CurrentCell.Column as DataGridTextColumn).GetCellContent(dgGrid.SelectedItem);
                    Clipboard.SetText(TextBlock.Text);
                }
            }
            catch (Exception ex)
            {
                Clipboard.SetText("");
            }
        }

        private void dgGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (dgGrid.CurrentCell != null && dgGrid.CurrentCell.Column != null && dgGrid.CurrentCell.Column is DataGridTextColumn)
                {
                    dynamic TextBlock = (dgGrid.CurrentCell.Column as DataGridTextColumn).GetCellContent(dgGrid.SelectedItem);
                }
                else if (dgGrid.CurrentCell != null && dgGrid.CurrentCell.Column != null && dgGrid.CurrentCell.Column is DataGridTemplateColumn)
                {
                    dynamic TextBlock = (dgGrid.CurrentCell.Column as DataGridTemplateColumn).DisplayIndex;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnUnHold_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //if ((Application.Current.Resources["AppViewModel"] as HomeController).SelectedPerson != null && (Application.Current.Resources["AppViewModel"] as HomeController).SelectedPerson["Status"].ToString() == "HOLD")
                //{
                //    (Application.Current.Resources["AppViewModel"] as HomeController).UnHold((Application.Current.Resources["AppViewModel"] as HomeController).SelectedPerson.Row);
                //}
            }
            catch (Exception ex)
            {

            }
        }
    } 
   
}
