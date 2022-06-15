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
    public partial class ThanhTra : Form
    {
        public ThanhTra()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            NhanVienBUS nv=new NhanVienBUS();
            dataGridView.DataSource = nv.LayDuLieu();
        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            BenhNhanBUS bn = new BenhNhanBUS();
            dataGridView.DataSource = bn.LayDuLieu();
        }

        private void btnCSYT_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            CSYTBUS csyt = new CSYTBUS();
            dataGridView.DataSource = csyt.LayDuLieu();
        }

        private void btnHSBA_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            HSBABUS hsba = new HSBABUS();
            dataGridView.DataSource = hsba.LayDuLieu();
        }

        private void btnHSBA_DV_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            HSBA_DVBUS hsba_dv = new HSBA_DVBUS();
            dataGridView.DataSource = hsba_dv.LayDuLieu();
        }

    }
}
