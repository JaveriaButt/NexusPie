using Microsoft.Win32;
using Models;
using NPIE.Controller;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging; 

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
             

               
            }
            catch(Exception ex)
            { }

        }

        private void browseimage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Title = "Select Product  picture";
                op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                  "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                  "Portable Network Graphic (*.png)|*.png";
                if (op.ShowDialog() == true)
                {
                    productimage.Source = new BitmapImage(new Uri(op.FileName));
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

        private void Cmb_Categroy_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                var SelectedItemID = (Cmb_Categroy.SelectedItem as System.Data.DataRowView)[0].ToString();

                if (SelectedItemID != "1")
                {
                    string ItemCode = (Application.Current.Resources["AppViewModel"] as HomeController).BusinessLogic.GetProductCodeByCategory(SelectedItemID);
                    tb_ItemCode.Text = ItemCode;
                    tb_ItemCode.IsReadOnly = true;
                }
            }
            catch (Exception ex)
            { }
        }
    }
}
