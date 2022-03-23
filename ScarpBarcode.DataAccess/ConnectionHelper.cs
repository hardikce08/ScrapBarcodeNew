using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScarpBarcode.DataAccess
{
    public class ConnectionHelper
    {
        public string OracleConnectionString
        {
            get
            {
                //return ConfigurationManager.ConnectionStrings["SweetSpotPortal"].ConnectionString;
                
                return ConfigurationManager.AppSettings["OracleConnectionString"];

            }
        }
        public string AccessConnectionString
        {
            get
            {
                //return ConfigurationManager.ConnectionStrings["SweetSpotPortal"].ConnectionString;
                return ConfigurationManager.AppSettings["AccessConnectionString"];

            }
        }
    }
}
