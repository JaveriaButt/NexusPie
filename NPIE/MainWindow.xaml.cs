using Models;
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

namespace NPIE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            (Application.Current.Resources["AppViewModel"] as HomeController).GetApplicationDesign();
            //(Application.Current.Resources["AppViewModel"] as HomeController).GetApplicationDesign();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
            {


            LoadButtons();
             (Application.Current.Resources["AppViewModel"] as HomeController).GetDepartmentList();
            var control = (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.ControlSetting;
            this.WindowStartupLocation = WindowStartupLocation.CenterOwner; 


            

        }

        void LoadButtons()
        {
            try {

                (Application.Current.Resources["AppViewModel"] as HomeController).ListOfItems = new List<Product>() {
                
               
                      new Product{ ProductCode="0123", ProductName ="BOOK BY Author",SalePrice="250P pkr" }, 
                     new Product{ ProductCode="0123", ProductName ="BOOK BY Author",SalePrice="250P pkr"  }, 
                     new Product{ ProductCode="0123", ProductName ="BOOK BY Author",SalePrice="250P pkr"  }, 
                     new Product{ ProductCode="0123", ProductName ="BOOK BY Author",SalePrice="250P pkr"  }, 
                     new Product{ ProductCode="0123", ProductName ="BOOK BY Author",SalePrice="250P pkr"  }, 
                     new Product{ ProductCode="0123", ProductName ="BOOK BY Author",SalePrice="250P pkr"  }, 
                     new Product{ ProductCode="0123", ProductName ="BOOK BY Author",SalePrice="250P pkr"  }, 
                     new Product{ ProductCode="0123", ProductName ="BOOK BY Author",SalePrice="250P pkr"  }, 
                     new Product{ ProductCode="0123", ProductName ="BOOK BY Author",SalePrice="250P pkr"  }, 
                     new Product{ ProductCode="0123", ProductName ="BOOK BY Author",SalePrice="250P pkr"  }, 
                     new Product{ ProductCode="0123", ProductName ="BOOK BY Author",SalePrice="250P pkr"  }
                
                
                
                
                
                
                
                
                
                
                
                };
            }
            catch(Exception ex) {  }
        }



        private void Add_Click(object sender, RoutedEventArgs e)
        {
           
          
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
           
        }
         

        private void Department_Click(object sender, RoutedEventArgs e)
        {
           
        }
        public void ShowScreen(BaNPIEcreen _Screen)
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

        private void Subject_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddSub_Click(object sender, RoutedEventArgs e)
        {
             
        }

        private void Header_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
