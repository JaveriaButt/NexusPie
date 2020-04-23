using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
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

        private AppDesign m_ApplicationDesign = new AppDesign();

        public AppDesign ApplicationDesign
        {
           
            set {
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


        private List<DepartmentS> m_Department = null;

        public List<DepartmentS> Department
        {
            set
            {
                if (m_Department != value)
                {
                    m_Department = value;
                    this.OnPropertyChanged("Department");
                }
            }
            get {

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
                    return true;
                }
                string DebugFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).ToString().Substring(6);
                if (!string.IsNullOrWhiteSpace(DebugFolder) && System.IO.Directory.Exists(DebugFolder))
                {
                    string OrganizationFolder = DebugFolder + "\\Settings\\App\\" + ConfigurationManager.AppSettings["APPID"].ToString()+"\\" ;
                    if (!string.IsNullOrWhiteSpace(OrganizationFolder) && System.IO.Directory.Exists(OrganizationFolder))
                    {
                        string FilePath = OrganizationFolder + "ApplicationDesign.xml";
                        if (!string.IsNullOrWhiteSpace(FilePath) && System.IO.File.Exists(FilePath))
                        {
                            string XML = System.IO.File.ReadAllText(FilePath);
                            if (!string.IsNullOrWhiteSpace(XML))
                            {
                                XML = XML.Replace("/KIOSK_TYPE", DebugFolder + "\\KIOSK_TYPE");
                                this.ApplicationDesign = (AppDesign)General.XMLToOBJECT(XML, typeof(AppDesign));
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

                if (DBResponse != null && DBResponse.Count>0)
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
