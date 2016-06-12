using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Config
    {
        public static string SattledFilePath
        {
            get { return ConfigurationManager.AppSettings["SattledFilePath"]; }
        }
        public static string UnSattledFilePath
        {
            get { return ConfigurationManager.AppSettings["UnSattledFilePath"]; }
        }
    }
}
