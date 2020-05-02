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
                string Query = "select * from Department_info where isActive='True'";
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
        //Insert Department
        [Route("api/Depart/AddDepart")]
        [System.Web.Http.HttpPost]
        public FunctionResponse<string> AddDepart(DepartmentS dep)
        {
            FunctionResponse<string> Response = new FunctionResponse<string>();
            if(dep.DepName==string.Empty || dep.DepHOD==string.Empty)
            {
                Response.ResponseMessage = "Empty Perameter";
                Response.Success = false;
                return Response;
            }
            else
            {
                string query="select * from Department_info where dep_name = '" + dep.DepName + "';";
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                {
                    Connection.Open();
                    SqlCommand command = new SqlCommand(query, Connection);
                    command.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        Response.ResponseMessage = "Department with this Name Already Exists";
                        Response.Success = false;
                        return Response;
                    }
                }
               
            }
            try
            {
                string Query = "insert into Department_info(dep_name,dep_hod,isActive) values ('"+dep.DepName+"','"+dep.DepHOD+"' , 'True');";
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                {
                    Connection.Open();
                    SqlCommand command = new SqlCommand(Query, Connection);
                    command.CommandType = System.Data.CommandType.Text;
                    command.ExecuteNonQuery();
                    Response.Result = "";

                    Response.ResponseMessage = "Department Info Added Successfully";
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
        //Insert Department
        [Route("api/Depart/UpdateDepart")]
        [System.Web.Http.HttpPost]
        public FunctionResponse<string> UpdateDepart(DepartmentS dep)
        {
            FunctionResponse<string> Response = new FunctionResponse<string>();
            if (dep.DepName == string.Empty || dep.DepHOD == string.Empty)
            {
                Response.ResponseMessage = "Empty Perameter";
                Response.Success = false;
                return Response;
            }
            try
            {
                string Query = "UPDATE Department_info set dep_name = '" + dep.DepName + "', dep_hod='" + dep.DepHOD + "' where id="+dep.DepID+";";
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                {
                    Connection.Open();
                    SqlCommand command = new SqlCommand(Query, Connection);
                    command.CommandType = System.Data.CommandType.Text;
                    command.ExecuteNonQuery();
                    Response.Result = "";

                    Response.ResponseMessage = "Department Info Updated Successfully";
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
        //delete Department...... not actually deletion but deactivating department by changing property isActive to false
        //Insert Department
        [Route("api/Depart/DeleteDepart")]
        [System.Web.Http.HttpPost]
        public FunctionResponse<string> DeleteDepart(DepartmentS dep)
        {
            FunctionResponse<string> Response = new FunctionResponse<string>();
            if (dep.DepName == string.Empty || dep.DepHOD == string.Empty)
            {
                Response.ResponseMessage = "Empty Perameter";
                Response.Success = false;
                return Response;
            }
            try
            {
                string Query = "UPDATE Department_info set isActive = 'False' where id="+ dep.DepID + ";";
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                {
                    Connection.Open();
                    SqlCommand command = new SqlCommand(Query, Connection);
                    command.CommandType = System.Data.CommandType.Text;
                    command.ExecuteNonQuery();
                    Response.Result = "";

                    Response.ResponseMessage = "Department Deleted Successfully";
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
