using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Config
    {

        public static string GetKeyValue(string Key)
        {
            string Response = string.Empty;
            try
            {
                Response = ConfigurationManager.AppSettings[Key].ToString();
            }
            catch (Exception ex)
            {

            }
            return Response;
        }
    }
}
