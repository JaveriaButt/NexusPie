using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SES.Controls
{
    public static class ControlsSetting
    {
        private static List<Control> controlList = new List<Control>();

        public static bool IsTextboxEmpty(Form form)
        {
            bool Response = false;
            try
            {
                foreach (Control c in form.Controls)
                {
                    var TextBoxControls = GetControlsbyType(c, typeof(TextBox), typeof(MetroFramework.Controls.MetroTextBox));
                    if (TextBoxControls != null && TextBoxControls.Count() > 0)
                    {
                        foreach (var tb in TextBoxControls)
                        {
                            if (string.IsNullOrEmpty(tb.Text.Trim()) && (!tb.Name.EndsWith("EMPT")))
                            {
                                controlList.Clear(); 
                                return Response = true;
                            }
                        }


                    }
                }
            }
            catch (Exception ex)
            { }
            controlList.Clear();
            return Response;
        }


        public static void ClearAll(Form form)
        {
            try
            {

                foreach (Control c in form.Controls)
                {
                    var TextBoxControls = GetControlsbyType(c, typeof(TextBox), typeof(MetroFramework.Controls.MetroTextBox));
                    if (TextBoxControls != null && TextBoxControls.Count() > 0)
                    {
                        foreach (var tb in TextBoxControls)
                        {
                            tb.Text = string.Empty;
                            
                        }
                    }
                    controlList.Clear();
                   TextBoxControls = GetControlsbyType(c, typeof(ComboBox), typeof(MetroFramework.Controls.MetroComboBox));
                    if (TextBoxControls != null && TextBoxControls.Count() > 0)
                    {
                        foreach (var tb in TextBoxControls)
                        {
                            tb.Text = string.Empty;
                            if (tb is MetroFramework.Controls.MetroComboBox)
                                (tb as MetroFramework.Controls.MetroComboBox).SelectedIndex = -1;
                        }
                    }
                    controlList.Clear();
                }
                controlList.Clear();
            }
            catch (Exception ex)
            { }
            controlList.Clear();
        }


        public static IEnumerable<Control> GetControlsbyType(Control control, Type type, Type Custometype2)
        {
           
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl.GetType() == type || ctrl.GetType() == Custometype2)
                {
                    controlList.Add(ctrl);
                }
                if (ctrl.HasChildren)
                    GetControlsbyType(ctrl, type, Custometype2);
            }
            return controlList;
        }

    }
}
