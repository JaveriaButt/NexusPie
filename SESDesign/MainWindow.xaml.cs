using SESDesign.Controller;
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

namespace SESDesign
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //(Application.Current.Resources["AppViewModel"] as HomeController).GetApplicationDesign();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            (Application.Current.Resources["AppViewModel"] as HomeController).GetApplicationDesign();

            (Application.Current.Resources["AppViewModel"] as HomeController).GetDepartmentList();
            var control = (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.ControlSetting;

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            this.mainContentControl.Content = new ScreenResources.AddStudent();
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            this.mainContentControl.Content = new ScreenResources.SearchStudent();
        }
    }
}
