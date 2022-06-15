using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class HSBADAO
    {
        XL_DuLieu dl = new XL_DuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "Select * from S_DBA.S_HSBA";
            return dl.LayDuLieu(sql);
        }
        public int Them(HSBA hsba)
        {
            string sql = string.Format("INSERT INTO S_DBA.S_HSBA(MAHSBA,MABN,NGAY,CHUANDOAN,MABS,MAKHOA,MACSYT,KETLUAN) VALUES ('{0}','{1}',TO_DATE('{2}', 'YYYY-MM-DD'),'{3}','{4}','{5}','{6}','{7}')", hsba.MAHSBA, hsba.MABN, hsba.NGAY, hsba.CHUANDOAN, hsba.MABS, hsba.MAKHOA, hsba.MACSYT, hsba.KETLUAN);
            return dl.ThucThi(sql);
        }
        public int CapNhat(HSBA hsba)
        {
            string sql = string.Format("UPDATE S_DBA.S_HSBA SET MAHSBA='{0}',MABN='{1}',NGAY=TO_DATE('{2}',CHUANDOAN='{3}',MABS='{4}',MAKHOA='{5}',MACSYT='{6}',KETLUAN='{7}'", hsba.MAHSBA, hsba.MABN, hsba.NGAY, hsba.CHUANDOAN, hsba.MABS, hsba.MAKHOA, hsba.MACSYT, hsba.KETLUAN);
            return dl.ThucThi(sql);
        }
        public int Xoa(string mahsba)
        {
            string sql = string.Format("DELETE FROM S_DBA.S_HSBA WHERE MAHSBA = {0}", mahsba);
            return dl.ThucThi(sql);
        }
    }
}
