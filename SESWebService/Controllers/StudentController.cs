using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http; 

namespace SESWebService.Controllers
{
    public class StudentController : ApiController
    {
        public static string ConnectionString = Config.GetKeyValue("SqlConnectionString").ToString();


        [Route("api/Student/SaveSingleStudent")]
        [System.Web.Http.HttpPost]
        public FunctionResponse<Student> SaveSingleStudent(Student student)
        {
            FunctionResponse<Student> Response = new FunctionResponse<Student>();
            try
            {
                if (string.IsNullOrWhiteSpace(student.StudentFName) || string.IsNullOrWhiteSpace(student.StudentName) || string.IsNullOrWhiteSpace(student.StudentRollNumber))
                {
                    Response.ResponseMessage = "Empty Perameter";
                    Response.Success = false;
                    return Response;
                } 

                 
                if (!string.IsNullOrWhiteSpace(student.StudentFName) && !string.IsNullOrWhiteSpace(student.StudentName) && !string.IsNullOrWhiteSpace(student.StudentRollNumber) && !string.IsNullOrWhiteSpace(student.RegistrationNo))
                {
                    string Query = "Insert into student_info(std_name,std_fathername,std_rollno,std_regno,std_Gender,std_CNIC,std_ContactNumber,std_Disablity," +
                      "std_ImagePath,std_Department,std_Batch,std_Note,std_session)" +
                " Values('" + student.StudentName + "','" + student.StudentFName + "','" + student.StudentRollNumber + "','" + student.RegistrationNo + "','" + student.Gender + "','" + student.StudentCNIC + "','" + student.StudentMobile + "','" +
                "" + student.Disability + "','" + student.ImagePath + "','" + student.Department + "','" + student.Batch + "','" + student.NoteAddational + "','" + student.Session + "')";
                    using (SqlConnection Connection = new SqlConnection(ConnectionString))
                    {
                        Connection.Open();
                        SqlCommand command = new SqlCommand(Query, Connection);
                        command.CommandType = System.Data.CommandType.Text;
                        command.ExecuteNonQuery();
                        Response.ResponseMessage = "Record Successfully Saved";
                        Response.Success = true;


                    }
                }
                else if(string.IsNullOrWhiteSpace(student.StudentName))
                {
                    Response.ResponseMessage = "Student Name Cannnot be Empty \n\r Please Enter Student Name";
                    Response.Success = false;

                }
                else if (string.IsNullOrWhiteSpace(student.StudentFName))
                {
                    Response.ResponseMessage = "Student Father Name Cannnot be Empty \n\r Please Enter Student Name";
                    Response.Success = false;

                }
                else if (string.IsNullOrWhiteSpace(student.RegistrationNo))
                {
                    Response.ResponseMessage = "Student Registration Number Cannnot be Empty \n\r Please Enter Student Name";
                    Response.Success = false;

                }
                else if (string.IsNullOrWhiteSpace(student.StudentRollNumber))
                {
                    Response.ResponseMessage = "Student Roll Number Cannnot be Empty \n\r Please Enter Student Name";
                    Response.Success = false;

                } 
            }
            catch (Exception ex)
            { }
            return Response; 
        }



        [Route("api/Student/SearchStudent")]
        [System.Web.Http.HttpPost]
        public FunctionResponse<List<Student>> SearchStudent(Student student)
        {
            FunctionResponse<List<Student>> Response = new FunctionResponse<List<Student>>();
            try
            {
                 string Query = "select std_name,std_fathername,std_rollno,std_Department,std_CNIC,std_session from student_info";
                    using (SqlConnection Connection = new SqlConnection(ConnectionString))
                    {
                        Connection.Open();
                        SqlCommand command = new SqlCommand(Query, Connection);
                        command.CommandType = System.Data.CommandType.Text;
                        SqlDataReader dr = command.ExecuteReader();
                        while(dr.Read())
                        {
                            Student std = new Student();
                            std.StudentName = dr[0].ToString();
                            std.StudentFName = dr[1].ToString();
                            std.StudentRollNumber = dr[2].ToString();
                            std.Department = dr[3].ToString();
                            std.StudentCNIC = dr[4].ToString();
                            std.Session = dr[5].ToString();

                            Response.Result.Add(std);
                        }

                        Response.ResponseMessage = "Record Found Successfully";
                        Response.Success = true;
                        return Response;
                    }
            }
            catch (Exception ex)
            { }
            return Response;
        }
    }
}
