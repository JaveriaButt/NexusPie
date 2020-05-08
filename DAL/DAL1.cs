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
using System.Collections.ObjectModel;

namespace DAL
{
    public static class DAL1
    {

        #region varaibels 
         

        static string AppId = Config.GetKeyValue("APPID").ToString();
        static int SRequestTimeout = Convert.ToInt16(Config.GetKeyValue("SRequestTimeout"));
        private static ObservableCollection<Error> ErrorObservableCollection = null;
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
                    Response = ex.Message;

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
        //saving department info
        public static FunctionResponse<string> SaveDepartmentInfo(DepartmentS dep)
        {
            FunctionResponse<string> Response = new FunctionResponse<string>();
            Response.Success = false;
            try
            {
                Response.ResponseMessage = ServerRequest("Depart/AddDepart", dep);
                Response.Success = true;
            }
            catch (Exception ex)
            {
                Response.ResponseMessage = ex.Message;
                Response.Success = false;
            }
            return Response;
        }
        //Updating department info
        public static FunctionResponse<string> UpdateDepartmentInfo(DepartmentS dep)
        {
            FunctionResponse<string> Response = new FunctionResponse<string>();
            Response.Success = false;
            try
            {
                Response.ResponseMessage = ServerRequest("Depart/UpdateDepart", dep);
                Response.Success = true;
            }
            catch (Exception ex)
            {
                Response.ResponseMessage = ex.Message;
                Response.Success = false;
            }
            return Response;
        }
        //deactivating department
        public static FunctionResponse<string> DeleteDepartmentInfo(DepartmentS dep)
        {
            FunctionResponse<string> Response = new FunctionResponse<string>();
            Response.Success = false;
            try
            {
                Response.ResponseMessage = ServerRequest("Depart/DeleteDepart", dep);
                Response.Success = true;
            }
            catch (Exception ex)
            {
                Response.ResponseMessage = ex.Message;
                Response.Success = false;
            }
            return Response;
        }
        public static FunctionResponse<ObservableCollection<Student>> GetAllStudent()
        {
            FunctionResponse<ObservableCollection<Student>> Response = new FunctionResponse<ObservableCollection<Student>>();
            Response.Success = false;
            try
            { 
                var response = ServerGetRequest("Student/GetAllStudent"); 
                Response = Newtonsoft.Json.JsonConvert.DeserializeObject<FunctionResponse<ObservableCollection<Student>>>(response);
                
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

                    XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<ControlsSetting>), new XmlRootAttribute("AppDesign"));
                    StringReader stringReader = new StringReader(ResponseString);
                    Response.ControlSetting = (ObservableCollection< ControlsSetting>)serializer.Deserialize(stringReader);

                }
                con.Dispose();
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex) { }
            return Response;
        }

        public static ObservableCollection<DepartmentS> GetDepartment()
        {
            ObservableCollection<DepartmentS> Response = new ObservableCollection<DepartmentS>();
            try
            {
                var ServerResponse = ServerGetRequest("Depart/GetDepart");
                var ResponseData = Newtonsoft.Json.JsonConvert.DeserializeObject<FunctionResponse<ObservableCollection<DepartmentS>>>(ServerResponse);
                if (ResponseData.Success)
                {
                    Response= ResponseData.Result;
                }

            }
            catch (Exception ex) { }
            return Response;
        }
         
    }
}
