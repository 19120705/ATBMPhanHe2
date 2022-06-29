using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1.GUI.CSYT
{
    public partial class themHSBA : Form
    {
        public themHSBA()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            HSBA hSBA = new HSBA()
            {
                MAHSBA = textHSBA.Text
                , MABN = textMABN.Text
                , NGAY = ngayHSBA.Value.Year.ToString()+"-"+ ngayHSBA.Value.Month.ToString()+"-"+ ngayHSBA.Value.Day.ToString()
                , CHUANDOAN = richTextBox_ChanDoan.Text
                , MABS = textBACSI.Text
                , MAKHOA = textMaKhoa.Text
                , MACSYT = textMACSYT.Text
                , KETLUAN = richTextBox_KetLuan.Text
            };
            HSBABUS hsba = new HSBABUS();
            int createHsba = hsba.Them(hSBA);
            if (createHsba != -1)
            {
                MessageBox.Show("Đã tạo hồ sơ bệnh án thành công");
            }
            else
            {
                MessageBox.Show("Tạo hồ sơ bệnh án thất bại");
            }
            this.Close();

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
