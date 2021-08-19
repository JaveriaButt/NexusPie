using NPIE.Controller;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for Item.xaml
    /// </summary>
    public partial class ListOfItems : UserControl
    {
        public ListOfItems()
        {
            InitializeComponent();
        } 

        private void NP_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                (Application.Current.Resources["AppViewModel"] as HomeController).SubmitToScreen(sender);

            }catch(Exception ex)
            {

            }

        }
    }
}
