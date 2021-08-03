using Models;
using Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public abstract class BaseDaL
    { 

        public BaseDaL()
        {
            try { } catch (Exception ex) { }
        }

        #region varaibels 

        static string AppId = Config.GetKeyValue("APPID").ToString(); 
        private static List<Error> ErrorList = null;
        static string ServiceURL = Config.GetKeyValue("URL");
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
            catch (Exception )
            {

            }
            return Design;
        }


        #endregion





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
                    string OrganizationFolder = DebugFolder + "/Settings/App/" + AppId;
                    if (!string.IsNullOrWhiteSpace(OrganizationFolder) && System.IO.Directory.Exists(OrganizationFolder))
                    {
                        FilePath = OrganizationFolder + FileName;

                    }
                }
            }
            catch (Exception ex) { }
            return FilePath;
        }

        public FunctionResponse<string> GetProductsCategories()
        {
            FunctionResponse<string> Response = new FunctionResponse<string>();
            try
            {

                string XmlRequest = "<Root><Header><Service>NEXUS_WPF</Service><Type>1</Type><ID>2</ID></Header><REQ></REQ></Root>";
                string XmlResponse = GetServerResponse(XmlRequest);
                if (!string.IsNullOrWhiteSpace(XmlResponse))
                {
                    DataSet ds = General.XMLToDataSet(XmlResponse);
                    if (ds != null)
                    {
                        Response.Result = XmlResponse;
                        Response.Success = true;
                    }
                    else
                    {
                        Response.Success = false;
                    }
                }
            }
            catch (Exception ex)
            { }
           return Response;
        }


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
                    var response = wb.UploadValues(ServiceURL, "POST", data);
                    Response = Encoding.UTF8.GetString(response);
                    LOG.Save(" SERVICE RESPONSE " + Response);
                }
            }
            catch (Exception ex)
            {
            }
            return Response;
        }




        #endregion


    }

    public class WebCleintEx : WebClient
    {
        public int TimeOut { get; set; } = 3000;
        public WebCleintEx(int TOut = 3000)
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
