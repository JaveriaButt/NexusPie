using System;
using System.Collections.Generic;
using System.Windows; 
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Models
{
    public class BaNPIEScreen :  INotifyPropertyChanged
    {
        public BaNPIEScreen(ScreenType screen)
        {
            ChildControl = screen;
        }

        public event RoutedEventHandler SendClickEvent;
        public void SendClick(object Value)
        {
            try
            {
                if (SendClickEvent != null)
                {
                    this.SendClickEvent(Value, new RoutedEventArgs());
                }
            }
            catch (Exception ex)
            {

            }
        }

        private ScreenType m_ChildControl = ScreenType.None;

        public ScreenType ChildControl
        {
            set
            {
                if (m_ChildControl != value)
                {
                    this.m_ChildControl = value;
                    this.OnPropertyChanged("ChildControl");
                }


            }
            get
            {
                return this.m_ChildControl;
            }
        }

        private bool m_IsMenuShown = true;
        public bool IsMenuShown
        {
            set
            {
                if (m_IsMenuShown != value)
                {
                    m_IsMenuShown = value;
                    this.OnPropertyChanged("IsMenuShown");
                }
            }
            get {
                return m_IsMenuShown;
            }
        }
       
        private ObservableCollection<GridColumn> m_ColumnsList = new ObservableCollection<GridColumn>();
        public ObservableCollection<GridColumn> ColumnsList
        {
            set
            {
                if (m_ColumnsList != value)
                {
                    m_ColumnsList = value;
                    OnPropertyChanged("ColumnsList");
                }
            }
            get
            {
                return m_ColumnsList;
            }
        }
 
        private object m_List = null;
        public object List
        {
            set
            {
                if (this.m_List != value)
                {
                    this.m_List = value;
                    this.OnPropertyChanged("List");
                }
            }
            get
            {
                return this.m_List;
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

        public void SubmitToServer(object dataContext)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}