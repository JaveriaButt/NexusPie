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

namespace NPIEDesign.Screen.ScreenResources
{
    /// <summary>
    /// Interaction logic for ConfirmationAlert.xaml
    /// </summary>
    public partial class ConfirmationAlert : Window
    {
        public static string Icon = string.Empty;
        public static string Message = string.Empty;
        public ConfirmationAlert()
        {
            InitializeComponent();
        }

        public static void ShowAsPopUp()
        {
            Message = "Are you OK";
            Window window = new Window
            { 
                Content =new ConfirmationAlert()
            }; 
            window.ShowDialog();
        }
    }
}
