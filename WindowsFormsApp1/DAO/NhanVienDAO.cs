using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class NhanVienDAO
    {
        XL_DuLieu dl= new XL_DuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "Select * from S_DBA.S_NHANVIEN";
            return dl.LayDuLieu(sql);
        }
        public DataTable LayVaiTro(string manv)
        {
            string sql = "Select VAITRO from S_DBA.S_NHANVIEN where MANV = '" + manv + "'";
            return dl.LayDuLieu(sql);
        }
        public int Them(NHANVIEN nv)
        {
            string sql = string.Format("INSERT INTO S_DBA.S_NHANVIEN(MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SDT,CSYT,VAITRO,CHUYENKHOA) VALUES ('{0}','{1}','{2}',TO_DATE('{3}', 'YYYY-MM-DD'),'{4}','{5}','{6}','{7}','{8}','{9}')", nv.MANV, nv.HOTEN, nv.PHAI, nv.NGAYSINH, nv.CMND, 
                nv.QUEQUAN, nv.SDT, nv.CSYT, nv.VAITRO, nv.CHUYENKHOA);
            return dl.ThucThi(sql);
        }
        public int CapNhat(NHANVIEN nv)
        {
            string sql = string.Format("UPDATE S_DBA.S_NHANVIEN SET MANV='{0}',HOTEN='{1}',PHAI='{2}',NGAYSINH=TO_DATE('{3}', 'YYYY-MM-DD'),CMND='{4}',QUEQUAN='{5}',SDT='{6}',CSYT='{7}',VAITRO='{8}',CHUYENKHOA='{9}'", nv.MANV, 
                nv.HOTEN, nv.PHAI, nv.NGAYSINH, nv.CMND,nv.QUEQUAN, nv.SDT, nv.CSYT, nv.VAITRO, nv.CHUYENKHOA);
            return dl.ThucThi(sql);
        }
        public int Xoa(string manv)
        {
            string sql = string.Format("DELETE FROM S_DBA.S_NHANVIEN WHERE MANV = {0}", manv);
            return dl.ThucThi(sql);
        }
    }
}
