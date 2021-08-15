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
   public class NPFilterButton : System.Windows.Controls.Button, INotifyPropertyChanged
    { 
        #region Properties

        
        public static readonly DependencyProperty ContentSProperty = DependencyProperty.Register("ContentS", typeof(string), typeof(NPButtons), new UIPropertyMetadata(null));
        
         
        public string ContentS
        {
            get { return (string)GetValue(ContentSProperty); }
            set { SetValue(ContentSProperty, value); }
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
