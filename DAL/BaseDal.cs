using Models;
using Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public abstract class BaseDal
    { 

        public BaseDal()
        {
            try { } catch (Exception ex) { }
        }

        #region varaibels 

        static string AppId = Config.GetKeyValue("APPID").ToString();
        static int SRequestTimeout = Convert.ToInt16(Config.GetKeyValue("SRequestTimeout"));
        private static List<Error> ErrorList = null;
        static string ServiceURL = Config.GetKeyValue("URL");
        static bool IsServerConnected = false;


        #endregion
        public static ObservableCollection<DepartmentS> DepartmentList()
        {
            ObservableCollection<DepartmentS> Departmentlist = new ObservableCollection<DepartmentS>();
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Select_dep", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                                Departmentlist.Add(new DepartmentS { DepName = dr[0].ToString(), DepID = dr[0].ToString() });
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex) { }
            return Departmentlist;
        }

        public static ObservableCollection<BatchS> BatchList()
        {
            ObservableCollection<BatchS> ResponseList = new ObservableCollection<BatchS>();
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Select_dep", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                                ResponseList.Add(new BatchS {  BatchID = dr[0].ToString(), BatchName = dr[0].ToString() });
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex) { }
            return ResponseList;
        }


        #region Applicaiton Setting 

        public static AppDesign LoadApplicaitonDesign()
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

        public static OrgInfo LoadOrgInfo()
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
            catch (Exception ex)
            {

            }
            return Design;
        }


        #endregion

        public static Error GetErrorByID(string ID)
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

        public static List<Error> XMLTOERRORLIST(string XML)
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

        public static string GetDefaultPath(string FileName)
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

    }
}
