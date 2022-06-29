using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.BUS
{
    public class BenhNhanBUS
    {
        BenhNhanDAO bnDao = new BenhNhanDAO();
        public DataTable LayDuLieu()
        {
            return bnDao.LayDuLieu();
        }

        public DataTable LayDuLieuBenhNhan(string mabn)
        {
            return bnDao.LayDuLieuBenhNhan(mabn);
        }
        public int Them(BENHNHAN bn)
        {
            return bnDao.Them(bn);
        }
        public int CapNhat(BENHNHAN bn)
        {
            return bnDao.CapNhat(bn);
        }
        public int Xoa(string mabn)
        {
            return bnDao.Xoa(mabn);
        }
    }
}
