﻿using SESDesign.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace SESDesign.Controls
{
    class EMSButtons : System.Windows.Controls.Button, INotifyPropertyChanged
    {

        public EMSButtons()
        {
            SetContentToUI();
        }

        #region Properties

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(string), typeof(EMSButtons), new PropertyMetadata("", new PropertyChangedCallback(IconChanged)));
        private static void IconChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) { try { (d as EMSButtons).Icon = (string)e.NewValue; } catch (Exception ex) { } }

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
                        this.Content = ContentS;
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
