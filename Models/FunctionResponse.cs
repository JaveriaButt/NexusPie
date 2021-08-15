using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Models
{
    public class FunctionResponse<T> : INotifyPropertyChanged
    {
        public FunctionResponse()
        {

        }

        #region Properties
        private bool m_Success = false;
        public bool Success
        {
            set
            {
                if (this.m_Success != value)
                {
                    this.m_Success = value;
                    this.OnPropertyChanged("Success");
                }
            }
            get
            {
                return this.m_Success;
            }
        }

        private string m_ResponseMessage = string.Empty;
        public string ResponseMessage
        {
            set
            {
                if (this.m_ResponseMessage != value)
                {
                    this.m_ResponseMessage = value;
                    this.OnPropertyChanged("ResponseMessage");
                }
            }
            get
            {
                return this.m_ResponseMessage;
            }
        }

       

        private T m_Result;
        public T Result
        {
            set
            {
                this.m_Result = value;
                this.OnPropertyChanged("Result");
            }
            get
            {
                return this.m_Result;
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
