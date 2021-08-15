using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User : INotifyPropertyChanged
    {
        #region Property


        private string  m_UserName = string.Empty;

        public string UserName {

            set
            {
                if (m_UserName != value)
                {
                    m_UserName = value;
                    OnPropertyChanged("UserName");
                }
            }
            get
            {
                return this.m_UserName;
            }
        }


        private string m_Password = string.Empty;

        public string Password
        {

            set
            {
                if (m_Password != value)
                {
                    m_Password = value;
                    OnPropertyChanged("Password");
                }
            }
            get
            {
                return this.m_Password;
            }
        }

        private string m_loginid = string.Empty;

        public string Loginid
        {

            set
            {
                if (m_loginid != value)
                {
                    m_loginid = value;
                    OnPropertyChanged("loginid");
                }
            }
            get
            {
                return this.m_loginid;
            }
        }

        private string m_Premissiongroup = string.Empty;

        public string Premissiongroup
        {

            set
            {
                if (m_Premissiongroup != value)
                {
                    m_Premissiongroup = value;
                    OnPropertyChanged("Premissiongroup");
                }
            }
            get
            {
                return this.m_Premissiongroup;
            }
        }

        private string m_Email = string.Empty;

        public string Email
        {
            set
            {
                if (m_Email != value)
                {
                    m_Email = value;
                    OnPropertyChanged("Email");
                }
            }
            get
            {
                return this.m_Email;
            }
        }


        private string m_mobile = string.Empty;

        public string Mobile
        {
            set
            {
                if (m_mobile != value)
                {
                    m_mobile = value;
                    OnPropertyChanged("Mobile");
                }
            }
            get
            {
                return this.m_mobile;
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
