using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SES
{
   public static class DefaultSetting
    {


         static DefaultSetting()
        {
            LoadAppDesign();
        }


        private static string APPID = DAL.Config.GetKeyValue("APPID");
        public static AppDesign ApplicationDesign = new AppDesign();
        public static OrgInfo OrgInformation = new OrgInfo();
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        public static Settings AppSetting = new Settings();


        private static void LoadAppDesign()
        {
            try
            {
                //ApplicationDesign = DAL1.LoadApplicaitonDesign();
                //OrgInformation = DAL1.LoadOrgInfo();
                //AppSetting.DepartmentList = DAL1.DepartmentList(); 
               
            }
            catch (Exception ex)
            {
            }
        }

    }
}
