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

namespace SESDesign.Screen
{
    /// <summary>
    /// Interaction logic for AddSubject.xaml
    /// </summary>
    public partial class AddSubject : UserControl
    {
        Models.Subject subjectInfo;
        public AddSubject()
        {
            InitializeComponent();
        }

        private void EMSButtons_Click(object sender, RoutedEventArgs e)
        {
            subjectInfo = new Models.Subject();
            subjectInfo.SubjectName = tb_SubName.Text;
            subjectInfo.SubjectCode = tb_code.Text;
            subjectInfo.SubjectMarks = tb_marks.Text;
            subjectInfo.CreditHours = tb_credits.Text;
            var res = DAL.DAL1.SaveSubjectInfo(subjectInfo);
            MessageBox.Show(res.Result);

        }

        private void EMSButtons_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void CloseAll_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
