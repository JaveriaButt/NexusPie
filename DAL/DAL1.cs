using Models;
using System;
using System.Collections.Generic; 
using System.Net; 
using System.Threading;
using System.Threading.Tasks;
using Resources;
using System.Data; 
using System.Data.SqlClient; 
using System.Xml.Serialization;
using System.IO;
using System.Text;

namespace DAL
{
    public static class DAL1
    {

        #region varaibels 
         

        static string AppId = Config.GetKeyValue("APPID").ToString();
        static int SRequestTimeout = Convert.ToInt16(Config.GetKeyValue("SRequestTimeout"));
        private static List<Error> ErrorList = null;
        static string ServiceURL =  Config.GetKeyValue("URL");
        static bool IsServerConnected = false;

         
        #endregion

        private static CancellationTokenSource _cancelTasks;
        public static string ServerRequest(string ActionName,object objectValue)
        {

            _cancelTasks = new CancellationTokenSource();
            string Response = null;
            var task = new Task(() =>
            {
                try
                {
                    using (var wb = new WebClient())
                    {
                        var JsonString = Newtonsoft.Json.JsonConvert.SerializeObject(objectValue);
                        wb.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                        wb.Headers[HttpRequestHeader.Accept] = "application/json"; 
                        wb.Encoding = Encoding.UTF8;
                        string a = ServiceURL + ActionName;
                        //wb.UploadString(ServiceURL + ActionName, JsonString);
                          wb.Encoding = Encoding.UTF8;  
                         var response = wb.UploadString(ServiceURL + ActionName, JsonString); 
                         Response = response;
                         IsServerConnected = true;
                    } 
                }
                catch (Exception ex)
                {
                }
            }, _cancelTasks.Token);
            task.Start();
            if (!task.Wait(SRequestTimeout * 1000))
            {
                Response = "TIMEOUT";
                _cancelTasks.Cancel();
            }
            return Response;
        }

        private static string ServerGetRequest(string ActionName)
        {

            _cancelTasks = new CancellationTokenSource();
            string Response = null;
            var task = new Task(() =>
            {
                try
                { 
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ServiceURL + ActionName);//
                    request.Method = "Get";
                    request.KeepAlive = true;
                    request.ContentType = "appication/json";
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse(); 
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(response.GetResponseStream()))
                    {
                        Response = sr.ReadToEnd();
                    }
                    
                    IsServerConnected = true;
                }
                catch (Exception ex)
                {
                }
            }, _cancelTasks.Token);
            task.Start();
            if (!task.Wait(SRequestTimeout * 1000))
            {
                Response = "TIMEOUT";
                _cancelTasks.Cancel();
            }
            return Response;
        }

        public static FunctionResponse<string> SaveSingleStudent(Student student)
        {
            FunctionResponse<string> Response = new FunctionResponse<string>();
            Response.Success = false;
            try
            {
                Response.ResponseMessage = ServerRequest("Student/SaveSingleStudent", student);
                Response.Success = true;
            }
            catch (Exception ex)
            {
                Response.ResponseMessage = ex.Message;
                Response.Success = false;
            }
            return Response;
        }

        public static FunctionResponse<List<Student>> GetAllStudent()
        {
            FunctionResponse<List<Student>> Response = new FunctionResponse<List<Student>>();
            Response.Success = false;
            try
            {

                var response = ServerGetRequest("Student/GetAllStudent");

                Response = Newtonsoft.Json.JsonConvert.DeserializeObject<FunctionResponse<List<Student>>>(response);
                
            }
            catch (Exception ex)
            {
                Response.ResponseMessage = ex.Message;
                Response.Success = false;
            }
            return Response;
        }

        public static AppDesign GetAppDesignfromDB()
        {
            AppDesign Response = new AppDesign();
            try
            {
                string ResponseString = string.Empty;
                string SqlConnectionString = @"Server=.;Database=SES;User Id=sa;Password=Sa123;";
                SqlConnection con = new SqlConnection(SqlConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("HomeMenuControlSetting", con);
                cmd.CommandType = CommandType.StoredProcedure;
                var rdr = cmd.ExecuteReader();
                if (rdr != null)
                {
                    while (rdr.Read())
                    {
                        ResponseString += rdr[0].ToString();
                    }
                }
                if (!string.IsNullOrWhiteSpace(ResponseString))
                {

                    XmlSerializer serializer = new XmlSerializer(typeof(List<ControlsSetting>), new XmlRootAttribute("AppDesign"));
                    StringReader stringReader = new StringReader(ResponseString);
                    Response.ControlSetting = (List<ControlsSetting>)serializer.Deserialize(stringReader);

                }
                con.Dispose();
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex) { }
            return Response;
        }

        public static List<DepartmentS> GetDepartment()
        {
            List<DepartmentS> Response = new List<DepartmentS>();
            try
            {
                var ServerResponse = ServerGetRequest("Depart/GetDepart");

            }
            catch (Exception ex) { }
            return Response;
        }
         
    }
}
