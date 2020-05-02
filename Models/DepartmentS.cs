using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class DepartmentS : INotifyPropertyChanged
    {
        private string m_DepID = string.Empty;

        public string DepID
        {
            set
            {
                if (value != m_DepID)
                {
                    m_DepID = value;
                    this.OnPropertyChanged("DepID");
                }
            }
            get
            {
                return this.m_DepID;
            }
        }
        private string m_DepName = string.Empty;
        public string DepName
        {
            set
            {
                if (value != m_DepName)
                {
                    m_DepName = value;
                    this.OnPropertyChanged("DepName");
                }
            }
            get
            {
                return m_DepName;
            }
        }


        private string m_DepHOD = string.Empty;

        public string DepHOD
        {
            set
            {
                if (value != m_DepHOD)
                {
                    m_DepHOD = value;
                    this.OnPropertyChanged("DepHOD");
                }
            }
            get
            {
                return this.m_DepHOD;
            }
        }
        private bool m_isActive = true;

        public bool IsActive
        {
            set
            {
                if (value != m_isActive)
                {
                    IsActive= value;
                    this.OnPropertyChanged("IsActive");
                }
            }
            get
            {
                return this.m_isActive;
            }
        }

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
     
    public class SemesterS : INotifyPropertyChanged
    {


        private string m_SemName = string.Empty;

        public string SemName
        {
            set
            {
                if (value != m_SemName)
                {
                    m_SemName = value;
                    this.OnPropertyChanged("SemName");
                }
            }
            get
            {
                return m_SemName;
            }
        }


        private string m_SemID = string.Empty;

        public string SemID
        {
            set
            {
                if (value != m_SemID)
                {
                    value = m_SemID;
                    this.OnPropertyChanged("SemID");
                }
            }
            get
            {
                return this.m_SemID;
            }
        }



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
     
    public class BatchS : INotifyPropertyChanged
    {


        private string m_BatName = string.Empty;

        public string BatchName
        {
            set
            {
                if (value != m_BatName)
                {
                    m_BatName = value;
                    this.OnPropertyChanged("BatchName");
                }
            }
            get
            {
                return m_BatName;
            }
        }


        private string m_BatID = string.Empty;

        public string BatchID
        {
            set
            {
                if (value != m_BatID)
                {
                    value = m_BatID;
                    this.OnPropertyChanged("BatchID");
                }
            }
            get
            {
                return this.m_BatID;
            }
        } 
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


    public class SessionS : INotifyPropertyChanged
    {


        private string m_Session = string.Empty;

        public string Session
        {
            set
            {
                if (value != m_Session)
                {
                    m_Session = value;
                    this.OnPropertyChanged("Session");
                }
            }
            get
            {
                return m_Session;
            }
        }


        private string m_SessionID = string.Empty;

        public string SessionID
        {
            set
            {
                if (value != m_SessionID)
                {
                    value = m_SessionID;
                    this.OnPropertyChanged("Session");
                }
            }
            get
            {
                return this.m_SessionID;
            }
        }

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
