using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Models
{
    public class Error : INotifyPropertyChanged
    {
        public Error()
        {

        }


        #region Properties
        private string m_ID = string.Empty;
        public string ID
        {
            set
            {
                if (this.m_ID != value)
                {
                    this.m_ID = value;
                    this.OnPropertyChanged("ID");
                }
            }
            get
            {
                return this.m_ID;
            }
        }

        private string m_Code = string.Empty;
        public string Code
        {
            set
            {
                if (this.m_Code != value)
                {
                    this.m_Code = value;
                    this.OnPropertyChanged("Code");
                }
            }
            get
            {
                return this.m_Code;
            }
        }

        private string m_EnglishMsg = string.Empty;
        public string EnglishMsg
        {
            set
            {
                if (this.m_EnglishMsg != value)
                {
                    this.m_EnglishMsg = value;
                    this.OnPropertyChanged("EnglishMsg");
                }
            }
            get
            {
                return this.m_EnglishMsg;
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
