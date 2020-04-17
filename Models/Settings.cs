using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Models
{
   public class Settings : INotifyPropertyChanged
    {
        # region property

        private string m_Fontfamily = "Palatino Linotype";

        public string Fontfamily
        {
            set {

                if (m_Fontfamily != value)
                {

                    m_Fontfamily = value;
                    this.OnPropertyChanged("Fontfamily");
                } }
            get {

                return this.m_Fontfamily;
            }



        }

        private int m_Fontsize = 14;

        public int FontSize
        {
            set {

                if (m_Fontsize != value)
                {
                    m_Fontsize = value;
                    this.OnPropertyChanged("FontSize");
                }
            }
            get {
                return this.m_Fontsize;

            }



        }







        #endregion


        #region Function 


      
   
        #endregion

        public static IEnumerable<Control> GetControlsbyType(Control control, Type type, string Custometype2)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control ctrl in control.Controls)
                {

                string name = ctrl.GetType().ToString();
                    if (ctrl.GetType() == type || ctrl.GetType().ToString() == Custometype2)
                    {
                    controlList.Add(ctrl);
                    }

                    if (ctrl.HasChildren)
                    GetControlsbyType(ctrl, type, Custometype2);
                }
            return controlList;
            }

        public  void  SetFontforControlCollection(Control.ControlCollection control)
        {
            
            foreach (Control c in control)
            {
                SetFontforControl(c);
            }
        }

        public void  SetFontforControl(Control control)
        {

            foreach (Control ctrl in control.Controls)
            {
                if (ctrl.Name != "Pnl_center" && ctrl.Name != "Pnl_Strip")
                {
                   
                    if (ctrl.HasChildren)
                        SetFontforControl(ctrl);
                    else
                        ctrl.Font = new Font(Fontfamily, FontSize);
                }
            }
            
        }

        public   ObservableCollection<DepartmentS> DepartmentList = null;

        public   ObservableCollection<BatchS> BatchList = null;

        public   ObservableCollection<SemesterS> Semesters = null;

        public static  bool IsTextBoxEmpty(Form form)
        {
            bool Response = true;
            try
            {

                foreach (Control c in form.Controls)
                {
                   var TextBoxControls = GetControlsbyType(c, typeof(TextBox),"MetroFramework.Controls.MetroTextBox");
                    if(TextBoxControls != null && TextBoxControls.Count() > 0 )
                    {
                        foreach (TextBox tb in TextBoxControls)
                        {
                            if (string.IsNullOrEmpty(tb.Text.Trim()) && (!tb.Name.EndsWith("EMPT")) )
                            {
                                return Response = false;
                            }
                        }


                    }
                }
            }
            catch (Exception ex)
            { }
            return Response;
        }

        public static bool IsComboBoxEmpty(Form form)
        {
            bool Response = false;
            try
            {
                foreach (Control c in form.Controls)
                {
                    if (c is ComboBox)
                    {
                        ComboBox textBox = c as ComboBox;
                        if (textBox.Text == "Select From Here" || textBox.Text == string.Empty)
                        {
                            Response = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            { }
            return Response;
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
    } }
