using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Database
{
    public class ConnectionClass
    {
        public static String connectionString
        {
            get { return @"Data Source=DESKTOP-Q4T02TC\SQLEXPRESS;Initial Catalog=Programmingdb;Integrated Security=True"; }
        }
    }
}
