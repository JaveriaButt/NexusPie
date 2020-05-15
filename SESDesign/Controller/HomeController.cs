using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Models;
using Resources;

namespace SESDesign.Controller
{
    public class HomeController : INotifyPropertyChanged
    {

        public HomeController()
        {

        }

        #region Property


        private BaseScreen m_CurrentScreen = new BaseScreen(ScreenType.None);

        public BaseScreen CurrentScreen
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

        private ObservableCollection<DepartmentS> m_Department = null;

        public ObservableCollection<DepartmentS> Department
        {
            set
            {
                if (m_Department != value)
                {
                    m_Department = value;
                    this.OnPropertyChanged("Department");
                }
            }
            get
            {

                return this.m_Department;
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

        #endregion

        #region Functions

        public bool GetApplicationDesign()
        {
            bool Response = false;
            try
            {
                var DBResponse = DAL.DAL1.GetAppDesignfromDB();

                if (DBResponse != null)
                {
                    this.ApplicationDesign = DBResponse;
                     
                }
                string DebugFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).ToString().Substring(6);
                if (!string.IsNullOrWhiteSpace(DebugFolder) && System.IO.Directory.Exists(DebugFolder))
                {
                    string OrganizationFolder = DebugFolder + "\\Settings\\App\\" + ConfigurationManager.AppSettings["APPID"].ToString() + "\\";
                    if (!string.IsNullOrWhiteSpace(OrganizationFolder) && System.IO.Directory.Exists(OrganizationFolder))
                    {
                        string FilePath = OrganizationFolder + "ApplicationDesign.xml";
                        if (!string.IsNullOrWhiteSpace(FilePath) && System.IO.File.Exists(FilePath))
                        {
                            string XML = System.IO.File.ReadAllText(FilePath);
                            if (!string.IsNullOrWhiteSpace(XML))
                            {
                                XML = XML.Replace("\\Settings\\App\\", DebugFolder + "\\Settings\\App\\");
                                var appDesign = (AppDesign)General.XMLToOBJECT(XML, typeof(AppDesign));

                                foreach (PropertyInfo property in typeof(AppDesign).GetProperties().Where(p => p.CanRead))
                                {
                                    if (property.GetValue(ApplicationDesign, null) == null || property.GetValue(ApplicationDesign, null).ToString() == string.Empty && (property.GetValue(appDesign, null) != null && property.GetValue(appDesign, null).ToString() != string.Empty))
                                    {

                                        property.SetValue(ApplicationDesign, property.GetValue(appDesign, null), null);

                                    }
                                }

                                if (appDesign.AppWidth.ToString() != string.Empty) 
                                    this.ApplicationDesign.AppWidth = appDesign.AppWidth;  
                                if(appDesign.AppHeight.ToString() != string.Empty) 
                                    this.ApplicationDesign.AppHeight = appDesign.AppHeight;

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
                var DBResponse = DAL.DAL1.GetDepartment();

                if (DBResponse != null && DBResponse.Count > 0)
                {
                    Department = DBResponse;
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            return Response;
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