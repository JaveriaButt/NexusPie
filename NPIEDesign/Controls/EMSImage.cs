using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace NPIEDesign.Controls
{
    public class EMSImage : System.Windows.Controls.Image, INotifyPropertyChanged
    {
        public EMSImage()
        {
            RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.HighQuality);
        }

        #region Properties  
        public static readonly DependencyProperty ImageContentProperty = DependencyProperty.Register("ContentImage", typeof(string), typeof(EMSImage), new PropertyMetadata("", new PropertyChangedCallback(BindableImagePropertyChanged)));
        private static void BindableImagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        { try
            {
                (d as EMSImage).ContentImage = (string)e.NewValue;
            } catch (Exception ex) { } }  
        private string m_ContentImage = string.Empty;
        public string ContentImage
        {
            set
            {
                if (this.m_ContentImage != value)
                {
                    this.m_ContentImage = value;
                    this.OnPropertyChanged("ContentImage");
                        SetContentToUI();
                }
            }
            get
            {
                return this.m_ContentImage;
            }
        }

      
      
        #endregion

        #region Functions
        private void SetContentToUI()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(this.ContentImage) )
                {  
                       this.Source = new BitmapImage(new Uri(""+ContentImage));

                    if (this.HorizontalAlignment == HorizontalAlignment.Left)
                    {
                        {
                            double MLeft = this.Margin.Left;
                            double MRight = this.Margin.Right;
                            double MTop = this.Margin.Top;
                            double MBottom = this.Margin.Bottom;
                            this.Margin = new Thickness(MRight, MTop, MLeft, MBottom);
                        }
                        this.HorizontalAlignment = HorizontalAlignment.Right;
                    }
                    else if (this.HorizontalAlignment == HorizontalAlignment.Right)
                    {  {
                                double MLeft = this.Margin.Left;
                                double MRight = this.Margin.Right;
                                double MTop = this.Margin.Top;
                                double MBottom = this.Margin.Bottom;
                                this.Margin = new Thickness(MRight, MTop, MLeft, MBottom);
                            }
                            this.HorizontalAlignment = HorizontalAlignment.Left;
                        }
                    
                }
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
