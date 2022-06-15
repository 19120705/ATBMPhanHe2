using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.BUS
{
    public class HSBABUS
    {
        HSBADAO hsbaDao = new HSBADAO();
        public DataTable LayDuLieu()
        {
            return hsbaDao.LayDuLieu();
        }
        public int Them(HSBA hsba)
        {
            return hsbaDao.Them(hsba);
        }
        public int CapNhat(HSBA hsba)
        {
            return hsbaDao.CapNhat(hsba);
        }
        public int Xoa(string mahsba)
        {
            return hsbaDao.Xoa(mahsba);
        }
    }
}
