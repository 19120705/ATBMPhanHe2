using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class HSBA_DVDAO
    {
        XL_DuLieu dl = new XL_DuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "Select * from S_DBA.S_HSBA_DV";
            return dl.LayDuLieu(sql);
        }
        public int Them(HSBA_DV hsba_dv)
        {
            string sql = string.Format("INSERT INTO S_DBA.S_HSBA_DV(MAHSBA,MADV,NGAY,MAKTV,KETQUA) VALUES ('{0}','{1}',TO_DATE('{2}', 'YYYY-MM-DD'),'{3}','{4}')", hsba_dv.MAHSBA, hsba_dv.MADV, hsba_dv.NGAY, hsba_dv.MAKTV, hsba_dv.KETQUA);
            return dl.ThucThi(sql);
        }
        public int CapNhat(HSBA_DV hsba_dv)
        {
            string sql = string.Format("UPDATE S_DBA.S_HSBA_DV SET MAHSBA='{0}',MADV='{1}',NGAY=TO_DATE('{2}', 'YYYY-MM-DD'),MAKTV='{3}',KETQUA='{4}'", hsba_dv.MAHSBA, hsba_dv.MADV, hsba_dv.NGAY, hsba_dv.MAKTV, hsba_dv.KETQUA);
            return dl.ThucThi(sql);
        }
        public int Xoa(string mahsba, string madv, string ngay)
        {
            string sql = string.Format("DELETE FROM S_DBA.S_HSBA_DV WHERE MAHSBA = '{0}' AND MADV = '{1}' AND NGAY = TO_DATE('{2}', 'YYYY-MM-DD')", mahsba, madv, ngay);
            return dl.ThucThi(sql);
        }
    }
}
