using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace SESWebService.Controllers
{
    public class SubjectController : ApiController
    { 
         public static string ConnectionString = Config.GetKeyValue("SqlConnectionString").ToString();

        [Route("api/Subject/AddSubjectInfo")]
         [System.Web.Http.HttpPost]
         public FunctionResponse<string> AddSubjectInfo(Subject subjectInfo)
         {
             FunctionResponse<string> Response = new FunctionResponse<string>();
             if (string.IsNullOrWhiteSpace(subjectInfo.SubjectName) || string.IsNullOrWhiteSpace(subjectInfo.SubjectCode) || string.IsNullOrWhiteSpace(subjectInfo.SubjectMarks) || string.IsNullOrWhiteSpace(subjectInfo.CreditHours))
             {
                 Response.ResponseMessage = "Empty Perameter";
                 Response.Success = false;
                 return Response;
             }
             else
             {
                 try
                 {
                     int x = Convert.ToInt32(subjectInfo.CreditHours);
                     double y = Convert.ToDouble(subjectInfo.SubjectMarks);
                 }
                 catch (Exception ex)
                 {
                     Response.ResponseMessage = "Invalid Perameter";
                     Response.Success = false;
                     return Response;
                 }
                 
             }
             try
             {
                 string Query = "insert into subject_info(sub_name,sub_code,sub_crh,sub_marks) values ('"
                     + subjectInfo.SubjectName + "','" + subjectInfo.SubjectCode + "'," + subjectInfo.CreditHours + "," + subjectInfo.SubjectMarks +");";
                 using (SqlConnection Connection = new SqlConnection(ConnectionString))
                 {
                     Connection.Open();
                     SqlCommand command = new SqlCommand(Query, Connection);
                     command.CommandType = System.Data.CommandType.Text;
                     command.ExecuteNonQuery();
                     Response.Result = "";

                     Response.ResponseMessage = "Subject Info Added Successfully";
                     Response.Success = true;
                 }
             }
             catch (Exception ex)
             {
                 Response.ResponseMessage = ex.Message;
                 Response.Success = false;
                 return Response;
             }
             return Response;
         }
    }
}