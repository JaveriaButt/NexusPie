using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{


    public enum ColumnTypes
    {
        [XmlEnum("0")]
        Text = 0,
        [XmlEnum("1")]
        Selection = 1,
        [XmlEnum("2")]
        Button = 2,
       
    }
    public class GridColumn : INotifyPropertyChanged
    {
        public GridColumn()
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
        private string m_Heading = string.Empty;
        public string Heading
        {
            set
            {
                if (this.m_Heading != value)
                {
                    this.m_Heading = value;
                    this.OnPropertyChanged("Heading");
                }
            }
            get
            {
                return this.m_Heading;
            }
        }

        private string m_Width = "Auto";
        public string Width
        {
            set
            {
                if (this.m_Width != value)
                {
                    this.m_Width = value;
                    this.OnPropertyChanged("Width");
                }
            }
            get
            {
                return this.m_Width;
            }
        }

        private string m_Property = string.Empty;
        public string Property
        {
            set
            {
                if (this.m_Property != value)
                {
                    this.m_Property = value;
                    this.OnPropertyChanged("Property");
                }
            }
            get
            {
                return this.m_Property;
            }
        }


        private ColumnTypes m_ColumnType = ColumnTypes.Text;
        public ColumnTypes ColumnType
        {
            set
            {
                if (this.m_ColumnType != value)
                {
                    this.m_ColumnType = value;
                    this.OnPropertyChanged("ColumnType");
                }
            }
            get
            {
                return this.m_ColumnType;
            }
        }

        private double m_HorizontalAllignment = 2;
        public double HorizontalAllignment
        {
            set
            {
                if (this.m_HorizontalAllignment != value)
                {
                    this.m_HorizontalAllignment = value;
                    this.OnPropertyChanged("HorizontalAllignment");
                }
            }
            get
            {
                return this.m_HorizontalAllignment;
            }
        }
        public bool m_IsBlurContent = false;
        public bool IsBlurContent
        {
            set
            {
                if (this.m_IsBlurContent != value)
                {
                    this.m_IsBlurContent = value;
                    this.OnPropertyChanged("IsBlurContent");
                }
            }
            get
            {
                return this.m_IsBlurContent;
            }
        }
        private string m_Icon = string.Empty;
        public string Icon
        {
            set
            {
                if (this.m_Icon != value)
                {
                    this.m_Icon = value;
                    this.OnPropertyChanged("Icon");
                }
            }
            get
            {
                return this.m_Icon;
            }
        }

        private double m_IconWidth = 20;
        public double IconWidth
        {
            set
            {
                if (this.m_IconWidth != value)
                {
                    this.m_IconWidth = value;
                    this.OnPropertyChanged("IconWidth");
                }
            }
            get
            {
                return this.m_IconWidth;
            }
        }

        private double m_IconHeight = 20;
        public double IconHeight
        {
            set
            {
                if (this.m_IconHeight != value)
                {
                    this.m_IconHeight = value;
                    this.OnPropertyChanged("IconHeight");
                }
            }
            get
            {
                return this.m_IconHeight;
            }
        }

        private string m_ToolTip = "";
        public string ToolTip
        {
            set
            {
                if (this.m_ToolTip != value)
                {
                    this.m_ToolTip = value;
                    this.OnPropertyChanged("ToolTip");
                }
            }
            get
            {
                return this.m_ToolTip;
            }
        }

        #endregion


        #region Property Changed Event
        //Event 
        public event PropertyChangedEventHandler PropertyChanged;

        //Property Changed Method
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
