using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsParty.Global
{
    public static class ApiPaths
    {
        public static string BaseUrl { get; private set; } = "";
        public static string LoginPath { get; private set; } = "";
        public static string ServerListPath { get; private set; } = "";

        public static void SetPaths()
        {
            BaseUrl = ConfigurationManager.AppSettings["ApiUrl"];
            LoginPath = BaseUrl + ConfigurationManager.AppSettings["LogInPath"]; ;
            ServerListPath = BaseUrl + ConfigurationManager.AppSettings["ServerListPath"]; ;
        }
    }
}
