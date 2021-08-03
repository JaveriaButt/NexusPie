using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources
{
    public class LOG
    {

        static bool SaveLog = false;
        static bool IsInitialize = false;
        public static void Save(string Text)
        {
            try
            {
                if (!IsInitialize)
                    Initialize();
                if (SaveLog)
                {
                    string LogFolder = "LOG\\";
                    if (!System.IO.Directory.Exists(LogFolder))
                    {
                        System.IO.Directory.CreateDirectory(LogFolder);
                    }
                    string LogFilePath = LogFolder + "LOG__" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                    if (!System.IO.File.Exists(LogFilePath))
                    {
                        System.IO.Stream openstream = System.IO.File.Create(LogFilePath);
                        openstream.Close();
                    }
                    System.IO.StreamWriter writer = System.IO.File.AppendText(LogFilePath);
                    writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "--" + Text);
                    writer.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        static void Initialize()
        {
            try
            {
                try { SaveLog = Convert.ToBoolean(int.Parse(Config.GetKeyValue("SaveLog"))); } catch (Exception) { }
                IsInitialize = true;
            }
            catch (Exception) { }

        }

    }

    public class Config
    {
        public static string GetKeyValue(string Key)
        {
            string Response = string.Empty;
            try
            {
                Response = ConfigurationManager.AppSettings[Key].ToString();
            }
            catch (Exception)
            {

            }
            return Response;
        }
    }
}
