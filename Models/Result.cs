using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Result : INotifyPropertyChanged
    {

        #region Property

        private string m_Department = string.Empty;

        public string Department
        {
            set
            {
                if (m_Department != value)
                {
                    m_Department = value;
                    this.OnPropertyChanged("Department");
                }
            }
            get
            {
                return this.m_Department;
            }
        }

        private string m_Batch = string.Empty;

        public string Batch
        {
            set {
                if (m_Batch != value)
                {
                    m_Batch = value;
                    this.OnPropertyChanged("Batch");
                }
            }
            get {
                return this.m_Batch;

            }
        }

        private string m_Semester = string.Empty;

        public string Semester
        {
            set { if (m_Semester != value)
                {
                    m_Semester = value;
                    this.OnPropertyChanged("Semester");
                } }
            get { return this.m_Semester; }
        }

        private string m_Specialization = string.Empty;

        public string Specialization
        {
            set {
                if (m_Specialization != value)
                {
                    m_Specialization = value;
                    this.OnPropertyChanged("Specialization");
                }
            }
            get { return this.m_Specialization; }
        }

        private string m_Session = string.Empty;

        public string Session {

            set {
                if (m_Session != value)
                {
                    m_Session = value;
                    this.OnPropertyChanged("Session");
                }
            }
            get { return this.m_Session; }

        }

        private ObservableCollection<Subject> m_Subjects = new ObservableCollection<Subject>();

        public ObservableCollection<Subject> Subjects
        { set
            {
                if (m_Subjects != value)
                {
                    m_Subjects = value;
                    this.OnPropertyChanged("Subjects");
                }
            }
            get {
                return this.m_Subjects;

            }
        }


        private ObservableCollection<Student> m_Students = new ObservableCollection<Student>();

        public ObservableCollection<Student> Students
        {
            set
            {
                if (m_Students != value)
                {
                    m_Students = value;
                    this.OnPropertyChanged("Students");
                }
            }
            get
            {
                return this.m_Students;

            }
        }


        #endregion



        #region Property Changed Event 
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion



    }
}
