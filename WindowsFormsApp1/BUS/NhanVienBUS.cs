using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nvDao = new NhanVienDAO();
        public DataTable LayDuLieu()
        {
            return nvDao.LayDuLieu();
        }
        public DataTable LayVaiTro(string manv)
        {
            return nvDao.LayVaiTro(manv);
        }
        public int Them(NHANVIEN nv)
        {
            return nvDao.Them(nv);
        }
        public int CapNhat(NHANVIEN nv)
        {
            return nvDao.CapNhat(nv);
        }
        public int Xoa(string manv)
        {
            return nvDao.Xoa(manv);
        }

    }
}
