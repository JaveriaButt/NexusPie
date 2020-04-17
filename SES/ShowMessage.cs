using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SES
{
    public static class ShowMessage
    {

        public static void DisplayPOPUPDialog(string Heading, string text,IconType iconType)
        {
            try
            {
                Designs.ResourceScreen.Scrn_ErrorMessage DisplayError = new Designs.ResourceScreen.Scrn_ErrorMessage();
                DisplayError.lbl_Heading.Text = Heading;
                DisplayError.mlbl_ErrorText.Text = text;

                switch (iconType)
                {
                    case IconType.Error:
                        {
                            DisplayError.Pbx_Icon.Image = Image.FromFile(Application.StartupPath + DefaultSetting.ApplicationDesign.ErrorIcon);
                            break;
                        }
                    case IconType.Information:
                        {
                            DisplayError.Pbx_Icon.Image = Image.FromFile(Application.StartupPath + DefaultSetting.ApplicationDesign.InformationIcon);
                            break;
                        }
                    case IconType.Warning:
                        {
                            DisplayError.Pbx_Icon.Image = Image.FromFile(Application.StartupPath + DefaultSetting.ApplicationDesign.WarningIcon);
                            break;
                        }
                    default:
                        break;
                }

                DisplayError.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                DisplayError.ShowDialog();


            }
            catch (Exception ex)
            {

            }



        }


        public enum IconType
        {
            [XmlEnum("0")]
            Error = 0,

            [XmlEnum("1")]
            Information = 1,

            [XmlEnum("3")]
            Warning = 3,

        }



    }

    
}
