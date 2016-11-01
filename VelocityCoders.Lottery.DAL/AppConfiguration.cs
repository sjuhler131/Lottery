using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace VelocityCoders.Lottery.DAL
{
    public static class AppConfiguration
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
            }
        }

        public static string ConnectionStringName
        {
            get
            {
                return ConfigurationManager.AppSettings["ConnectionStringName"];
            }
        }
    }
}