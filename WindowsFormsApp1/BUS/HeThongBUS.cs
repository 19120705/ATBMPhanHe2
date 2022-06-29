using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.BUS
{
    internal class HeThongBUS
    {
        HeThongDAO htDao = new HeThongDAO();
        public DataTable LayDuLieuUSER()//Danh Sach Cac USER
        {
            return htDao.LayDuLieuUSER();
        }
        public DataTable LayDuLieuAtributeUSER(string atribute)//Danh Sach 1 atribute USER
        {
            return htDao.LayDuLieuAtributeUSER(atribute);
        }
        public DataTable LayDuLieuAtributeROLE(string atribute)//Danh Sach 1 atribute ROLE
        {
            return htDao.LayDuLieuAtributeROLE(atribute);
        }
        public DataTable LayDuLieuROLE()//Danh Sach Cac ROLE
        {
            return htDao.LayDuLieuROLE();
        }
        public DataTable LayDuLieuTABLE()//Danh Sach Cac Table
        {
            return htDao.LayDuLieuTABLE();
        }
        public DataTable LayDuLieuPRIVS_SYS_USER()//Danh Sach Cac Quyen Tren He Thong Cua USER
        {
            return htDao.LayDuLieuPRIVS_SYS_USER();
        }
        public DataTable LayDuLieuPRIVS_TAB_USER()//Danh Sach Cac Quyen Tren Table Cua USER
        {
            return htDao.LayDuLieuPRIVS_TAB_USER();
        }
        public DataTable LayDuLieuPRIVS_COL_USER()//Danh Sach Cac Quyen Tren Collum Cua USER
        {
            return htDao.LayDuLieuPRIVS_COL_USER();
        }
        public DataTable LayDuLieuPRIVS_SYS_ROLE()//Danh Sach Cac Quyen Tren He Thong Cua ROLE
        {
            return htDao.LayDuLieuPRIVS_SYS_ROLE();
        }
        public DataTable LayDuLieuPRIVS_TAB_ROLE()//Danh Sach Cac Quyen Tren Table Cua ROLE
        {
            return htDao.LayDuLieuPRIVS_TAB_ROLE();
        }
        public int Create_User(string name, string pass)//Create user
        {
            string sql = "CREATE USER " + name + " identified by " + pass;
            return htDao.Create_Drop(sql);
        }
        public int ChangePass_User(string name, string pass)//Change Password user
        {
            string sql = "ALTER USER " + name + " IDENTIFIED BY " + pass;
            return htDao.Create_Drop(sql);
        }
        public int ThucThi(string sql)//thuc thi sql
        {
            return htDao.Create_Drop(sql);
        }
        public int Drop_User(string name)//Drop user
        {
            string sql = "DROP USER " + name;
            return htDao.Create_Drop(sql);
        }
        public int Create_Role(string name)//Create role
        {
            string sql = "CREATE ROLE " + name;
            return htDao.Create_Drop(sql);
        }
        public int Drop_Role(string name)//Drop role
        {
            string sql = "DROP ROLE " + name;
            return htDao.Create_Drop(sql);
        }

    }
}
