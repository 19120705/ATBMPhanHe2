using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class CSYTDAO
    {
        XL_DuLieu dl= new XL_DuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "Select * from S_DBA.S_CSYT";
            return dl.LayDuLieu(sql);
        }
        public int Them(CSYT csyt)
        {
            string sql = string.Format("INSERT INTO S_DBA.S_CSYT(MACSYT,TENCSYT,DCCSYT,SDTCSYT) VALUES ('{0}','{1}','{2}','{3}')", csyt.MACSYT, csyt.TENCSYT, csyt.DCCSYT, csyt.SDTCSYT);
            return dl.ThucThi(sql);
        }
        public int CapNhat(CSYT csyt)
        {
            string sql = string.Format("UPDATE S_DBA.S_CSYT SET MACSYT='{0}',TENCSYT='{1}',DCCSYT='{2}',SDTCSYT='{3}'", csyt.MACSYT, csyt.TENCSYT, csyt.DCCSYT, csyt.SDTCSYT);
            return dl.ThucThi(sql);
        }
        public int Xoa(string macsyt)
        {
            string sql = string.Format("DELETE FROM S_DBA.S_CSYT WHERE MACSYT = {0}", macsyt);
            return dl.ThucThi(sql);
        }
    }
}
