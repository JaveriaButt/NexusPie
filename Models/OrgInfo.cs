using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class OrgInfo : INotifyPropertyChanged
    {

        #region Property 


        private string m_OrgName = string.Empty;

        public string OrgName
        {
            set
            {
                if (m_OrgName != value)
                {
                    m_OrgName = value;
                    this.OnPropertyChanged("OrgName");

                }
            }
            get { return this.m_OrgName; }
        }

        private string m_PrincipalName = string.Empty;

        public string PrincipalName
        {

            set
            {
                if (m_PrincipalName != value)
                {
                    m_PrincipalName = value;
                    this.OnPropertyChanged("PrincipalName");
                }
            }
            get { return this.m_PrincipalName; }
        }

        private string m_ControllerName = string.Empty;

        public string ControllerName
        {


            set
            {
                if (m_ControllerName != value)
                {
                    m_ControllerName = value;
                    this.OnPropertyChanged("ControllerName");
                }
            }
            get { return this.m_ControllerName; }



        }

        private string m_Examiner = string.Empty;

        public string Examiner
        {

            set
            {
                if (m_Examiner != value)
                {
                    m_Examiner = value;
                    this.OnPropertyChanged("Examiner");
                }
            }
            get
            {
                return this.m_Examiner;

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
