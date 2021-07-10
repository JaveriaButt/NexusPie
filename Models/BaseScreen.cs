using System;
using System.Collections.Generic;
using System.Windows; 
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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