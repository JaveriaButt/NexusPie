using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class ClickResponse : INotifyPropertyChanged
    {
        object m_DataObject = null;
        public object DataObject
        {
            set
            {
                if (m_DataObject != value)
                {
                    m_DataObject = value;
                    this.OnPropertyChanged("DataObject");
                }
            }
            get
            {
                return this.m_DataObject;
            }
        }


        private string m_Sender = string.Empty;

        public string SENDER {

            set
            {
                if (m_Sender != value)
                {
                    m_Sender = value;
                    this.OnPropertyChanged("SENDER");
                }
            }
            get
            {
                return this.m_Sender;
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
