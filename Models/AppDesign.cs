using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
         private string m_AppIcon = string.Empty;
        public string AppIcon
        {
            set
            {
                if (m_AppIcon != value)
                {
                    m_AppIcon = value;
                    this.OnPropertyChanged("AppIcon");
                }
            }
            get
            {
                return m_AppIcon;
            }
        }


        #region Menubar Settting

        private string m_MenuBarNavigationImage = string.Empty;
        public string MenuBarNavigationImage
        {
            set
            {
                if (this.m_MenuBarNavigationImage != value)
                {
                    this.m_MenuBarNavigationImage = value;
                    this.OnPropertyChanged("MenuBarNavigationImage");
                }
            }
            get
            {
                return this.m_MenuBarNavigationImage;
            }
        }

        

        private string m_MenuBarBackground = string.Empty;
        public string MenuBarBackground
        {
            set
            {
                if (this.m_MenuBarBackground != value)
                {
                    this.m_MenuBarBackground = value;
                    this.OnPropertyChanged("MenuBarBackground");
                }
            }
            get
            {
                return this.m_MenuBarBackground;
            }
        }
        
        private string m_MenuItemBackground = "Transparent";
        public string MenuItemBackground
        {
            set
            {
                if (this.m_MenuItemBackground != value)
                {
                    this.m_MenuItemBackground = value;
                    this.OnPropertyChanged("MenuItemBackground");
                }
            }
            get
            {
                return this.m_MenuItemBackground;
            }
        }

        private string m_MenuItemOnPressBackground = "#CDE846";
        public string MenuItemOnPressBackground
        {
            set
            {
                if (this.m_MenuItemOnPressBackground != value)
                {
                    this.m_MenuItemOnPressBackground = value;
                    this.OnPropertyChanged("MenuItemOnPressBackground");
                }
            }
            get
            {
                return this.m_MenuItemOnPressBackground;
            }
        }


        private string m_MenuItemMouseOver = "#DAF7A6";
        public string MenuItemMouseOver
        {
            set
            {
                if (this.m_MenuItemMouseOver != value)
                {
                    this.m_MenuItemMouseOver = value;
                    this.OnPropertyChanged("MenuItemMouseOver");
                }
            }
            get
            {
                return this.m_MenuItemMouseOver;
            }
        }

        private string m_MenuItemFontSize = "15";
        public string MenuItemFontSize
        {
            set
            {
                if (this.m_MenuItemFontSize != value)
                {
                    this.m_MenuItemFontSize = value;
                    this.OnPropertyChanged("MenuItemFontSize");
                }
            }
            get
            {
                return this.m_MenuItemFontSize;
            }
        }
        
        private string m_SubMenuItemFontSize = "12";
        public string SubMenuItemFontSize
        {
            set
            {
                if (this.m_SubMenuItemFontSize != value)
                {
                    this.m_SubMenuItemFontSize = value;
                    this.OnPropertyChanged("SubMenuItemFontSize");
                }
            }
            get
            {
                return this.m_SubMenuItemFontSize;
            }
        }

        private string m_SubMenuItemBackground = "Green";
        public string SubMenuItemBackground
        {
            set
            {
                if (this.m_SubMenuItemBackground != value)
                {
                    this.m_SubMenuItemBackground = value;
                    this.OnPropertyChanged("SubMenuItemBackground");
                }
            }
            get
            {
                return this.m_SubMenuItemBackground;
            }
        }

        private string m_SubMenuItemOnPressBackground = "Red";
        public string SubMenuItemOnPressBackground
        {
            set
            {
                if (this.m_SubMenuItemOnPressBackground != value)
                {
                    this.m_SubMenuItemOnPressBackground = value;
                    this.OnPropertyChanged("SubMenuItemOnPressBackground");
                }
            }
            get
            {
                return this.m_SubMenuItemOnPressBackground;
            }
        }

        private string m_ScreensHeaderBackgrund = "#1f9cd9";
        
        public string ScreensHeaderBackgrund
        {
            get { return m_ScreensHeaderBackgrund; }
            set {
                if (m_ScreensHeaderBackgrund != value)
                {
                    m_ScreensHeaderBackgrund = value;
                    this.OnPropertyChanged("ScreensHeaderBackgrund");
                }
            }
        }


        private string m_ScreensHeaderForeground = "Black";

        public string ScreensHeaderForeground
        {
            get { return m_ScreensHeaderForeground; }
            set
            {
                if (m_ScreensHeaderForeground != value)
                {
                    m_ScreensHeaderForeground = value;
                    this.OnPropertyChanged("ScreensHeaderForeground");
                }
            }
        }

        private string m_ScreensHeaderFontiSize = "40";

        public string  ScreensHeaderFontiSize
        {
            get { return m_ScreensHeaderFontiSize; }
            set
            {
                if (m_ScreensHeaderForeground != value)
                {
                    m_ScreensHeaderFontiSize = value;
                    this.OnPropertyChanged("ScreensHeaderFontiSize");
                }
            }
        }

        private string m_UpdateButtonBackgroundImg = "";

        public string  UpdateButtonBackgroundImg
        {
            get { return m_UpdateButtonBackgroundImg; }
            set
            {
                if (m_UpdateButtonBackgroundImg != value)
                {
                    m_UpdateButtonBackgroundImg = value;
                    this.OnPropertyChanged("UpdateButtonBackgroundImg");
                }
            }
        }

          private string m_SelectButtonImg = "";

        public string  SelectButtonImg
        {
            get { return m_SelectButtonImg; }
            set
            {
                if (m_SelectButtonImg != value)
                {
                    m_SelectButtonImg = value;
                    this.OnPropertyChanged("SelectButtonImg");
                }
            }
        }


        #endregion

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
        
        private string m_HeaderTextColor = "White";
        public string HeaderTextColor
        {
            set{
                if (m_HeaderTextColor != value)
                {
                    m_HeaderTextColor = value;
                    this.OnPropertyChanged("HeaderTextColor");
                }
            }
            get { return this.m_HeaderTextColor; }
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
         

        private double m_AppWidth = 850;
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
        
        private string m_btnCloseAppImg = "";
        public string BtnCloseAppImg
        {
            set
            {
                if (this.m_btnCloseAppImg != value)
                {
                    this.m_btnCloseAppImg = value;
                    this.OnPropertyChanged("BtnCloseAppImg");
                }
            }
            get
            {
                return this.m_btnCloseAppImg;
            }
        }
        private string m_btnMinimizeAppImg = "";
        public string BtnMinimizeAppImg
        {
            set
            {
                if (this.m_btnMinimizeAppImg != value)
                {
                    this.m_btnMinimizeAppImg = value;
                    this.OnPropertyChanged("BtnMinimizeAppImg");
                }
            }
            get
            {
                return this.m_btnMinimizeAppImg;
            }
        }

        private string m_btnMaximizeAppImg = "";
        public string BtnMaximizeAppImg
        {
            set
            {
                if (this.m_btnMaximizeAppImg != value)
                {
                    this.m_btnMaximizeAppImg = value;
                    this.OnPropertyChanged("BtnMaximizeAppImg");
                }
            }
            get
            {
                return this.m_btnMaximizeAppImg;
            }
        }

        private string m_ProductOnPressImage = "";
        public string ProductOnPressImage
        {
            set
            {
                if (this.m_ProductOnPressImage != value)
                {
                    this.m_ProductOnPressImage = value;
                    this.OnPropertyChanged("ProductOnPressImage");
                }
            }
            get
            {
                return this.m_ProductOnPressImage;
            }
        }


        private string m_ProductImage = "";
        public string ProductImage
        {
            set
            {
                if (this.m_ProductImage != value)
                {
                    this.m_ProductImage = value;
                    this.OnPropertyChanged("ProductImage");
                }
            }
            get
            {
                return this.m_ProductImage;
            }
        }

        private string m_ProductButtonHeight = "90";
        public string ProductButtonHeight
        {
            set
            {
                if (this.m_ProductButtonHeight != value)
                {
                    this.m_ProductButtonHeight = value;
                    this.OnPropertyChanged("ProductButtonHeight");
                }
            }
            get
            {
                return this.m_ProductButtonHeight;
            }
        }

        private string m_Productbackground = "#ffffff";

        public string Productbackground
        {
            set
            {
                if(m_Productbackground != value)
                {
                    m_Productbackground = value;
                    this.OnPropertyChanged("Productbackground");
                }
            }
            get
            {
                return m_Productbackground;
            }
        }

        private string m_ProductMouseOverbackground = "Skyblue";

        public string ProductMouseOverbackground
        {
            set
            {
                if (m_ProductMouseOverbackground != value)
                {
                    m_ProductMouseOverbackground = value;
                    this.OnPropertyChanged("ProductMouseOverbackground");
                }
            }
            get
            {
                return m_ProductMouseOverbackground;
            }
        }

        private string m_ProductOnPressbackground = "#C5E0B4";

        public string ProductOnPressbackground
        {
            set
            {
                if (m_ProductOnPressbackground != value)
                {
                    m_ProductOnPressbackground = value;
                    this.OnPropertyChanged("ProductOnPressbackground");
                }
            }
            get
            {
                return m_ProductOnPressbackground;
            }
        }

        private string m_ProductBorderThickness = "2";

        public string ProductBorderThickness
        {
            set
            {
                if (m_ProductBorderThickness != value)
                {
                    m_ProductBorderThickness = value;
                    this.OnPropertyChanged("ProductBorderThickness");
                }
            }
            get
            {
                return m_ProductBorderThickness;
            }
        }
 
        private string m_ProductBorderColor = "Transparent"; 
        public string ProductBorderColor
        {
            set
            {
                if (m_ProductBorderColor != value)
                {
                    m_ProductBorderColor = value;
                    this.OnPropertyChanged("ProductBorderColor");
                }
            }
            get
            {
                return m_ProductBorderColor;
            }
        }

        private string m_ProductNameForeground = "#000000";
        public string ProductNameForeground
        {
            set
            {
                if (m_ProductNameForeground != value)
                {
                    m_ProductNameForeground = value;
                    this.OnPropertyChanged("ProductNameForeground");
                }
            }
            get
            {
                return m_ProductNameForeground;
            }
        }


        private string m_ProductNameFontSize = "12";
        public string ProductNameFontSize
        {
            set
            {
                if (m_ProductNameFontSize != value)
                {
                    m_ProductNameFontSize = value;
                    this.OnPropertyChanged("ProductNameFontSize");
                }
            }
            get
            {
                return m_ProductNameFontSize;
            }
        }

        private string m_ProductCodeForeground = "#000000";
        public string ProductCodeForeground
        {
            set
            {
                if (m_ProductCodeForeground != value)
                {
                    m_ProductCodeForeground = value;
                    this.OnPropertyChanged("ProductCodeForeground");
                }
            }
            get
            {
                return m_ProductCodeForeground;
            }
        }


        private string m_ProductCodeFontSize = "10";
        public string ProductCodeFontSize
        {
            set
            {
                if (m_ProductCodeFontSize != value)
                {
                    m_ProductCodeFontSize = value;
                    this.OnPropertyChanged("ProductCodeFontSize");
                }
            }
            get
            {
                return m_ProductCodeFontSize;
            }
        }


        private string m_ProductPriceForeground = "#C00000";
        public string ProductPriceForeground
        {
            set
            {
                if (m_ProductPriceForeground != value)
                {
                    m_ProductPriceForeground = value;
                    this.OnPropertyChanged("ProductPriceForeground");
                }
            }
            get
            {
                return m_ProductPriceForeground;
            }
        }


        private string m_ProductPriceFontSize = "12";
        public string ProductPriceFontSize
        {
            set
            {
                if (m_ProductPriceFontSize != value)
                {
                    m_ProductPriceFontSize = value;
                    this.OnPropertyChanged("ProductPriceFontSize");
                }
            }
            get
            {
                return m_ProductPriceFontSize;
            }
        }


        private string m_ProductButtonWidth = "150";
        public string ProductButtonWidth
        {
            set
            {
                if (this.m_ProductButtonWidth != value)
                {
                    this.m_ProductButtonWidth = value;
                    this.OnPropertyChanged("ProductButtonWidth");
                }
            }
            get
            {
                return this.m_ProductButtonWidth;
            }
        }

        private bool m_ShowMinimizeButton = true;
        public bool ShowMinimizeButton
        {
            set
            {
                if (this.m_ShowMinimizeButton != value)
                {
                    this.m_ShowMinimizeButton = value;
                    this.OnPropertyChanged("ShowMinimizeButton");
                }
            }
            get
            {
                return this.m_ShowMinimizeButton;
            }
        }

        private bool m_ShowMaximizeButton = true;
        public bool ShowMaximizeButton
        {
            set
            {
                if (this.m_ShowMaximizeButton != value)
                {
                    this.m_ShowMaximizeButton = value;
                    this.OnPropertyChanged("ShowMaximizeButton");
                }
            }
            get
            {
                return this.m_ShowMaximizeButton;
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

        #region DataGridSetting

        private ObservableCollection<GridColumn> m_DataGridColumon = null;
 
        public ObservableCollection<GridColumn> DataGridColumon
        {
            set
            {
                if (m_DataGridColumon != value)
                {
                    m_DataGridColumon = value;
                    this.OnPropertyChanged("DataGridColumon");
                }

            }
            get
            {
                return this.m_DataGridColumon;
            }
        }


        private string m_DataGridRowTextSize = "12";
        public string DataGridRowTextSize
        {
            set
            {
                if (this.m_DataGridRowTextSize != value)
                {
                    this.m_DataGridRowTextSize = value;
                    this.OnPropertyChanged("DataGridRowTextSize");
                }
            }
            get
            {
                return this.m_DataGridRowTextSize;
            }
        }

        private string m_UpdateButtonImage = string.Empty;
        public string UpdateButtonImage
        {
            set
            {
                if (this.m_UpdateButtonImage != value)
                {
                    this.m_UpdateButtonImage = value;
                    this.OnPropertyChanged("UpdateButton");
                }
            }
            get
            {
                return this.m_UpdateButtonImage;
            }
        }

        private string m_DeleteButtonImage = string.Empty;
        public string DeleteButtonImage
        {
            set
            {
                if (this.m_DeleteButtonImage != value)
                {
                    this.m_DeleteButtonImage = value;
                    this.OnPropertyChanged("DeleteButtonImage");
                }
            }
            get
            {
                return this.m_DeleteButtonImage;
            }
        }

        private string m_DataGridHeaderTextSize = "20";
        public string DataGridHeaderTextSize
        {
            set
            {
                if (this.m_DataGridHeaderTextSize != value)
                {
                    this.m_DataGridHeaderTextSize = value;
                    this.OnPropertyChanged("DataGridHeaderTextSize");
                }
            }
            get
            {
                return this.m_DataGridHeaderTextSize;
            }
        }

        private string m_DataGridHeaderBackground = "#008B8B";
        public string DataGridHeaderBackground
        {
            set
            {
                if (this.m_DataGridHeaderBackground != value)
                {
                    this.m_DataGridHeaderBackground = value;
                    this.OnPropertyChanged("DataGridHeaderBackground");
                }
            }
            get
            {
                return this.m_DataGridHeaderBackground;
            }
        }

        private string m_DataGridHeaderTextColor = "White";
        public string DataGridHeaderTextColor
        {
            set
            {
                if (this.m_DataGridHeaderTextColor != value)
                {
                    this.m_DataGridHeaderTextColor = value;
                    this.OnPropertyChanged("DataGridHeaderTextColor");
                }
            }
            get
            {
                return this.m_DataGridHeaderTextColor;
            }
        }
        

        private string m_DataGridSelectedRowBackColor = "#53C3D5";
        public string DataGridSelectedRowBackColor
        {
            set
            {
                if (this.m_DataGridSelectedRowBackColor != value)
                {
                    this.m_DataGridSelectedRowBackColor = value;
                    this.OnPropertyChanged("DataGridSelectedRowBackColor");
                }
            }
            get
            {
                return this.m_DataGridSelectedRowBackColor;
            }
        }


        private string m_SaleScreenbackground = string.Empty;

        public string SaleScreenbackground
        {
            set {

                if (m_SaleScreenbackground != value)
                {
                    m_SaleScreenbackground = value;
                    this.OnPropertyChanged("SaleScreenbackground");
                }
            }
            get
            {

                return m_SaleScreenbackground;
            }

        }
         


        private string m_OvalButtonBackground = "#D9D9D9";
        public string OvalButtonBackground
        {
            set
            {
                if (this.m_OvalButtonBackground != value)
                {
                    this.m_OvalButtonBackground = value;
                    this.OnPropertyChanged("OvalButtonBackground");
                }
            }
            get
            {
                return this.m_OvalButtonBackground;
            }
        }


        private string m_OvalButtonMouseOverbackground = "Skyblue";

        public string OvalButtonMouseOverbackground
        {
            set
            {
                if (m_OvalButtonMouseOverbackground != value)
                {
                    m_OvalButtonMouseOverbackground = value;
                    this.OnPropertyChanged("OvalButtonMouseOverbackground");
                }
            }
            get
            {
                return m_OvalButtonMouseOverbackground;
            }
        }

        private string m_OvalButtonOnPress = "White";
        public string OvalButtonOnPress
        {
            set
            {
                if (this.m_OvalButtonOnPress != value)
                {
                    this.m_OvalButtonOnPress = value;
                    this.OnPropertyChanged("OvalButtonOnPress");
                }
            }
            get
            {
                return this.m_OvalButtonOnPress;
            }
        }


        private string m_OvalButtonHeight = "35";
        public string OvalButtonHeight
        {
            set
            {
                if (this.m_OvalButtonHeight != value)
                {
                    this.m_OvalButtonHeight = value;
                    this.OnPropertyChanged("OvalButtonHeight");
                }
            }
            get
            {
                return this.m_OvalButtonHeight;
            }
        }
      
        private string m_OvalButtonWidth = "100";
        public string OvalButtonWidth
        {
            set
            {
                if (this.m_OvalButtonWidth != value)
                {
                    this.m_OvalButtonWidth = value;
                    this.OnPropertyChanged("OvalButtonWidth");
                }
            }
            get
            {
                return this.m_OvalButtonWidth;
            }
        }

        private string m_OvalButtonForeground = "Black";
        public string OvalButtonForeground
        {
            set
            {
                if (this.m_OvalButtonForeground != value)
                {
                    this.m_OvalButtonForeground = value;
                    this.OnPropertyChanged("OvalButtonForeground");
                }
            }
            get
            {
                return this.m_OvalButtonForeground;
            }
        }

        private string m_OvalButtonFontSize = "12";
        public string OvalButtonFontSize
        {
            set
            {
                if (this.m_OvalButtonFontSize != value)
                {
                    this.m_OvalButtonFontSize = value;
                    this.OnPropertyChanged("OvalButtonFontSize");
                }
            }
            get
            {
                return this.m_OvalButtonFontSize;
            }
        }

        private string m_DataGridRowHeight = "40";
        public string DataGridRowHeight
        {
            set
            {
                if (this.m_DataGridRowHeight != value)
                {
                    this.m_DataGridRowHeight = value;
                    this.OnPropertyChanged("DataGridRowHeight");
                }
            }
            get
            {
                return this.m_DataGridRowHeight;
            }
        }

        private string m_DataGridRowTextColor = "DarkBlue";
        public string DataGridRowTextColor
        {
            set
            {
                if (this.m_DataGridRowTextColor != value)
                {
                    this.m_DataGridRowTextColor = value;
                    this.OnPropertyChanged("DataGridRowTextColor");
                }
            }
            get
            {
                return this.m_DataGridRowTextColor;
            }
        }


        private string m_NextButtonImage = string.Empty;

        public string NextButtonImage
        {
            set {
                if (m_NextButtonImage != value)
                {
                    m_NextButtonImage = value;
                    this.OnPropertyChanged("NextButtonImage");
                }
            }
            get
            {
                return m_NextButtonImage;
            }
        }

        private string m_BackButtonImage = @"\Resources\0\Images\back.png";

        public string BackButtonImage
        {
            set
            {
                if (m_BackButtonImage != value)
                {
                    m_BackButtonImage = value;
                    this.OnPropertyChanged("BackButtonImage");
                }
            }
            get
            {
                return m_BackButtonImage;
            }
        }
          private string m_SearchImage = @"\Resources\0\Images\back.png";

        public string SearchImage
        {
            set
            {
                if (m_SearchImage != value)
                {
                    m_SearchImage = value;
                    this.OnPropertyChanged("SearchImage");
                }
            }
            get
            {
                return m_SearchImage;
            }
        }


        private string m_FontFamily = "Cairo";
        public string FontFamily
        {
            set
            {
                if (this.m_FontFamily != value)
                {
                    this.m_FontFamily = value;
                    this.OnPropertyChanged("FontFamily");
                }
            }
            get
            {
                return this.m_FontFamily;
            }
        }
         
        #endregion 


        private ObservableCollection<ControlsSetting> m_ControlSetting = null;

        public ObservableCollection<ControlsSetting> ControlSetting
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
