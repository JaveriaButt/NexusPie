using System;
using System.Collections.Generic;
using System.ComponentModel;
using Models;
using Resources;
using System.Windows.Input; 
using System.Windows.Controls;
using System.Windows;
using System.Configuration;
using System.Data;
using BusinessLogic;
using System.Reflection;
using System.Collections.ObjectModel;

namespace NPIE.Controller
{
    public class HomeController : INotifyPropertyChanged
    {

        private BaseBL m_BusinessLogic = (BaseBL)Assembly.GetAssembly(typeof(BaseBL)).CreateInstance(("BusinessLogic.BaseBL"));
        public BaseBL BusinessLogic
        {
            set
            {
                if (this.m_BusinessLogic != value)
                {
                    this.m_BusinessLogic = value;
                    this.OnPropertyChanged("BusinessLogic");
                }
            }
            get
            {
                return this.m_BusinessLogic;
            }
        }
        public HomeController()
        {

        }

        #region Property


        private BaNPIEScreen m_CurrentScreen = new BaNPIEScreen();

        public BaNPIEScreen CurrentScreen
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

       

       

   
        private RefernceValues m_RefernceValues =   new RefernceValues();

        public void SetScreen(BaNPIEScreen userControl)
        {
            try
            {
                CurrentScreen = null;
                CurrentScreen = userControl;
            }
            catch (Exception ex)
            { }
        }

        public RefernceValues ReferncValueS 
        {
            set
            {
                if(value!= m_RefernceValues)
                {
                    m_RefernceValues = value;
                    this.OnPropertyChanged("ReferncValueS");
                }
            }
            get { return m_RefernceValues; }
        
        }


        private BaNPIEScreen m_HomeScreen = new BaNPIEScreen();

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



        private AppDesign m_ApplicationDesign =  null;

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
 
        private AppConfiguration m_AppConfig = null;

        public AppConfiguration AppConfig
        {

            set
            {
                if (m_AppConfig != value)
                {
                    m_AppConfig = value;
                    this.OnPropertyChanged("AppConfig");
                }
            }
            get
            {
                return m_AppConfig;
            }
        }
 

        private object m_DataGridColumn = null;

        public object DataGridColumns
        {
            set
            { 
                if (m_DataGridColumn != value)
                {
                    m_DataGridColumn = value;
                    this.OnPropertyChanged("DataGridColumns");
                }
            }
            get
            {
                return m_DataGridColumn;
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

        private ObservableCollection<Product> m_ListOfItems = new ObservableCollection<Product>();

        public ObservableCollection<Product> ListOfItems
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

        private ObservableCollection<Product> m_SaleAbleItems = new ObservableCollection<Product>();

        public ObservableCollection<Product> SaleAbleItems
        {
            set
            {
                if (value != m_SaleAbleItems)
                {
                    m_SaleAbleItems = value;
                    this.OnPropertyChanged("SaleAbleItems");
                }
            }
            get
            {
                return m_SaleAbleItems;
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

        public bool GetAppConfigurations()
       {
            bool Response = false;
            try
            {
                var DBResponse = new AppConfiguration(); //   DAL.DAL1.GetAppDesignfromDB();

                if (DBResponse != null)
                {
                    this.AppConfig = DBResponse;

                }
                string DebugFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).ToString().Substring(6);
                if (!string.IsNullOrWhiteSpace(DebugFolder) && System.IO.Directory.Exists(DebugFolder))
                {
                    string OrganizationFolder = DebugFolder + "\\Resources\\" + ConfigurationManager.AppSettings["ResourceID"].ToString() + "\\";
                    if (!string.IsNullOrWhiteSpace(OrganizationFolder) && System.IO.Directory.Exists(OrganizationFolder))
                    {
                        string FilePath = OrganizationFolder + "AppConfiguration.xml";
                        if (!string.IsNullOrWhiteSpace(FilePath) && System.IO.File.Exists(FilePath))
                        {
                            string XML = System.IO.File.ReadAllText(FilePath);
                            if (!string.IsNullOrWhiteSpace(XML))
                            {
                                XML = XML.Replace("\\Resources\\", DebugFolder + "\\Resources\\");
                                AppConfig = (AppConfiguration)General.XMLToOBJECT(XML, typeof(AppConfiguration));
                                AppConfig.CustomImagesPath = DebugFolder + AppConfig.CustomImagesPath;
                                Response = true;
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


        public bool LoadBasicReferneces()
        {

            try { GetAppConfigurations(); } catch (Exception ex) { }
            try { GetApplicationDesign(); } catch (Exception ex) { }


            bool Response = false;
            try
            {
                if (ReferncValueS.ProductCategories == null)
                {
                    var Categories = BusinessLogic.GetProductsCategories();
                    if (Categories.Success && Categories.Result != null)
                    {
                        ReferncValueS.ProductCategories = new ObservableCollection<Category>();
                        foreach (DataRow row in Categories.Result.Rows)
                        {
                            if(row["ID"].ToString() != "1")
                            ReferncValueS.ProductCategories.Add(new Category() { ID = row["ID"].ToString(), Name = row["Name"].ToString() });
                        }
                    }
                }
                if (ReferncValueS.ProductUnits == null)
                {
                    var UnitsOfMeasure = BusinessLogic.GetUnitOfMeasure();
                    if (UnitsOfMeasure.Success)
                    {
                        ReferncValueS.ProductUnits = UnitsOfMeasure.Result;
                    }
                }
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
         
        public RoutedEventHandler DataGridButtonPressedEvent = null;
        public void DataGridButtonPressed(object Value)
        {
            try
            {
                if (DataGridButtonPressedEvent != null)
                {
                    this.DataGridButtonPressedEvent(Value, new RoutedEventArgs());
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void ShoWpopUp(UserControl userControl)
        {
            try
            {
                Window window = new Window()
                {

                    Content = userControl,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    SizeToContent =  SizeToContent.WidthAndHeight,
                    WindowStyle = WindowStyle.None,
                    ResizeMode = ResizeMode.NoResize

                };
                window.ShowDialog();
            }
            catch (Exception e)
            { }
        }

        public RoutedEventHandler SubmitToScreenEvent = null;
        public void SubmitToScreen(object Value)
        {
            try
            {
                if (SubmitToScreenEvent != null)
                {
                    this.SubmitToScreenEvent(Value, new RoutedEventArgs());
                }
            }
            catch (Exception ex)
            {

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