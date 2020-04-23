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
                        var response = wb.UploadString("http://localhost:51455/api/"+ActionName, JsonString);
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


        public static FunctionResponse<string> InsertStudnetRecord(Student studentrec)
        {
            FunctionResponse<string> Response = new FunctionResponse<string>();
            try
            {

                string StudentXml = General.OBJECTTOXML(studentrec); 
                string Request = "<Input><Service><Service><Result>"+ StudentXml + "</Result></Input>";
                Response.Result = ServerRequest("",Request); 
                Response.Success = true;
            }
            catch (Exception ex)
            {

            }
            return Response;
        }



        public static void InsertProcedure(string storep, List<ProcdPerameter> ProcedureValues)
{
    try
    {
        using (SqlConnection con = new SqlConnection(ServiceURL))
        {
            using (SqlCommand cmd = new SqlCommand(storep, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                        foreach (ProcdPerameter SqlPerameter in ProcedureValues)
                        {
                            if (SqlPerameter.SqlType == SqlDbType.Int)
                            {
                                cmd.Parameters.Add(SqlPerameter.SqlColmName, SqlPerameter.SqlType).Value = int.Parse(SqlPerameter.Value);
                            }
                            else if (SqlPerameter.SqlType == SqlDbType.Float)
                            {
                                cmd.Parameters.Add(SqlPerameter.SqlColmName, SqlPerameter.SqlType).Value = float.Parse(SqlPerameter.Value);
                            }
                            else
                            {
                                cmd.Parameters.Add(SqlPerameter.SqlColmName, SqlPerameter.SqlType).Value =  SqlPerameter.Value;
                            }
                        }
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
    catch (Exception ex)
    { 
        
    }
}

        public static AppDesign GetAppDesignfromDB()
        {
            AppDesign Response  = new AppDesign();
            try
            {
                string ResponseString =string.Empty;
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

     

        


     



    }
}
