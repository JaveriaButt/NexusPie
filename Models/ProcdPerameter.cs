using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class ProcdPerameter : INotifyPropertyChanged
    {

        #region Property

        private string m_SqlColmName = string.Empty;

        public string SqlColmName
        {
            set
            {

                if (value != m_SqlColmName)
                {
                    m_SqlColmName = value;
                    this.OnPropertyChanged("SqlColmName");
                }
            }
            get {
                return m_SqlColmName;

            }
        }

        private SqlDbType m_SqlType =  SqlDbType.VarChar;

        public SqlDbType SqlType
        {
            set
            {
                if (m_SqlType != value)
                {
                    m_SqlType = value;
                    this.OnPropertyChanged("SqlType");
                }
            }
            get
            {
                return this.m_SqlType;
            }
        }


        private string m_Value = string.Empty;

        public string Value
        {

            set
            {
                if (m_Value != value)
                {

                    this.m_Value = value;
                    this.OnPropertyChanged("Value");
                }
            }
            get
            {
                return this.m_Value;
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
