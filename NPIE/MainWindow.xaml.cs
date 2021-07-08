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
          
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                WindowStartupLocation = WindowStartupLocation.CenterOwner;
                LoadMainMenu();
            }
            catch (Exception ex)
            { }

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
         
        private void Header_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        } 

        private void LoadMainMenu()
        {
            try
            {
                ControlTemplate TopMenu = (ControlTemplate)this.FindResource("TopMenu"); 
                ControlTemplate SingleMenu = (ControlTemplate)this.FindResource("SingleMenu"); 
                ControlTemplate SubMenu = (ControlTemplate)this.FindResource("SubMenu"); 
               
                MenuItem newMenuItem1 = new MenuItem();
                newMenuItem1.Header = "Open Sale Screen";
                newMenuItem1.Template = TopMenu;
                this.AppMainMenu.Items.Add(newMenuItem1);

                this.AppMainMenu.Items.Add(new MenuItem() { Header = "START SALE SCREEN", Template = SingleMenu });
                this.AppMainMenu.Items.Add(new MenuItem() { Header = "INVOICE", Template = SingleMenu });
                this.AppMainMenu.Items.Add(new MenuItem() { Header = "CUSTOMER", Template = TopMenu });
                this.AppMainMenu.Items.Add(new MenuItem() { Header = "SUPPLIER", Template = TopMenu });
                this.AppMainMenu.Items.Add(new MenuItem() { Header = "PRODUCTS", Template = TopMenu });
                this.AppMainMenu.Items.Add(new MenuItem() { Header = "PURCHASES", Template = TopMenu });
                this.AppMainMenu.Items.Add(new MenuItem() { Header = "EXPENSES", Template = TopMenu });
                this.AppMainMenu.Items.Add(new MenuItem() { Header = "ACCOUNTING", Template = TopMenu }); 
                this.AppMainMenu.Items.Add(new MenuItem() { Header = "DASHBOARD", Template = SingleMenu });
                this.AppMainMenu.Items.Add(new MenuItem() { Header = "REPORTS", Template = TopMenu });
                this.AppMainMenu.Items.Add(new MenuItem() { Header = "USERS", Template = TopMenu });
                this.AppMainMenu.Items.Add(new MenuItem() { Header = "SETTINGS", Template = SingleMenu }); 
                (this.AppMainMenu.Items[0] as MenuItem).Items.Add(new MenuItem() { Header = "ADD NEW", Template = SubMenu , Icon = @"..\Resources\0\Images\Add_Rec.png" });

            }
            catch (Exception ex)
            { }
            
        }
    }
}
