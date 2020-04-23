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
    public class DepartController : ApiController
    {
        public static string ConnectionString = Config.GetKeyValue("SqlConnectionString").ToString();

        [Route("api/Depart/GetDepart")]
        [System.Web.Http.HttpGet]
        public FunctionResponse<List<DepartmentS>> GetDepart()
        {
            FunctionResponse<List<DepartmentS>> Response = new FunctionResponse<List<DepartmentS>>();
            try
            {
                string Query = "select * from Department_info";
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                {
                    Connection.Open();
                    SqlCommand command = new SqlCommand(Query, Connection);
                    command.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        Response.Result = new List<DepartmentS>();
                        while (dr.Read())
                        {
                            Response.Result.Add(new DepartmentS { DepHOD = dr["dep_hod"].ToString(), DepID = dr["id"].ToString(), DepName = dr["dep_name"].ToString() });
                        }
                        Response.ResponseMessage = "Record Found Successfully";
                        Response.Success = true;
                        return Response;
                    }
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
