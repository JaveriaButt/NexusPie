using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RefernceValues : INotifyPropertyChanged
    {
        private DataTable m_ProductCategories = null;

        public DataTable ProductCategories
        {
            set
            {
                if (m_ProductCategories != value)
                {
                    m_ProductCategories = value;
                    this.OnPropertyChanged("ProductCategories");
                }
            }
            get
            {
                return this.m_ProductCategories;
            }
        }

        private DataTable m_ProductUnits = null;

        public DataTable ProductUnits
        {
            set
            {
                if (m_ProductUnits != value)
                {
                    m_ProductUnits = value;
                    this.OnPropertyChanged("ProductUnits");
                }
            }
            get
            {
                return this.m_ProductUnits;
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
