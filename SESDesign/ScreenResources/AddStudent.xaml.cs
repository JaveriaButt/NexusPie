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

namespace SESDesign.ScreenResources
{
    /// <summary>
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : UserControl
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void EMSButtons_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tb_FName.Text) || string.IsNullOrWhiteSpace(tb_RegNumber.Text) || string.IsNullOrWhiteSpace(tb_stdName.Text) || string.IsNullOrWhiteSpace(tb_StdRNo.Text) || Cmb_Batch.SelectedItem != null && Cmb_Department.SelectedItem != null || Cmb_Session.SelectedItem != null)
                {
                    MessageBox.Show("Please Complete Mandotary Fields ..!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                Student AddStudent = new Student();
                AddStudent.StudentName = tb_stdName.Text;
                AddStudent.StudentFName = tb_FName.Text;
                AddStudent.StudentMobile = tb_ContactNumber.Text;
                AddStudent.StudentRollNumber = tb_StdRNo.Text;
                AddStudent.StudentCNIC = tb_CNIC.Text;
                AddStudent.Session = Cmb_Session.Text;
                AddStudent.RegistrationNo = tb_RegNumber.Text;
                AddStudent.NoteAddational = tb_AddationalNote.Text;
                AddStudent.ImagePath = ((BitmapFrame)StudentImagePath.Source).Decoder.ToString();
                AddStudent.Department = Cmb_Department.Text;
                AddStudent.Batch = Cmb_Batch.Text;
                AddStudent.Disability = tb_Disablity.Text;
                if ((bool)FemaleRadioButton.IsChecked)
                {
                    AddStudent.Gender = "Female";

                } else if ((bool)MaleRadioButton.IsChecked)
                {
                    AddStudent.Gender = "Male";
                }
                AddStudent.NoteAddational = tb_AddationalNote.Text;
               var Response =    DAL.DAL1.SaveSingleStudent(AddStudent);
                if (Response.Success)
                {
                    MessageBox.Show(Response.ResponseMessage); 
                    return;
                }
                else if (!Response.Success)
                {
                    MessageBox.Show(Response.ResponseMessage);
                    return;
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
