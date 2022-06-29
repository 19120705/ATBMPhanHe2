using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class XL_DuLieu
    {
        
        public DataTable LayDuLieu(string sql)
        {
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            OracleDataAdapter adapter = new OracleDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);  
            return dt;
        }
        public int ThucThi(string sql)
        {

            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            OracleCommand cmd = new OracleCommand(sql, conn);
            conn.Open();
            var kq = cmd.ExecuteNonQuery();
            conn.Close();
            return kq;

        }
    }
}
