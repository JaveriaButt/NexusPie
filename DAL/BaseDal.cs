using Models;
using Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Text;
using System.Xml;
using System.Linq;
using System.Collections.Specialized;
using System.Windows;

namespace DAL
{
    public class BaseDaL : INotifyPropertyChanged
    {

        #region varaibels 

        static string ResourceID = Config.GetKeyValue("ResourceID").ToString();
        private static List<Error> ErrorList = null;
        static bool IsServerConnected = false; 
        #endregion



        #region Applicaiton Setting 

        public virtual AppDesign LoadApplicaitonDesign()
        {

            AppDesign Design = new AppDesign();
            try
            {
                string AppsDesign = GetDefaultPath("/ApplicationDesign.xml");
                string xmlString = System.IO.File.ReadAllText(AppsDesign);
                var VAlues = Resources.General.XMLToOBJECT(xmlString, typeof(AppDesign));
                Design = (AppDesign)VAlues;

            }
            catch (Exception ex)
            {

            }
            return Design;


        }

        public virtual OrgInfo LoadOrgInfo()
        {
            OrgInfo Design = new OrgInfo();
            try
            {
                if (!IsServerConnected)
                {
                    string XML = System.IO.File.ReadAllText(GetDefaultPath("/Orginfo.xml"));
                    Design = (OrgInfo)General.XMLToOBJECT(XML, typeof(OrgInfo));
                }
            }
            catch (Exception)
            {

            }
            return Design;
        }

        public AppConfiguration GetAppConfiguration()
        {
            AppConfiguration Response = null;
            try
            {
                Response = ((dynamic)Application.Current.Resources["AppViewModel"]).AppConfig as AppConfiguration;
            }
            catch (Exception)
            {

            }
            return Response;
        }



        #endregion


        #region Products

        public virtual string GetProductCodeByCategory(string CategoryID)
        {
            string Response = string.Empty;
            try
            {

                string XmlRequest = "<Root><HEADER><APPTYPE>" + GetAppConfiguration().APPType + "</APPTYPE><VERSION>1</VERSION><REQTYPE>ITEMS</REQTYPE><REQID>1.5</REQID><USER>Admin</USER></HEADER><DATA><CategoryID>" + CategoryID+ "</CategoryID></DATA></Root>";
                Response = GetServerResponse(XmlRequest); 
            }
            catch(Exception ex)
            { }
            return Response;
        }



        #endregion

















        #region App Resources

        public virtual Error GetErrorByID(string ID)
        {
            Error Response = new Error();
            try
            {
                if (ErrorList == null)
                {
                    string FilePath = GetDefaultPath("ErrorList.xml");
                    if (!string.IsNullOrWhiteSpace(FilePath) && System.IO.File.Exists(FilePath))
                    {

                        ErrorList = XMLTOERRORLIST(FilePath);

                    }
                }
                Response = ErrorList.Where(p => p.ID == ID).First();

            }
            catch (Exception ex)
            {

            }
            return Response;
        }

        public virtual List<Error> XMLTOERRORLIST(string XML)
        {

            List<Error> ErrorList = new List<Error>();
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(XML);
                XmlElement root = doc.DocumentElement;
                XmlNodeList nodes = root.SelectNodes("Table");
                foreach (XmlNode node in nodes)
                {
                    ErrorList.Add(new Error
                    {

                        EnglishMsg = node["Msg"].InnerText,
                        Code = node["ID"].InnerText,
                    });
                }
                return ErrorList;
            }
            catch (Exception ex)
            { }
            return ErrorList;
        }

        public virtual string GetDefaultPath(string FileName)
        {
            string FilePath = "";
            try
            {
                string DebugFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).ToString().Substring(6);
                if (!string.IsNullOrWhiteSpace(DebugFolder) && System.IO.Directory.Exists(DebugFolder))
                {
                    string OrganizationFolder = DebugFolder + "/Settings/App/" + ResourceID;
                    if (!string.IsNullOrWhiteSpace(OrganizationFolder) && System.IO.Directory.Exists(OrganizationFolder))
                    {
                        FilePath = OrganizationFolder + FileName;

                    }
                }
            }
            catch (Exception ex) { }
            return FilePath;
        }

        public FunctionResponse<DataSet> GetProductsCategories()
        {
            FunctionResponse<DataSet> Response = new FunctionResponse<DataSet>();
            try
            {

                string XmlRequest = "<Root><HEADER><APPTYPE>100001</APPTYPE><VERSION>1</VERSION><REQTYPE>INFO</REQTYPE><REQID>1</REQID><USER>Admin</USER></HEADER><DATA></DATA></Root>";
                string XmlResponse = GetServerResponse(XmlRequest);
                if (!string.IsNullOrWhiteSpace(XmlResponse))
                {
                    DataSet ds = General.XMLToDataSet(XmlResponse);
                    if (ds != null)
                    {
                        Response.Result = ds;
                        Response.Success = true;
                    }
                }
            }
            catch (Exception)
            { }
            return Response;
        }

        public FunctionResponse<DataSet> GetUnitOfMeasure()
        {
            FunctionResponse<DataSet> Response = new FunctionResponse<DataSet>();
            try
            {

                string XmlRequest = "<Root><HEADER><APPTYPE>100001</APPTYPE><VERSION>1</VERSION><REQTYPE>INFO</REQTYPE><REQID>2</REQID><USER>Admin</USER></HEADER><DATA></DATA></Root>";
                string XmlResponse = GetServerResponse(XmlRequest);
                if (!string.IsNullOrWhiteSpace(XmlResponse))
                {
                    DataSet ds = General.XMLToDataSet(XmlResponse);
                    if (ds != null)
                    {
                        Response.Result = ds;
                        Response.Success = true;
                    }
                }
            }
            catch (Exception)
            { }
            return Response;
        }
        #endregion

        #region Server Requests
        /// <summary>
        /// Default Method to get send request to Server
        /// </summary>
        /// <param name="ServiceURL"></param>
        /// <param name="XMLRequest"></param>
        /// <returns></returns>
        public string GetServerResponse(string XMLRequest)
        {
            string Response = null;
            try
            {

                using (var wb = new WebCleintEx())
                {
                    var data = new NameValueCollection
                    {
                        ["XMLString"] = XMLRequest
                    };
                    LOG.Save(" SERVICE REQUEST " + XMLRequest);
                    byte[] response = wb.UploadValues(GetAppConfiguration().ServiceURL, "POST", data);
                    Response = Encoding.UTF8.GetString(response).Replace('"', ' ');
                    LOG.Save(" SERVICE RESPONSE " + Response);
                }
            }
            catch (Exception)
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

    public class WebCleintEx : WebClient
    {
        public int TimeOut { get; set; } = 100000;
        public WebCleintEx(int TOut = 100000)
        {
            TimeOut = TOut;
        }
        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address);
            request.Timeout = TimeOut;
            return request;
        }
    }

}
