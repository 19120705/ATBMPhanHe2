using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.BUS
{
    public class HSBA_DVBUS
    {
        HSBA_DVDAO hsba_dvDao = new HSBA_DVDAO();
        public DataTable LayDuLieu()
        {
            return hsba_dvDao.LayDuLieu();
        }
        public int Them(HSBA_DV hsba_dv)
        {
            return hsba_dvDao.Them(hsba_dv);
        }
        public int CapNhat(HSBA_DV hsba_dv)
        {
            return hsba_dvDao.CapNhat(hsba_dv);
        }
        public int Xoa(string mahsba, string madv, string ngay)
        {
            return hsba_dvDao.Xoa(mahsba, madv, ngay);
        }
    }
}
