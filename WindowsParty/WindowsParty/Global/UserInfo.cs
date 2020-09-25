using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsParty.Global
{
    public static class UserInfo
    {
        public static string Username { get; private set; } = "";
        public static string Token { get; private set; } = "";

        public static void SetUserInfo(string username, string token)
        {
            Username = username;
            Token = token
;       }
        public static void ClearUserInfo()
        {
            Username = "";
            Token = "";
        }
    }
}
