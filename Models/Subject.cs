using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class Subject : INotifyPropertyChanged
    {

        #region Property 
        private string m_SubjectID = string.Empty;

        public string SubjectID
        {
            set
            {
                if (m_SubjectID != value)
                {
                    m_SubjectID = value;
                    this.OnPropertyChanged("SubjectID");
                }
            }
            get
            {
                return this.m_SubjectID;
            }

        }


        private string m_SubjectCode = string.Empty;

        public string SubjectCode
        {
            set
            {
                if (m_SubjectCode != value)
                {
                    m_SubjectCode = value;
                    this.OnPropertyChanged("SubjectCode");
                }

            }
            get
            {
                return m_SubjectCode;
            }
        }


        private string m_SubjectName = string.Empty;

        public string SubjectName
        {
            set
            {
                if (m_SubjectName != value)
                {
                    m_SubjectName = value;
                    this.OnPropertyChanged("SubjectName");
                }
            }
            get
            {
                return m_SubjectName;
            }


        }

        private string m_SubjectMarks = string.Empty;

        public string SubjectMarks
        {
            set
            {
                if (m_SubjectMarks != value)
                {
                    m_SubjectMarks = value;
                    this.OnPropertyChanged("SubjectMarks");
                }
            }
            get
            {
                return m_SubjectMarks;
            }
        }


        private string m_CreditHours = string.Empty;

        public string CreditHours
        {
            set
            {
                if (m_CreditHours != value)
                {
                    m_CreditHours = value;
                    this.OnPropertyChanged("CreditHours");
                }
            }
            get
            {
                return m_CreditHours;

            }

        }

        private string m_SNGP = string.Empty;

        public string SNGP
        {
            set
            {
                if (m_SNGP != value)
                {
                    m_SNGP = value;
                    this.OnPropertyChanged("SNGP");
                }
            }
            get
            {
                return m_SNGP;
            }
        }

        private string m_SGP = string.Empty;

        public string SGP
        {
            set {
                if (m_SGP != value)
                {
                    m_SGP = value;
                    this.OnPropertyChanged("SGP");
                }
            }
            get
            {
                return m_SGP;
            }
        }

        private string m_SGrade = string.Empty;

        public string SGrade
        {
            set
            {
                if (m_SGrade != value)
                {
                    m_SGrade = value;
                    this.OnPropertyChanged("SGrade");
                }

            }
            get
            {
                return this.m_SGrade;

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
