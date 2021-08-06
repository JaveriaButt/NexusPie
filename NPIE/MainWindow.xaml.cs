using MaterialDesignThemes.Wpf;
using Models;
using NPIE.Controller;
using NPIE.Controls;
using NPIE.Screen.ScreenResources;
using System;
using System.Collections.Generic;  
using System.Windows;
using System.Windows.Controls; 
using System.Windows.Input; 

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
                try { (Application.Current.Resources["AppViewModel"] as HomeController).LoadBasicReferneces(); } catch (Exception ex) { }
                WindowStartupLocation = WindowStartupLocation.CenterOwner; 
                LoadMainMenu();
                (Application.Current.Resources["AppViewModel"] as HomeController).HomeScreen.SendClickEvent += HomeScreen_SendClickEvent;
            }
            catch (Exception ex)
            { }

        }

        private void HomeScreen_SendClickEvent(object sender, RoutedEventArgs e)
        {
            try
            {
                var abc = sender as SubItem;
                switch (abc.Name.ToUpper())
                {
                    case "PRODUCTS":
                        {
                            (Application.Current.Resources["AppViewModel"] as HomeController).CurrentScreen = new Screen.Items.ViewProducts();
                            break;
                        }
                }


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

         
        public void ShowScreen(BaNPIEScreen _Screen)
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
                var acb = (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign;

                var menuRegister = new List<SubItem>();
                menuRegister.Add(new SubItem("Customer"));
                menuRegister.Add(new SubItem("Providers"));
                menuRegister.Add(new SubItem("Employees"));
                menuRegister.Add(new SubItem("Products"));
                var item6 = new ItemMenu("Register", menuRegister, PackIconKind.Register);

                var menuSchedule = new List<SubItem>();
                menuSchedule.Add(new SubItem("Products"));
                menuSchedule.Add(new SubItem("Payment"));
                var item1 = new ItemMenu("Purchases", menuSchedule, PackIconKind.Schedule);

                var menuReports = new List<SubItem>();
                menuReports.Add(new SubItem("Customers"));
                menuReports.Add(new SubItem("Providers"));
                menuReports.Add(new SubItem("Products"));
                menuReports.Add(new SubItem("Stock"));
                menuReports.Add(new SubItem("Sales"));
                var item2 = new ItemMenu("Reports", menuReports, PackIconKind.FileReport);

                var menuExpenses = new List<SubItem>();
                menuExpenses.Add(new SubItem("Fixed"));
                menuExpenses.Add(new SubItem("Variable"));
                var item3 = new ItemMenu("Expenses", menuExpenses, PackIconKind.ShoppingBasket);

                var menuFinancial = new List<SubItem>();
                menuFinancial.Add(new SubItem("Cash flow"));
                var item4 = new ItemMenu("Financial", menuFinancial, PackIconKind.ScaleBalance);

                var item0 = new ItemMenu("Dashboard", new UserControl(), PackIconKind.ViewDashboard);


                Menu.Children.Add(new NavigationMenu(item0));
                Menu.Children.Add(new NavigationMenu(item6));
                Menu.Children.Add(new NavigationMenu(item1));
                Menu.Children.Add(new NavigationMenu(item2));
                Menu.Children.Add(new NavigationMenu(item3));
                Menu.Children.Add(new NavigationMenu(item4));

            }
            catch (Exception ex)
            { }
            
        }

        private void NPImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((Application.Current.Resources["AppViewModel"] as HomeController).HomeScreen.IsMenuShown)
            {
                (Application.Current.Resources["AppViewModel"] as HomeController).HomeScreen.IsMenuShown = false;
            }
            else
                (Application.Current.Resources["AppViewModel"] as HomeController).HomeScreen.IsMenuShown = true;
        }
    }
}
