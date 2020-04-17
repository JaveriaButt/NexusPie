using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AppDesign : INotifyPropertyChanged
    {

        #region Property 

        private string m_HeaderImage = string.Empty;
        public string HeaderImage
        {
            set
            {
                if (m_HeaderImage != value)
                {
                    m_HeaderImage = value;
                    this.OnPropertyChanged("HeaderImage");
                }
            }
            get
            {
                return m_HeaderImage;
            }
        }


        private string m_HeaderText = string.Empty;
        public string HeaderText
        {
            set{
                if (m_HeaderText != value)
                {
                    m_HeaderText = value;
                    this.OnPropertyChanged("HeaderText");
                }
            }
            get { return this.m_HeaderText; }
        }


        private string m_FooterImage = string.Empty;
        public string FooterImage {

            set
            {
                if (m_FooterImage != value)
                {
                    m_FooterImage = value;
                    this.OnPropertyChanged("FooterImage");
                }
            }
            get {

                return this.m_FooterImage;

            }
            



        }

        private string m_FooterText = string.Empty;

        public string FooterText {
            set
            {
                if (m_FooterText != value)
                {
                    m_FooterText = value;
                    this.OnPropertyChanged("FooterText");
                }
            }
            get
            {
                return this.m_FooterText;
            }

        }
         

        private double m_AppWidth = 450;
        public double AppWidth
        {
            set
            {
                if (this.m_AppWidth != value)
                {
                    this.m_AppWidth = value;
                    this.OnPropertyChanged("AppWidth");
                }
            }
            get
            {
                return this.m_AppWidth;
            }
        }

        private double m_AppHeight = 720;
        public double AppHeight
        {
            set
            {
                if (this.m_AppHeight != value)
                {
                    this.m_AppHeight = value;
                    this.OnPropertyChanged("AppHeight");
                }
            }
            get
            {
                return this.m_AppHeight;
            }
        }


        private string m_TextBoxBackGround = "White";
        public string TextBoxBackGround
        {
            set
            {
                if (this.m_TextBoxBackGround != value)
                {
                    this.m_TextBoxBackGround = value;
                    this.OnPropertyChanged("TextBoxBackGround");
                }
            }
            get
            {
                return this.m_TextBoxBackGround;
            }
        }

        private string m_ButtonBackGround = "#00A699";
        public string ButtonBackGround
        {
            set
            {
                if (this.m_ButtonBackGround != value)
                {
                    this.m_ButtonBackGround = value;
                    this.OnPropertyChanged("ButtonBackGround");
                }
            }
            get
            {
                return this.m_ButtonBackGround;
            }
        }

        private string m_ButtonWidth = "150";
        public string ButtonWidth
        {
            set
            {
                if (this.m_ButtonWidth != value)
                {
                    this.m_ButtonWidth = value;
                    this.OnPropertyChanged("ButtonWidth");
                }
            }
            get
            {
                return this.m_ButtonWidth;
            }
        }

        private string m_ButtonHeight = "40";
        public string ButtonHeight
        {
            set
            {
                if (this.m_ButtonHeight != value)
                {
                    this.m_ButtonHeight = value;
                    this.OnPropertyChanged("ButtonHeight");
                }
            }
            get
            {
                return this.m_ButtonHeight;
            }
        }

        private string m_LabelBackGround = "Transparent";
        public string LabelBackGround
        {
            set
            {
                if (this.m_LabelBackGround != value)
                {
                    this.m_LabelBackGround = value;
                    this.OnPropertyChanged("LabelBackGround");
                }
            }
            get
            {
                return this.m_LabelBackGround;
            }
        }

        private string m_LabelFontColor = "Black";
        public string LabelFontColor
        {
            set
            {
                if (this.m_LabelFontColor != value)
                {
                    this.m_LabelFontColor = value;
                    this.OnPropertyChanged("LabelFontColor");
                }
            }
            get
            {
                return this.m_LabelFontColor;
            }
        }

        private string m_LabelFontSize = "15";
        public string LabelFontSize
        {
            set
            {
                if (this.m_LabelFontSize != value)
                {
                    this.m_LabelFontSize = value;
                    this.OnPropertyChanged("LabelFontSize");
                }
            }
            get
            {
                return this.m_LabelFontSize;
            }
        }

        private string m_LabelFontFamily = "Cairo";
        public string LabelFontFamily
        {
            set
            {
                if (this.m_LabelFontFamily != value)
                {
                    this.m_LabelFontFamily = value;
                    this.OnPropertyChanged("LabelFontFamily");
                }
            }
            get
            {
                return this.m_LabelFontFamily;
            }
        }

        private string m_TextBoxWidth = "220";
        public string TextBoxWidth
        {
            set
            {
                if (this.m_TextBoxWidth != value)
                {
                    this.m_TextBoxWidth = value;
                    this.OnPropertyChanged("TextBoxWidth");
                }
            }
            get
            {
                return this.m_TextBoxWidth;
            }
        }

        private string m_TextBoxHeight = "30";
        public string TextBoxHeight
        {
            set
            {
                if (this.m_TextBoxHeight != value)
                {
                    this.m_TextBoxHeight = value;
                    this.OnPropertyChanged("TextBoxHeight");
                }
            }
            get
            {
                return this.m_TextBoxHeight;
            }
        }

        private string m_TextBoxFontColor = "Black";
        public string TextBoxFontColor
        {
            set
            {
                if (this.m_TextBoxFontColor != value)
                {
                    this.m_TextBoxFontColor = value;
                    this.OnPropertyChanged("TextBoxFontColor");
                }
            }
            get
            {
                return this.m_TextBoxFontColor;
            }
        }

        private string m_ButtonFontColor = "Black";
        public string ButtonFontColor
        {
            set
            {
                if (this.m_ButtonFontColor != value)
                {
                    this.m_ButtonFontColor = value;
                    this.OnPropertyChanged("ButtonFontColor");
                }
            }
            get
            {
                return this.m_ButtonFontColor;
            }
        }

        private string m_AppFontFamily = "Cairo";
        public string AppFontFamily
        {
            set
            {
                if (this.m_AppFontFamily != value)
                {
                    this.m_AppFontFamily = value;
                    this.OnPropertyChanged("AppFontFamily");
                }
            }
            get
            {
                return this.m_AppFontFamily;
            }
        }



        private string m_ButtonFontSize = "15";
        public string ButtonFontSize
        {
            set
            {
                if (this.m_ButtonFontSize != value)
                {
                    this.m_ButtonFontSize = value;
                    this.OnPropertyChanged("ButtonFontSize");
                }
            }
            get
            {
                return this.m_ButtonFontSize;
            }
        }

        private string m_TextBoxFontSize = "18";
        public string TextBoxFontSize
        {
            set
            {
                if (this.m_TextBoxFontSize != value)
                {
                    this.m_TextBoxFontSize = value;
                    this.OnPropertyChanged("TextBoxFontSize");
                }
            }
            get
            {
                return this.m_TextBoxFontSize;
            }
        }

        private string m_AppFontSize  = "12";
        public string AppFontSize
        {
            set
            {
                if (this.m_AppFontSize != value)
                {
                    this.m_AppFontSize = value;
                    this.OnPropertyChanged("AppFontSize");
                }
            }
            get
            {
                return this.m_AppFontSize;
            }
        }
        private bool m_AppCenterScreen = false;
        public bool AppCenterScreen
        {
            set
            {
                if (this.m_AppCenterScreen != value)
                {
                    this.m_AppCenterScreen = value;
                    this.OnPropertyChanged("AppCenterScreen");
                }
            }
            get
            {
                return this.m_AppCenterScreen;
            }
        }

        private string m_OrgLogo = string.Empty;

        public string OrgLogo
        {
            set {
                if (m_OrgLogo != value)
                {
                    m_OrgLogo = value;
                    this.OnPropertyChanged("OrgLogo");
                }
            }
            get
            {
                return m_OrgLogo;
            }
        }

        private string m_OKButton = string.Empty;
        public string OKButton
        {
            set {if (m_OKButton != value)
                {
                    m_OKButton = value;
                    this.OnPropertyChanged("OKButton");
                }
            }
            get { return this.m_OKButton; }
        }

        private string m_OKButtonPressed = string.Empty;
        public string OKButtonPressed
        {
            set
            {
                if (m_OKButtonPressed != value)
                {
                    m_OKButtonPressed = value;
                    this.OnPropertyChanged("OKButtonPressed");
                }
            }
            get { return this.m_OKButtonPressed; }
        }

        private string m_SaveButton = string.Empty;
        public string SaveButton
        {
            set
            {
                if (m_SaveButton != value)
                {
                    m_SaveButton = value;
                    this.OnPropertyChanged("SaveButton");
                }
            }
            get { return this.m_SaveButton; }
        }

        private string m_SaveButtonPressed = string.Empty;
        public string SaveButtonPressed
        {
            set
            {
                if (m_SaveButtonPressed != value)
                {
                    m_SaveButtonPressed = value;
                    this.OnPropertyChanged("SaveButtonPressed");
                }
            }
            get { return this.m_SaveButtonPressed; }
        }


        private string m_CancelButton = string.Empty;
        public string CancelButton
        {
            set
            {
                if (m_CancelButton != value)
                {
                    m_CancelButton = value;
                    this.OnPropertyChanged("CancelButton");
                }
            }
            get { return this.m_CancelButton; }
        }


        private string m_CancelButtonPressed = string.Empty;
        public string CancelButtonPressed
        {
            set
            {
                if (m_CancelButtonPressed != value)
                {
                    m_CancelButtonPressed = value;
                    this.OnPropertyChanged("CancelButtonPressed");
                }
            }
            get { return this.m_CancelButtonPressed; }
        }

        private string m_CloseButton = string.Empty;
        public string CloseButton
        {
            set
            {
                if (m_CloseButton != value)
                {
                    m_CloseButton = value;
                    this.OnPropertyChanged("CloseButton");
                }
            }
            get { return this.m_CloseButton; }
        }
        private string m_CloseButtonPressed = string.Empty;
        public string CloseButtonPressed
        {
            set
            {
                if (m_CloseButtonPressed != value)
                {
                    m_CloseButtonPressed = value;
                    this.OnPropertyChanged("CloseButtonPressed" +
                        "");
                }
            }
            get { return this.m_CloseButtonPressed; }
        }

        private string m_ClearButton = string.Empty;
        public string ClearButton
        {
            set
            {
                if (m_ClearButton != value)
                {
                    m_ClearButton = value;
                    this.OnPropertyChanged("ClearButton");
                }
            }
            get { return this.m_ClearButton; }
        }
        private string m_ClearButtonPressed = string.Empty;
        public string ClearButtonPressed
        {
            set
            {
                if (m_ClearButtonPressed != value)
                {
                    m_ClearButtonPressed = value;
                    this.OnPropertyChanged("ClearButtonPressed");
                }
            }
            get { return this.m_ClearButtonPressed; }
        }
        private string m_DeleteButton = string.Empty;
        public string DeleteButton
        {
            set
            {
                if (m_DeleteButton != value)
                {
                    m_DeleteButton = value;
                    this.OnPropertyChanged("DeleteButton" +
                        "");
                }
            }
            get { return this.m_DeleteButton; }
        }

        private string m_DeleteButtonPressed = string.Empty;
        public string DeleteButtonPressed
        {
            set
            {
                if (m_DeleteButtonPressed != value)
                {
                    m_DeleteButtonPressed = value;
                    this.OnPropertyChanged("DeleteButtonPressed");
                }
            }
            get { return this.m_DeleteButtonPressed; }
        } 

        private string m_UpdateButton = string.Empty;
        public string UpdateButton
        {
            set
            {
                if (m_UpdateButton != value)
                {
                    m_UpdateButton = value;
                    this.OnPropertyChanged("UpdateButton");
                }
            }
            get { return this.m_UpdateButton; }
        }

        private string m_UpdateButtonPressed = string.Empty;
        public string UpdateButtonPressed
        {
            set
            {
                if (m_UpdateButtonPressed != value)
                {
                    m_UpdateButtonPressed = value;
                    this.OnPropertyChanged("UpdateButtonPressed");
                }
            }
            get { return this.m_UpdateButtonPressed; }
        }


        private string m_PrintButton = string.Empty;
        public string PrintButton
        {
            set
            {
                if (m_PrintButton != value)
                {
                    m_PrintButton = value;
                    this.OnPropertyChanged("PrintButton");
                }
            }
            get { return this.m_PrintButton; }
        }

        private string m_PrintButtonPressed = string.Empty;
        public string PrintButtonPressed
        {
            set
            {
                if (m_PrintButtonPressed != value)
                {
                    m_PrintButtonPressed = value;
                    this.OnPropertyChanged("PrintButtonPressed");
                }
            }
            get { return this.m_PrintButtonPressed; }
        }

        private string m_InformationIcon = string.Empty;
        public string InformationIcon
        {
            set
            {
                if (m_InformationIcon != value)
                {
                    m_InformationIcon = value;
                    this.OnPropertyChanged("InformationIcon");
                }
            }
            get { return this.m_InformationIcon; }
        }

        private string m_ErrorIcon = string.Empty;
        public string ErrorIcon
        {
            set
            {
                if (m_ErrorIcon != value)
                {
                    m_ErrorIcon = value;
                    this.OnPropertyChanged("ErrorIcon");
                }
            }
            get { return this.m_ErrorIcon; }
        }

        private string m_WarningIcon = string.Empty;
        public string WarningIcon
        {
            set
            {
                if (m_WarningIcon != value)
                {
                    m_WarningIcon = value;
                    this.OnPropertyChanged("WarningIcon");
                }
            }
            get { return this.m_WarningIcon; }
        }


        private List<ControlsSetting> m_ControlSetting = null;

        public List<ControlsSetting> ControlSetting
        {
            set {
                if (m_ControlSetting != value)
                {
                    m_ControlSetting = value;
                    this.OnPropertyChanged("ControlSetting");
                }
            }
            get { return this.m_ControlSetting; }
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
