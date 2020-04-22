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
    /// Interaction logic for SearchStudent.xaml
    /// </summary>
    public partial class SearchStudent : UserControl
    {
        public SearchStudent()
        {
            InitializeComponent();
            Student SearchStudent = new Student();
            DAL.DAL1.ServerRequest("Student/SearchStudent",SearchStudent);

        }
    }
}
