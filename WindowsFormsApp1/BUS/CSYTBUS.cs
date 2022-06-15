using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.BUS
{
    public class CSYTBUS
    {
        CSYTDAO csytDao = new CSYTDAO();
        public DataTable LayDuLieu()
        {
            return csytDao.LayDuLieu();
        }
        public int Them(CSYT csyt)
        {
            return csytDao.Them(csyt);
        }
        public int CapNhat(CSYT csyt)
        {
            return csytDao.CapNhat(csyt);
        }
        public int Xoa(string macsyt)
        {
            return csytDao.Xoa(macsyt);
        }
    }
}
