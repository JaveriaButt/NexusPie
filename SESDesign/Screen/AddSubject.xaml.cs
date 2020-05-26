using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Models;
using System.Collections.ObjectModel;
using System.Windows.Controls.Primitives;
using System.Data;
using System.Windows.Media.Effects;
using SESDesign.Controller;
using System.Collections.Specialized;
using System.ComponentModel;

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
            this.Loaded += Department_Loaded;
        }
        private void Department_Loaded(object sender, RoutedEventArgs e)
        {
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon = new ObservableCollection<GridColumn>();
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon.Add(new GridColumn { Width = "*", ColumnType = ColumnTypes.Text, Heading = "Course Code", Property = "SubjectCode" });
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon.Add(new GridColumn { Width = "*", ColumnType = ColumnTypes.Text, Heading = "Course Title", Property = "SubjectName" });
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon.Add(new GridColumn { Width = "*", ColumnType = ColumnTypes.Text, Heading = "Credit Hours", Property = "CreditHours" });
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon.Add(new GridColumn { Width = "*", ColumnType = ColumnTypes.Text, Heading = "Total Marks", Property = "SubjectMarks" });
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon.Add(new GridColumn { Width = "*", ColumnType = ColumnTypes.Button, IconWidth = 250, IconHeight = 100, Heading = "Update Record", Property = "Update" });
            (Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridColumon.Add(new GridColumn { Width = "*", ColumnType = ColumnTypes.Button, IconWidth = 250, IconHeight = 100, Heading = "Delete Record", Property = "Delete" });

            (Application.Current.Resources["AppViewModel"] as HomeController).DataList = DAL.DAL1.GetSubject();
            DataGRid.Content = new Screen.ScreenResources.DataGrid();

            (Application.Current.Resources["AppViewModel"] as HomeController).CurrentScreen.SendClickEvent += CurrentScreen_SendClickEvent;
        }

        private void CurrentScreen_SendClickEvent(object sender, RoutedEventArgs e)
        {
            if (sender != null)
            {
                string EventSender = (sender as ClickResponse).SENDER;
                if (EventSender == "Update")
                {
                    UpdateSubjectInfo((sender as ClickResponse).DataObject as Subject);
                }
                else if (EventSender == "Delete")
                {
                    DeleteSubjectInfo((sender as ClickResponse).DataObject as Subject);
                }
            }
        }
        string id = "";
        private void UpdateSubjectInfo(Subject subject)
        {
            tb_SubName.Text = subject.SubjectName;
            tb_code.Text = subject.SubjectCode ;
            tb_marks.Text=subject.SubjectMarks ;
            tb_credits.Text=subject.CreditHours;
            id = subject.SubjectID;
        }
        private void DeleteSubjectInfo(Subject subject)
        {
            //MessageBox.Show("Are You Sure You want to Deactivate this Department?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
            DAL.DAL1.DeleteSubjectInfo(subject);
            Clear();
        }
        private void EMSButtons_Click(object sender, RoutedEventArgs e)
        {
            subjectInfo = new Subject();
            subjectInfo.SubjectName = tb_SubName.Text;
            subjectInfo.SubjectCode = tb_code.Text;
            subjectInfo.SubjectMarks = tb_marks.Text;
            subjectInfo.CreditHours = tb_credits.Text;
            var res = DAL.DAL1.SaveSubjectInfo(subjectInfo); 
            Clear(); 
        }

        
     

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            subjectInfo = new Subject();
            subjectInfo.SubjectName = tb_SubName.Text;
            subjectInfo.SubjectCode = tb_code.Text;
            subjectInfo.SubjectMarks = tb_marks.Text;
            subjectInfo.CreditHours = tb_credits.Text;
            subjectInfo.SubjectID = id;
            DAL.DAL1.UpdateSubjectInfo(subjectInfo);
            Clear();

        }
        void Clear()
        {
            tb_SubName.Text = tb_code.Text = tb_marks.Text = tb_credits.Text = id = "";
            (Application.Current.Resources["AppViewModel"] as HomeController).DataList = DAL.DAL1.GetSubject();
            DataGRid.Content = new Screen.ScreenResources.DataGrid();
        }
    }
}
