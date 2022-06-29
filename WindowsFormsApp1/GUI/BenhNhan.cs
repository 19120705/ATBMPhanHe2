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

namespace WindowsFormsApp1.GUI
{
    public partial class BenhNhan : Form
    {
        private string _message;
        public BenhNhan()
        {
            InitializeComponent();
        }
        public BenhNhan(string Message) : this()
        {
            _message = Message;
        }

        private void BenhNhan_Load(object sender, EventArgs e)
        {
            BenhNhanBUS bnbus = new BenhNhanBUS();
            dataGridView1.DataSource = bnbus.LayDuLieuBenhNhan(_message);
            int index_row = dataGridView1.CurrentCell.RowIndex;

            string ngaysinh = dataGridView1.Rows[index_row].Cells[4].Value.ToString();
            ngaysinh = ngaysinh.Substring(0, ngaysinh.IndexOf(" ")).ToString();
            string[] arrList = ngaysinh.Split(new char[] { '/' });
            textMABN.Text = dataGridView1.Rows[index_row].Cells[0].Value.ToString();
            textMACSYT.Text = dataGridView1.Rows[index_row].Cells[1].Value.ToString();
            textTEN.Text = dataGridView1.Rows[index_row].Cells[2].Value.ToString();
            textCMND.Text = dataGridView1.Rows[index_row].Cells[3].Value.ToString();
            ngaySinh.Value = new DateTime(int.Parse(arrList[2]), int.Parse(arrList[1]), int.Parse(arrList[0])); 
            textSONHA.Text = dataGridView1.Rows[index_row].Cells[5].Value.ToString();
            textTENDUONG.Text = dataGridView1.Rows[index_row].Cells[6].Value.ToString();
            textQUANHUYEN.Text = dataGridView1.Rows[index_row].Cells[7].Value.ToString();
            textTHANHPHO.Text = dataGridView1.Rows[index_row].Cells[8].Value.ToString();
            textTIENSU.Text = dataGridView1.Rows[index_row].Cells[9].Value.ToString();
            textTIENSUGD.Text = dataGridView1.Rows[index_row].Cells[10].Value.ToString();
            textDIUNG.Text = dataGridView1.Rows[index_row].Cells[11].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BENHNHAN bn = new BENHNHAN()
            {
                MABN = textMABN.Text
                ,MACSYT = textMACSYT.Text
                ,TENBN = textTEN.Text
                ,CMND = textCMND.Text
                ,NGAYSINH = ngaySinh.Value.Year.ToString() + "-" + ngaySinh.Value.Month.ToString() + "-" + ngaySinh.Value.Day.ToString()
                ,SONHA = textSONHA.Text
                ,TENDUONG = textTENDUONG.Text
                ,QUANHUYEN = textQUANHUYEN.Text
                ,TINHTP = textTHANHPHO.Text
                ,TIENSUBENH = textTIENSU.Text
                ,TIENSUBENHGD = textTIENSUGD.Text
                ,DIUNGTHUOC = textDIUNG.Text
            };
            BenhNhanBUS bnbus = new BenhNhanBUS();
            int createHsba = bnbus.CapNhat(bn);
            if (createHsba != -1)
            {
                MessageBox.Show("Đã cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
