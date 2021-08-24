using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product : INotifyPropertyChanged
    {

        #region Property 


        private string m_ProductId = string.Empty;
        
        public string ProductID
        {
            set
            {
                if (m_ProductId != value)
                {
                    m_ProductId = value;
                    this.OnPropertyChanged("ProductID");

                }
            }
            get { return this.m_ProductId; }
        }

        private string m_Productbarcode = string.Empty;

        public string ProductBarcode
        {
            set
            {
                if (m_Productbarcode != value)
                {
                    m_Productbarcode = value;
                    this.OnPropertyChanged("ProductBarcode");

                }
            }
            get { return this.m_Productbarcode; }
        }

        private string m_ProductCode = string.Empty;

        public string ProductCode
        {
            set
            {
                if (m_ProductCode != value)
                {
                    m_ProductCode = value;
                    this.OnPropertyChanged("ProductCode");

                }
            }
            get { return this.m_ProductCode; }
        }

        private string m_ProductName = string.Empty;

        public string ProductName
        {

            set {
                if (this.m_ProductName != value)
                {
                    this.m_ProductName = value;
                    this.OnPropertyChanged("ProductName");
                } 
            }

            get {
                return this.m_ProductName;
            }
        }

        private string m_Description = string.Empty;

        public string Description
        {

            set
            {
                if (this.m_Description != value)
                {
                    this.m_Description = value;
                    this.OnPropertyChanged("Description");
                }
            }

            get
            {
                return this.m_Description;
            }
        }

        private string m_CastPrice = string.Empty;

        public string CastPrice
        {
            set
            {
                if (m_CastPrice != value)
                {
                    m_CastPrice = value;
                    this.OnPropertyChanged("CastPrice");

                }
            }
            get { return this.m_CastPrice; }
        }

        private string m_SalePrice = string.Empty;

        public string SalePrice
        {
            set
            {
                if (m_SalePrice != value)
                {
                    m_SalePrice = value;
                    this.OnPropertyChanged("SalePrice");

                }
            }
            get { return this.m_SalePrice; }
        }


        private string m_UnitOfMeasure = string.Empty;

        public string UnitOfMeasure
        {

            set
            {
                if (this.m_UnitOfMeasure  != value)
                {
                    this.m_UnitOfMeasure = value;
                    this.OnPropertyChanged("UnitOfMeasure");
                }
            }

            get
            {
                return this.m_UnitOfMeasure;
            }
        }

        private string m_Vendor = string.Empty;

        public string Vendor
        {

            set
            {
                if (this.m_Vendor != value)
                {
                    this.m_Vendor = value;
                    this.OnPropertyChanged("Vendor");
                }
            }

            get
            {
                return this.m_Vendor;
            }
        }

        private string m_Category = string.Empty;

        public string Category
        {

            set
            {
                if (m_Category != value)
                {
                    m_Category = value;
                    this.OnPropertyChanged("Category");
                }
            }
            get { return this.m_Category; }
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
        private int m_quantity = 0;

        public int Quantity
        {

            set
            {
                if (this.m_quantity != value)
                {
                    this.m_quantity = value;
                    this.OnPropertyChanged("Quantity");
                }
            }

            get
            {
                return this.m_quantity;
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
