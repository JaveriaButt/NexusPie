using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;
using SES.Controls;

namespace SES.Designs
{
    public partial class SingleStudents : Form
    {
        public SingleStudents()
        {
            InitializeComponent();

            DefaultSetting.AppSetting.DepartmentList.Add(new DepartmentS { DepName = "AAA", DepID = "100" });
            DefaultSetting.AppSetting.DepartmentList.Add(new DepartmentS { DepName = "AAB", DepID = "100" });
            DefaultSetting.AppSetting.DepartmentList.Add(new DepartmentS { DepName = "AAC", DepID = "100" });
            DefaultSetting.AppSetting.DepartmentList.Add(new DepartmentS { DepName = "AAD", DepID = "100" });
            DefaultSetting.AppSetting.DepartmentList.Add(new DepartmentS { DepName = "AAE", DepID = "100" });
        }

        private void mbtn_Close_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void mbtn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                //if (ControlsSetting.IsTextboxEmpty(this))
                //{
                //    ShowMessage.DisplayPOPUPDialog("  Error ...!!!!!! ", " Please Fill All Fields....!!!! ", ShowMessage.IconType.Error);
                //    return;
                //}
                Student NewStudent = new Student();
                NewStudent.StudentID = mtb_StudentrRegNo.Text.Trim();
                NewStudent.StudentName = mtb_studentName.Text.Trim();
                NewStudent.StudentRollNumber = mtb_StudentRNo.Text.Trim(); 
                NewStudent.Department = mcmb_DepartmentName.Text.Trim();
                NewStudent.NoteAddational = mtb_NoteEMPT.Text.Trim();
                NewStudent.StudentFName = mtb_StudentFName.Text.Trim();
                NewStudent.StudentCNIC = mtb_CnicNumber.Text.Trim();
                NewStudent.RegistrationNo = mtb_StudentrRegNo.Text.Trim();
                NewStudent.Batch = mcmb_BatchNumber.Text.Trim();
                NewStudent.SESsion = mCmb_SESsion.Text.Trim();
                NewStudent.StudentMobile = mtb_ContactNo.Text.Trim();
                NewStudent.ImagePath = StudentPicture.ImageLocation;
                FunctionResponse<string> Response = new FunctionResponse<string>(); //= DAL.InsertStudnetRecord(NewStudent); 
                if (Response != null && Response.Success == true)
                {

                    ShowMessage.DisplayPOPUPDialog("Information..!", "Record Saved Successfully", ShowMessage.IconType.Information);
                }
                else
                {
                    ShowMessage.DisplayPOPUPDialog("Error..!", Response.ResponseMessage, ShowMessage.IconType.Information);
                }

            }
            catch (Exception)
            {

            }
            Clear();
        }

        void Clear()
        {
            try
            {
                //ControlsSetting.ClearAll(this);
                StudentPicture.ImageLocation = null;
            }
            catch (Exception) { }
        }

        private void mbtn_Clear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
                DefaultSetting.AppSetting.DepartmentList.RemoveAt(0);
                DefaultSetting.AppSetting.DepartmentList.RemoveAt(1);
            }
            catch (Exception)
            { }
        }

        private void mbtn_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.Title = "Open Image";
                OFD.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                OFD.ShowDialog();

                StudentPicture.ImageLocation = OFD.FileName;
                StudentPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception) { }
        }

        private void SingleStudents_Load(object sender, EventArgs e)
        {
            try
            {
               
            }catch (Exception)
            { }
        }

        private void mcmb_DepartmentName_Enter_1(object sender, EventArgs e)
        {
            mcmb_DepartmentName.DataSource = null;
            mcmb_DepartmentName.DataSource = DefaultSetting.AppSetting.DepartmentList;
            mcmb_DepartmentName.DisplayMember = "DepName";
        }
    }
}
