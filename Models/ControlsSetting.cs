using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ControlsSetting : INotifyPropertyChanged
    {

        private string m_Module = string.Empty;

        public string Module
        {
            set
            {
                if (m_Module != value)
                {
                    m_Module = value;
                    this.OnPropertyChanged("Module");
                }
            }
            get
            {
                return this.m_Module;
            }
        }


        private string m_SubModule = string.Empty;

        public string SubModule
        {
            set {
                if (m_SubModule != value)
                {
                    m_SubModule = value;
                    this.OnPropertyChanged("SubModule");
                }
            }
            get {

                return this.m_SubModule;
            }
        }


        private string m_ControlName = string.Empty;

        public string ContorlName
        {
            set {
                if(m_ControlName != value)
                { this.m_ControlName = value;
                    this.OnPropertyChanged("ControlName");
                }
            }
            get {
                return this.m_ControlName;
            }
        }

        private string m_HeaderText = string.Empty;

        public string HeaderText
        { set {
                if (m_HeaderText != value)
                {
                    this.m_HeaderText = value;
                    this.OnPropertyChanged("HeaderText");
                }
            }
            get { return this.m_HeaderText; }
        }

        private string m_FontFamily = string.Empty;
        public string FontFamily
        {

            set
            {
                if (m_FontFamily != value)
                {
                    m_FontFamily = value;
                    this.OnPropertyChanged("FontFamily");
                }
            }
            get
            {
                return this.m_FontFamily;
            }
        }

        private string m_FontSize = string.Empty;

        public string FontSize
        {
            set {  if(m_FontSize != value)
                    { this.m_FontSize = value;
                    this.OnPropertyChanged("FontSize");
                }
            }
            get { return this.m_FontSize; }
        }


        private string m_FontColor = string.Empty;

        public string FontColor
        {
            set {
                if (m_FontColor != value)
                {
                    m_FontColor = value;
                    this.OnPropertyChanged("FontColor");
                }

            }
            get {
                return this.m_FontColor;
            }

        }

        private string m_ControlBackgroundColor = string.Empty;

        public string BackgroundColor
        {
            set {
                if (m_ControlBackgroundColor != value)
                {
                    m_ControlBackgroundColor = value;
                    this.OnPropertyChanged("BackgroundColor");
                }

            }
            get {
                return this.m_ControlBackgroundColor;
            }
        }

        private string m_Height = string.Empty;

        public string Height
        {
            set {
                if (m_Height != value)
                {
                    m_Height = value;
                    this.OnPropertyChanged("Height");
                }
            }
            get { return this.m_Height; }
        }

        private string m_Width = string.Empty;

        public string Width
        {
            set {
                if (m_Width != value)
                { m_Width = value;
                    this.OnPropertyChanged("Width");
                }
            }
            get {
                return this.m_Width;
            }
        }


        private string m_margin = string.Empty;

        public string Margin
        {
            set { if (m_margin != value)
                {
                    m_margin = value;
                    this.OnPropertyChanged("Margin");
                }
            }
            get { return this.m_margin; }
        }

        private string m_BorderBrush = string.Empty;

        public string BorderColor
        {
            set { if (m_BorderBrush != value)
                {
                    this.m_BorderBrush = value;
                    this.OnPropertyChanged("BorderColor");
                } }
            get
            {
                return this.m_BorderBrush;
            }
        }

        private string m_BorderSize = string.Empty;

        public string BorderBrushSize
        {

            set { if (m_BorderSize != value)
                {
                    m_BorderSize = value;
                    this.OnPropertyChanged("BorderBrushSize");
                } }
            get {
                return this.m_BorderSize;
            }

        }

        private string m_SettingKey = string.Empty;

        public string SettingKey
        {
            set { if (this.m_SettingKey != value)
                { this.m_SettingKey = value;
                    this.OnPropertyChanged("SettingKey");
                } }
            get {
                return this.m_SettingKey;
            }
        }

        private string m_SettingValue = string.Empty;

        public string SettingValue
        {
            set {  if (this.m_SettingValue != value)
                { this.m_SettingValue = value;
                    this.OnPropertyChanged("SettingValue");
                } }
            get { return this.m_SettingValue; }
        }


        private string m_ImagePath = string.Empty;

        public string ImagePath
        { set { if (m_ImagePath != value)
                {
                    m_ImagePath = value;
                    this.OnPropertyChanged("ImagePath"); } }
            get { return this.m_ImagePath; }
        }

        private string m_IsEnable = string.Empty;

        public string IsEnable
        { set { if (m_IsEnable != value)
                { m_IsEnable = value;
                    this.OnPropertyChanged("IsEnable");
                } }
            get { return this.m_IsEnable; }
        }








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
