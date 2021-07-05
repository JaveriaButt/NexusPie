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

namespace NPIE.Screen
{
    /// <summary>
    /// Interaction logic for SaleScreen.xaml
    /// </summary>
    public partial class SaleScreen : UserControl
    {
        public SaleScreen()
        {
            InitializeComponent();
           
        }

       
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadButtons();
        }

        void LoadButtons()
        {
            try
            {
                var abc = (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign;

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


                (Application.Current.Resources["AppViewModel"] as HomeController).ListOfCategory = new List<Product>() {


                      new Product{ ProductCode="0123", ProductName ="All",SalePrice="250P pkr" },
                     new Product{ ProductCode="0123", ProductName ="Author",SalePrice="250P pkr"  },
                     new Product{ ProductCode="0123", ProductName ="BOOK",SalePrice="250P pkr"  },
                     new Product{ ProductCode="0123", ProductName =" BY ",SalePrice="250P pkr"  } 
                };
            }
            catch (Exception ex) { }
        }

    }
}
