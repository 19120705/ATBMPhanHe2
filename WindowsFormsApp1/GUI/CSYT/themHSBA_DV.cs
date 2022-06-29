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
    public partial class themHSBA_DV : Form
    {
        private string _message;
        public themHSBA_DV()
        {
            InitializeComponent();
        }

        public themHSBA_DV(string Message) : this()
        {
            _message = Message;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            HSBA_DV hSBA_DV = new HSBA_DV()
            {
                MAHSBA = textHSBA.Text
                ,
                MADV = textMADV.Text
                ,
                NGAY = ngayHSBA_DV.Value.Year.ToString() + "-" + ngayHSBA_DV.Value.Month.ToString() + "-" + ngayHSBA_DV.Value.Day.ToString()
                ,
                MAKTV = textMAKTV.Text
                ,
                KETQUA = richTextBox_KetQua.Text
            };
            HSBA_DVBUS hsba = new HSBA_DVBUS();
            int createHsba_dv = hsba.Them(hSBA_DV);
            if (createHsba_dv != -1)
            {
                MessageBox.Show("Đã tạo hồ sơ bệnh án dịch vụ thành công");
            }
            else
            {
                MessageBox.Show("Tạo hồ sơ bệnh án dịch vụ thất bại");
            }
            this.Close();
        }

        private void themHSBA_DV_Load(object sender, EventArgs e)
        {
            textHSBA.Text = _message;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
