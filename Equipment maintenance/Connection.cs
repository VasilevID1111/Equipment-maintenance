using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_maintenance
{
    static class Connection
    {
        private static string Admin_login = "postgres";
        private static string Admin_password = "masterkey";


        //private static string Server = "localhost";
        //private static string Port = "5432";
        //private static string DB = "Equipment_maintenance";

        private static string Server = "localhost";
        private static string Port = "5432";
        private static string DB = "devices";


        public static string Nickname { get; set; }
        public static string Password { get; set; }

        public static string ConnParam ()
        {
            return "Server=" + Connection.Server + ";Port=" + Connection.Port + ";User Id=" + Connection.Nickname + ";Password=" + Connection.Password + ";Database=" + Connection.DB;
        }
        public static string ConnParam_Admin()
        {
            return "Server=" + Connection.Server + ";Port=" + Connection.Port + ";User Id=" + Connection.Admin_login + ";Password=" + Connection.Admin_password + ";Database=" + Connection.DB;
        }
    }
}
