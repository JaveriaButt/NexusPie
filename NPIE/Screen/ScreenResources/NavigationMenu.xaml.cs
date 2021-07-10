using NPIE.Controller;
using NPIE.Controls;
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

namespace NPIE.Screen.ScreenResources
{
    /// <summary>
    /// Interaction logic for NavigationMenu.xaml
    /// </summary>
    public partial class NavigationMenu : UserControl
    {
        public NavigationMenu(ItemMenu itemMenu)
        {
            InitializeComponent();  
            this.DataContext = itemMenu;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                (Application.Current.Resources["AppViewModel"] as HomeController).HomeScreen.SendClick(sender);

            }
            catch (Exception ex) { }

        }
    }
}
