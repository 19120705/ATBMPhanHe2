using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class DBUtils
    {
        public static OracleConnection GetDBConnection(string textName, string textPassword)
        {
            string host = "localhost";
            int port = 1521;
            string sid = "xe";
            return DBOracleUtils.GetDBConnection(host, port, sid, textName, textPassword);

        }
    }
}
