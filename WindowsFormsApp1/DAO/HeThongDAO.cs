using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class HeThongDAO
    {
        XL_DuLieu dl = new XL_DuLieu();
        public DataTable LayDuLieuUSER()//Danh Sach Cac USER
        {
            string sql = "SELECT USERNAME, USER_ID,ACCOUNT_STATUS, DEFAULT_TABLESPACE, CREATED FROM DBA_USERS";
            return dl.LayDuLieu(sql);
        }
        public DataTable LayDuLieuAtributeUSER(string atribute)//Danh Sach 1 atribute USER
        {
            string sql = "SELECT DISTINCT " + atribute+" FROM DBA_USERS";
            return dl.LayDuLieu(sql);
        }
        public DataTable LayDuLieuAtributeROLE(string atribute)//Danh Sach 1 atribute ROLE
        {
            string sql = "SELECT DISTINCT " + atribute + " FROM DBA_ROLES";
            return dl.LayDuLieu(sql);
        }
        public DataTable LayDuLieuROLE()//Danh Sach Cac ROLE
        {
            string sql = "SELECT * FROM DBA_ROLES";
            return dl.LayDuLieu(sql);
        }
        public DataTable LayDuLieuTABLE()//Danh Sach Cac Table
        {
            string sql = "SELECT * FROM DBA_TABLES";
            return dl.LayDuLieu(sql);
        }
        public DataTable LayDuLieuPRIVS_SYS_USER()//Danh Sach Cac Quyen Tren He Thong Cua USER
        {
            string sql = "SELECT * FROM DBA_SYS_PRIVS";
            return dl.LayDuLieu(sql);
        }
        public DataTable LayDuLieuPRIVS_TAB_USER()//Danh Sach Cac Quyen Tren Table Cua USER
        {
            string sql = "SELECT * FROM DBA_TAB_PRIVS";
            return dl.LayDuLieu(sql);
        }
        public DataTable LayDuLieuPRIVS_COL_USER()//Danh Sach Cac Quyen Tren Collum Cua USER
        {
            string sql = "SELECT * FROM DBA_COL_PRIVS";
            return dl.LayDuLieu(sql);
        }
        public DataTable LayDuLieuPRIVS_SYS_ROLE()//Danh Sach Cac Quyen Tren He Thong Cua ROLE
        {
            string sql = "SELECT * FROM DBA_SYS_PRIVS";
            return dl.LayDuLieu(sql);
        }
        public DataTable LayDuLieuPRIVS_TAB_ROLE()//Danh Sach Cac Quyen Tren Table Cua ROLE
        {
            string sql = "SELECT * FROM DBA_TAB_PRIVS";
            return dl.LayDuLieu(sql);
        }
        public int Create_Drop(string sql)//Create drop user or role
        {
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            conn.Open();
            //string sql = "CREATE USER " + name + " identified by " + password;
            //set session = true
            OracleCommand cmd2 = conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
            cmd2.ExecuteNonQuery();
            //create user
            OracleCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = sql;
            int result= cmd1.ExecuteNonQuery();
            //set session = false
            OracleCommand cmd3 = conn.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "alter session set \"_ORACLE_SCRIPT\"=false";
            cmd3.ExecuteNonQuery();

            conn.Close();
            return result;
        }
        

    }
}
