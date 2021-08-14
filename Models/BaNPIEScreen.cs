using System;
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Models
{
    public class BaNPIEScreen :  INotifyPropertyChanged
    {
        public BaNPIEScreen(UserControl screen)
        {
            ScreenControl = screen;
        }

        public BaNPIEScreen()
        {
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

        private UserControl m_ScreenControl = null;

        public  UserControl ScreenControl
        {
            set
            {
                if (m_ScreenControl != value)
                {
                    this.m_ScreenControl = value;
                    this.OnPropertyChanged("ScreenControl");
                }


            }
            get
            {
                return this.m_ScreenControl;
            }
        }
        

        private bool m_IsMenuShown = false;
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