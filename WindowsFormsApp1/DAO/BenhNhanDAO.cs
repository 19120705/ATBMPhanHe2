﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class BenhNhanDAO
    {
        XL_DuLieu dl = new XL_DuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "Select * from S_DBA.S_BENHNHAN";
            return dl.LayDuLieu(sql);
        }
        public int Them(BENHNHAN bn)
        {
            string sql = string.Format("INSERT INTO S_DBA.S_BENHNHAN(MABN,MACSYT,TENBN,CMND,NGAYSINH,SONHA,TENDUONG,QUANHUYEN,TINHTP,TIENSUBENH,TIENSUBENHGD,DIUNGTHUOC) VALUES ('{0}','{1}','{2}','{3}'TO_DATE('{4}', 'YYYY-MM-DD'),'{5}','{6}','{7}','{8}','{9}','{10}','{11}')", bn.MABN, bn.MACSYT, 
                bn.TENBN, bn.CMND, bn.NGAYSINH, bn.SONHA, bn.TENDUONG, bn.QUANHUYEN, bn.TINHTP, bn.TIENSUBENH, bn.TIENSUBENHGD, bn.DIUNGTHUOC);
            return dl.ThucThi(sql);
        }
        public int CapNhat(BENHNHAN bn)
        {
            string sql = string.Format("UPDATE S_DBA.S_BENHNHAN SET MABN='{0}',MACSYT='{1}',TENBN='{2}',CMND='{3}',NGAYSINH=TO_DATE('{4}', 'YYYY-MM-DD'),SONHA='{5}',TENDUONG='{6}',QUANHUYEN='{7}',TINHTP='{8}',TIENSUBENH='{9}',TIENSUBENHGD='{10}',DIUNGTHUOC='{11}'", bn.MABN, bn.MACSYT,
                bn.TENBN, bn.CMND, bn.NGAYSINH, bn.SONHA, bn.TENDUONG, bn.QUANHUYEN, bn.TINHTP, bn.TIENSUBENH, bn.TIENSUBENHGD, bn.DIUNGTHUOC);
            return dl.ThucThi(sql);
        }
        public int Xoa(string mabn)
        {
            string sql = string.Format("DELETE FROM S_DBA.S_BENHNHAN WHERE MABN = {0}", mabn);
            return dl.ThucThi(sql);
        }
    }
}
