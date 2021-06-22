using NPIEDesign.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace NPIEDesign.Controls
{
    class EMSTextBox : System.Windows.Controls.TextBox, INotifyPropertyChanged
    {

        public EMSTextBox()
        {
            SetContentToUI();
        }

        #region Properties

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(string), typeof(EMSTextBox), new PropertyMetadata("", new PropertyChangedCallback(IconChanged)));
        private static void IconChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) { try { (d as EMSTextBox).Icon = (string)e.NewValue; } catch (Exception ex) { } }

        private string m_ContentS = string.Empty;
        private string ContentS
        {
            set {
                if (m_ContentS != value)
                {
                    m_ContentS = value;
                    this.OnPropertyChanged("ContentS");
                }
            }
            get {
                return this.m_ContentS;

            }
        }
 

        private string m_Icon = string.Empty;
        public string Icon
        {
            set
            {
                if (this.m_Icon != value)
                {
                    this.m_Icon = value;
                    this.OnPropertyChanged("Icon");
                    SetContentToUI();
                }
            }
            get
            {
                return this.m_Icon;
            }
        }



        #endregion



        #region Functions
        private void SetContentToUI()
        {
            try
            { 
                        this.Text = ContentS;
                        this.FontFamily = new  FontFamily(((dynamic)Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.AppFontFamily);
                        this.FontSize = Convert.ToDouble(((dynamic)Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.TextBoxFontSize);
                        this.Foreground = new  SolidColorBrush((Color)ColorConverter.ConvertFromString(((dynamic)Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.TextBoxFontColor));
                        this.Width = Convert.ToDouble(((dynamic)Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.TextBoxWidth);
                        this.Height = Convert.ToDouble(((dynamic)Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.TextBoxHeight);
                       this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(((dynamic)Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.TextBoxBackGround));
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
