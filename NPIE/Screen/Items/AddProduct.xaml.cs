using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace NPIE.Screen.Items
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {



        Product NProduct = new Product() { };
        public AddProduct()
        {
            InitializeComponent();
            this.Loaded += AddProduct_Loaded;
        }

        private void AddProduct_Loaded(object sender, RoutedEventArgs e)
        {
            try {
                Cmb_Categroy.ItemsSource = (System.Collections.IEnumerable)(Application.Current.Resources["AppViewModel"] as HomeController).ProductCategories;
            
            }catch(Exception)
            { }

        }

        private void browseimage_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
                OpenFileDialog f = new OpenFileDialog();
                if (f.ShowDialog() == DialogResult.HasValue)
                {
                    productimage.Source = new BitmapImage(new Uri(f.FileName));
                }
            }
            catch (Exception ex)
            { }
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
