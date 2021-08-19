using Microsoft.Win32;
using Models;
using NPIE.Controller;
using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Resources;
using System.Drawing;
using System.Drawing.Imaging;

namespace NPIE.Screen.Items
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    { 
        public Product NProduct =   new Product() { };
        public AddProduct()
        {
            InitializeComponent();
            this.Loaded += AddProduct_Loaded;
        }

        private void AddProduct_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {

                this.DataContext = NProduct;
                Cmb_Categroy.SelectionChanged += Cmb_Categroy_SelectionChanged;
                if(!string.IsNullOrWhiteSpace(NProduct.Category))
                {
                    Cmb_Categroy.SelectedItem = Cmb_Categroy.Items.IndexOf(NProduct.Category);
                }
                if(!string.IsNullOrWhiteSpace(NProduct.UnitOfMeasure))
                {
                    cmb_UnitOfMeasure.SelectedValue = NProduct.UnitOfMeasure;
                }




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
                if (tb_ItemCode != null)
                    tb_ItemCode.Clear();
                var SelectedItemID = (Cmb_Categroy.SelectedItem as Category).ID.ToString(); 
                if (SelectedItemID != "1" && int.Parse(SelectedItemID) != 1)
                {
                    string ItemCode = (Application.Current.Resources["AppViewModel"] as HomeController).BusinessLogic.GetProductCodeByCategory(SelectedItemID);
                    tb_ItemCode.Text = ItemCode;
                    tb_ItemCode.IsReadOnly = true; 
                }
            }
            catch (Exception ex)
            { }
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(tb_ItemCode.Text) || string.IsNullOrWhiteSpace(tb_ItemName.Text)
                    || string.IsNullOrWhiteSpace(tb_CostPrice.Text) || string.IsNullOrWhiteSpace(tb_Qunatity.Text))
                {
                    MessageBox.Show("Please Fill All Field", "Empty Fields", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;

                }  
                string Xpath = (Application.Current.Resources["AppViewModel"] as HomeController).AppConfig.CustomImagesPath;
                if (!Directory.Exists(Xpath))
                {
                    Directory.CreateDirectory(Xpath);
                }
                if (Directory.Exists(Xpath) && productimage.Source != null)
                {
                    var BitImage = new Bitmap(new Uri(productimage.Source.ToString()).LocalPath);
                    Xpath = Xpath + tb_ItemCode.Text.Trim() + ".png";
                    BitImage.Save(Xpath, ImageFormat.Png);
                    var ItemImage = General.ResizeImage(BitImage);
                }
                else
                    Xpath = string.Empty;

                NProduct.ProductCode = tb_ItemCode.Text.Trim();
                NProduct.ProductName = tb_ItemName.Text.Trim(); 
                NProduct.Vendor = tb_PVendor.Text.Trim();
                NProduct.CastPrice = tb_CostPrice.Text.Trim();
                NProduct.SalePrice = tb_SalePrice.Text.Trim();
                NProduct.Description = tb_PDescription.Text.Trim();
                NProduct.ImagePath = Xpath;
                NProduct.ProductBarcode = tb_barcode.Text.Trim();
                try { NProduct.Quantity = int.Parse(tb_Qunatity.Text.Trim()); } catch (Exception ex) { }
                try { NProduct.Category = (Cmb_Categroy.SelectedItem as Category).ID.ToString(); } catch (Exception ex) { }
                try { NProduct.UnitOfMeasure = (cmb_UnitOfMeasure.SelectedItem as System.Data.DataRowView)[0].ToString(); } catch (Exception ex) { }
                var resposne = (Application.Current.Resources["AppViewModel"] as HomeController).BusinessLogic.AddNewProduct(NProduct);
                MessageBox.Show(resposne.Result);

            }
            catch (Exception ex)
            { }
        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            try
            {


            }
            catch (Exception ex)
            { }
        }

        private bool SaveImage(string ItemCode)
        {
            bool Resposne = false;
            try
            {



            }
            catch (Exception ex)
            { }
            return Resposne;
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Cmb_Categroy.SelectionChanged -= Cmb_Categroy_SelectionChanged;
                this.Loaded -= AddProduct_Loaded;
                this.Unloaded -= Window_Unloaded;
            }
            catch (Exception ex)

            { }
        }
    }
}
