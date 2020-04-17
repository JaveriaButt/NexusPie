using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student : INotifyPropertyChanged
    {

        #region Property 


        private string m_StudentName = string.Empty;
        
        public string StudentName
        {
            set
            {
                if (m_StudentName != value)
                {
                    m_StudentName = value;
                    this.OnPropertyChanged("StudentName");

                }
            }
            get { return this.m_StudentName; }
        }

        private string m_StudentFName = string.Empty;

        public string StudentFName
        {

            set {
                if (this.m_StudentFName != value)
                {
                    this.m_StudentFName = value;
                    this.OnPropertyChanged("StudentFName");
                } 
            }

            get {
                return this.m_StudentFName;
            }
        }

        private string m_StudentMobile = string.Empty;

        public string StudentMobile
        {

            set
            {
                if (this.m_StudentMobile != value)
                {
                    this.m_StudentMobile = value;
                    this.OnPropertyChanged("StudentMobile");
                }
            }

            get
            {
                return this.m_StudentMobile;
            }
        }

        private string m_Gender = string.Empty;

        public string Gender
        {
            set
            {
                if (m_Gender != value)
                {
                    m_Gender = value;
                    this.OnPropertyChanged("Gender");

                }
            }
            get { return this.m_Gender; }
        }

        private string m_Disability = string.Empty;

        public string Disability
        {
            set
            {
                if (m_Disability != value)
                {
                    m_Disability = value;
                    this.OnPropertyChanged("Disability");

                }
            }
            get { return this.m_Disability; }
        }


        private string m_StudentCNIC = string.Empty;

        public string StudentCNIC
        {

            set
            {
                if (this.m_StudentCNIC != value)
                {
                    this.m_StudentCNIC = value;
                    this.OnPropertyChanged("StudentCNIC");
                }
            }

            get
            {
                return this.m_StudentCNIC;
            }
        }

        private string m_RegistrationNo = string.Empty;

        public string RegistrationNo
        {

            set
            {
                if (this.m_RegistrationNo != value)
                {
                    this.m_RegistrationNo = value;
                    this.OnPropertyChanged("RegistrationNo");
                }
            }

            get
            {
                return this.m_RegistrationNo;
            }
        }

        private string m_StudentRollNumber = string.Empty;

        public string StudentRollNumber
        {

            set
            {
                if (m_StudentName != value)
                {
                    m_StudentRollNumber = value;
                    this.OnPropertyChanged("StudentRollNumber");
                }
            }
            get { return this.m_StudentRollNumber; }
        }

        private string m_StudentID = string.Empty;

        public string StudentID {


            set {
                if (m_StudentID != value)
                {
                    m_StudentID = value;
                    this.OnPropertyChanged("StudentID");
                } }
            get { return this.m_StudentID; }



        }

        private string m_Session = string.Empty;

        public string Session {

            set {
                if (m_Session != value)
                {
                    m_Session = value;
                    this.OnPropertyChanged("Session");
                } }
            get {
                return this.m_Session;

            }

        }

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
            get { return this.m_Department; }
        }

        private string m_batch = string.Empty;

        public string Batch
        {

            set {
                if (m_batch != value)
                {
                    m_batch = value;
                    this.OnPropertyChanged("Batch");
                } }
            get { return this.m_batch; }
        }

        private string m_CurrentSemester = string.Empty;

        public string CurrentSemester
        {
            set { if (m_CurrentSemester != value)
                {
                    m_CurrentSemester = value;
                    this.OnPropertyChanged("CurrentSemester");
                } }
            get { return this.m_CurrentSemester; }
        }

        private string m_Specialization = string.Empty;

        public string Specialization
        {
            set { if (m_Specialization != value)
                {
                    m_Specialization = value;
                    this.OnPropertyChanged("Specialization");
                } }
            get { return m_Specialization; }
        }

        private string m_ImagePath = string.Empty;

        public string ImagePath
        {

            set
            {
                if (this.m_ImagePath != value)
                {
                    this.m_ImagePath = value;
                    this.OnPropertyChanged("ImagePath");
                }
            }

            get
            {
                return this.m_ImagePath;
            }
        }

        private string m_NoteAddational = string.Empty;

        public string NoteAddational
        {
            set
            {
                if (m_NoteAddational != value)
                {
                    m_NoteAddational = value;
                    this.OnPropertyChanged("NoteAddational");

                }
            }
            get { return this.m_NoteAddational; }
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
