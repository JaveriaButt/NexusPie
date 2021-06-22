using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NPIEDesign.Screen 
{
    /// <summary>
    /// Interaction logic for SearchStudent.xaml
    /// </summary>
    public partial class SearchStudent : UserControl
    {
        public SearchStudent()
        {
            InitializeComponent();
            try
            {
                StdData.Columns.Clear();
                //var ServerResponse = = new  DAL.DAL1.GetAllStudent();
                //if (ServerResponse.Success)
                //{
                //    StdData.ItemsSource = ServerResponse.Result;
                //}
            }
            catch (Exception ex)
            { 
            }
        }
        //public List<Student> LoadData()
        //{
        //    List<Student> std=new List<Student>();
        //    Student SearchStudent = new Student();
        //    SearchStudent.StudentName = "Javeria";
        //    SearchStudent.StudentFName = "M W Butt";
        //    SearchStudent.StudentID = "Comp.Sc-17008";
        //    SearchStudent.StudentCNIC = "12345";
        //    SearchStudent.Department = "CS";
        //    SearchStudent.NPIEsion = "2017-2021";
        //    std.Add(SearchStudent);
        //    return std;
        //}
    }
}
