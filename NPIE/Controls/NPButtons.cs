using NPIE.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace NPIE.Controls
{
   public class NPButtons : System.Windows.Controls.Button, INotifyPropertyChanged
    {


        
 

        #region Properties

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(string), typeof(NPButtons), new UIPropertyMetadata(null));
        
        public static readonly DependencyProperty PriceProperty = DependencyProperty.Register("Price", typeof(string), typeof(NPButtons), new UIPropertyMetadata(null));
       
        public static readonly DependencyProperty ItemCodeProperty = DependencyProperty.Register("ItemCode", typeof(string), typeof(NPButtons), new UIPropertyMetadata(null));
      
        public static readonly DependencyProperty ContentSProperty = DependencyProperty.Register("ContentS", typeof(string), typeof(NPButtons), new UIPropertyMetadata(null));
        
         
        public string ContentS
        {
            get { return (string)GetValue(ContentSProperty); }
            set { SetValue(ContentSProperty, value); }
        }
          
         
        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
             
        }

     
        public string Price
        {
            set
            {
                SetValue(PriceProperty, value);
            }
            get
            {
                return (string)GetValue(PriceProperty);
            }
        }

    
        public string ItemCode
        {
            set
            {
                SetValue(ItemCodeProperty, value);
            }
            get
            {
                return (string)GetValue(ItemCodeProperty);
            }
        }

        #endregion



        #region Functions
        private void SetContentToUI()
        {
            try
            { 
                        //this.Content = ContentS; 
                        this.FontFamily = new  FontFamily(((dynamic)Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.AppFontFamily);
                        this.FontSize = Convert.ToDouble(((dynamic)Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.ButtonFontSize);
                        this.Foreground = new  SolidColorBrush((Color)ColorConverter.ConvertFromString(((dynamic)Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.ButtonFontColor));
                        this.Width = Convert.ToDouble(((dynamic)Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.ButtonWidth);
                        this.Height = Convert.ToDouble(((dynamic)Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.ButtonHeight);
                        this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(((dynamic)Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.ButtonBackGround));
            }
            catch (Exception ex)
            {

            }
        }
        #endregion


        #region Property Changed Event 
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion

    }
}
