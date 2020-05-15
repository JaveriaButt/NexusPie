using Models;
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
            this.WindowStartupLocation = WindowStartupLocation.CenterOwner; 

        } 



        private void Add_Click(object sender, RoutedEventArgs e)
        {
            BaseScreen AddStudent = new BaseScreen(ScreenType.ADD_STUDENT);
            this.ShowScreen(AddStudent);
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            BaseScreen SearchStudent = new BaseScreen(ScreenType.SEARCH_STUDENT);
            this.ShowScreen(SearchStudent);
        }
         

        private void Department_Click(object sender, RoutedEventArgs e)
        {
            BaseScreen Department = new BaseScreen(ScreenType.DEPARTMENT);
            this.ShowScreen(Department);
        }






        public void ShowScreen(BaseScreen _Screen)
        {
            try
            {
                Application.Current.Dispatcher.BeginInvoke((Action)(() =>
                {
                    ((dynamic)Application.Current.Resources["AppViewModel"]).CurrentScreen = _Screen;
                }));
            }
            catch (Exception ex)
            {

            }
        }
    }
}
