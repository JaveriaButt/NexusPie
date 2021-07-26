using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows;
using System.ComponentModel;
using Models;
using Resources;
using System.Windows.Input;
using System.Windows.Controls;

namespace NPIE.Controller
{
    public class HomeController : INotifyPropertyChanged
    {

        public HomeController()
        {

        }

        #region Property


        private UserControl m_CurrentScreen = null;

        public UserControl CurrentScreen
        {
            set
            {
                if (m_CurrentScreen != value)
                {
                    m_CurrentScreen = value;
                    this.OnPropertyChanged("CurrentScreen");
                } 
            }
            get
            {
                return this.m_CurrentScreen;
            }
        }

        private BaNPIEScreen m_HomeScreen = new BaNPIEScreen(ScreenType.None);

        public BaNPIEScreen  HomeScreen
        {
            set
            {
                if (m_HomeScreen != value)
                {
                    m_HomeScreen = value;
                    this.OnPropertyChanged("HomeScreen");
                }
            }
            get
            {
                return this.m_HomeScreen;
            }
        }



        private AppDesign m_ApplicationDesign = new AppDesign();

        public AppDesign ApplicationDesign
        {

            set
            {
                if (m_ApplicationDesign != value)
                {
                    m_ApplicationDesign = value;
                    this.OnPropertyChanged("ApplicationDesign");
                }
            }
            get
            {
                return m_ApplicationDesign;
            }
        }
 

        private object m_DataList = null;

        public object DataList
        {
            set
            {

                if (m_DataList != value)
                {
                    m_DataList = value;
                    this.OnPropertyChanged("DataList");
                }
            }
            get
            {
                return m_DataList;
            }
        }
         

        private OrgInfo m_Orginformation = null;

        public OrgInfo OrgInformation
        {
            set
            {
                if (m_Orginformation != value)
                {
                    m_Orginformation = value;
                    this.OnPropertyChanged("OrgInformation");
                }
            }
            get
            {
                return this.m_Orginformation;
            }
        }


        private List<Product> m_ListOfItems = new List<Product>();

        public List<Product> ListOfItems
        {
            set
            {
                if (value != m_ListOfItems)
                {
                    m_ListOfItems = value;
                    this.OnPropertyChanged("ListOfItems");
                }
            }
            get {
                return m_ListOfItems;
            }
        }


        private List<Product> m_ListOfCategory = new List<Product>();

        public List<Product> ListOfCategory
        {
            set
            {
                if (value != m_ListOfCategory)
                {
                    m_ListOfCategory = value;
                    this.OnPropertyChanged("ListOfCategory");
                }
            }
            get
            {
                return m_ListOfCategory;
            }
        }
        #endregion

        #region Functions

        public bool GetApplicationDesign()
        {
            bool Response = false;
            try
            {
                var DBResponse = new AppDesign(); //   DAL.DAL1.GetAppDesignfromDB();

                if (DBResponse != null)
                {
                    this.ApplicationDesign = DBResponse;
                     
                }
                string DebugFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).ToString().Substring(6);
                if (!string.IsNullOrWhiteSpace(DebugFolder) && System.IO.Directory.Exists(DebugFolder))
                {
                    string OrganizationFolder = DebugFolder + "\\Resources\\" + ConfigurationManager.AppSettings["ResourceID"].ToString() + "\\";
                    if (!string.IsNullOrWhiteSpace(OrganizationFolder) && System.IO.Directory.Exists(OrganizationFolder))
                    {
                        string FilePath = OrganizationFolder + "ApplicationDesign.xml";
                        if (!string.IsNullOrWhiteSpace(FilePath) && System.IO.File.Exists(FilePath))
                        {
                            string XML = System.IO.File.ReadAllText(FilePath);
                            if (!string.IsNullOrWhiteSpace(XML))
                            {
                                XML = XML.Replace("\\Resources\\", DebugFolder + "\\Resources\\");
                                ApplicationDesign = (AppDesign)General.XMLToOBJECT(XML, typeof(AppDesign));

                                //ApplicationDesign = appDesign;
                                //foreach (PropertyInfo property in typeof(AppDesign).GetProperties().Where(p => p.CanRead))
                                //{
                                //    if (property.GetValue(ApplicationDesign, null) == null || property.GetValue(ApplicationDesign, null).ToString() == string.Empty && (property.GetValue(appDesign, null) != null && property.GetValue(appDesign, null).ToString() != string.Empty))
                                //    {

                                //        property.SetValue(ApplicationDesign, property.GetValue(appDesign, null), null);

                                //    }
                                //}

                                //if (appDesign.AppWidth.ToString() != string.Empty) 
                                //    this.ApplicationDesign.AppWidth = appDesign.AppWidth;  
                                //if(appDesign.AppHeight.ToString() != string.Empty) 
                                //    this.ApplicationDesign.AppHeight = appDesign.AppHeight;

                                if (this.ApplicationDesign != null)
                                {
                                    Application.Current.Dispatcher.BeginInvoke((Action)(() =>
                                    {

                                        Application.Current.MainWindow.Width = this.ApplicationDesign.AppWidth;
                                        Application.Current.MainWindow.Height = this.ApplicationDesign.AppHeight;
                                        if (this.ApplicationDesign.AppCenterScreen)
                                            Application.Current.MainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                                        else
                                        {
                                            Application.Current.MainWindow.Left = 0;
                                            Application.Current.MainWindow.Top = 0;
                                        }
                                    }));
                                    Response = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Response;
        }

        public bool GetDepartmentList()
        {
            bool Response = false;
            try
            {
                //var DBResponse = new  //DAL.DAL1.GetDepartment();

                //if (DBResponse != null && DBResponse.Count > 0)
                //{
                //    Department = DBResponse;
                //    return true;
                //}
            }
            catch (Exception ex)
            {

            }
            return Response;
        }

        #endregion



        #region Wndows Commands 
        private DelegateCommand closeApplicationCommand;
        public ICommand CloseApplicationCommand
        {
            get
            {
                if (this.closeApplicationCommand == null)
                {
                    this.closeApplicationCommand = new DelegateCommand(CloseApplication);
                }
                return this.closeApplicationCommand;
            }
        }
        private void CloseApplication()
        {
            try
            {
                Application.Current.Shutdown();
            }
            catch (Exception ex)
            {

            }

        }

        private DelegateCommand minimizeApplicationCommand;
        public ICommand MinimizeApplicationCommand
        {
            get
            {
                if (this.minimizeApplicationCommand == null)
                {
                    this.minimizeApplicationCommand = new DelegateCommand(MinimizeApplication);
                }
                return this.minimizeApplicationCommand;
            }
        }
        private void MinimizeApplication()
        {
            try
            {
                Application.Current.MainWindow.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {

            }

        }

        private DelegateCommand maximizeApplicationCommand;
        public ICommand MaximizeApplicationCommand
        {
            get
            {
                if (this.maximizeApplicationCommand == null)
                {
                    this.maximizeApplicationCommand = new DelegateCommand(MaximizeApplication);
                }
                return this.maximizeApplicationCommand;
            }
        }
        private void MaximizeApplication()
        {
            try
            {
                if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                {
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                    Application.Current.MainWindow.Left = SystemParameters.PrimaryScreenWidth - Application.Current.MainWindow.Width - 5;
                    Application.Current.MainWindow.Top = SystemParameters.PrimaryScreenHeight - Application.Current.MainWindow.Height;
                    string DebugFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).ToString().Substring(6);
                    (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.BtnMaximizeAppImg = DebugFolder + "/Resources/" + ConfigurationManager.AppSettings["ResourceID"].ToString() + "/Images/MiximizeButton.png";


                }
                else
                {
                    string DebugFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).ToString().Substring(6);
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
                    (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.BtnMaximizeAppImg = DebugFolder + "/Resources/" + ConfigurationManager.AppSettings["ResourceID"].ToString() + "/Images/RestoreButton.png";

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
    public class DelegateCommand : ICommand
    {
        private Action _executeMethod;
        public DelegateCommand(Action executeMethod)
        {
            _executeMethod = executeMethod;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
        public void Execute(object parameter)
        {
            _executeMethod.Invoke();
        }
    }


}