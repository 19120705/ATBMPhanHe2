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
    public partial class CSYT : Form
    {
        public CSYT()
        {
            InitializeComponent();
        }

        private void refHSBA_Click(object sender, EventArgs e)
        {
            dataGridHSBA.DataSource = null;
            HSBABUS nv = new HSBABUS();
            dataGridHSBA.DataSource = nv.LayDuLieu();
        }

        private void dataGridHSBA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_row = dataGridHSBA.CurrentCell.RowIndex;
            string name = dataGridHSBA.Rows[index_row].Cells[0].Value.ToString();
            dataGridHSBA_DV.DataSource = null;
            HSBA_DVBUS nv = new HSBA_DVBUS();   
            dataGridHSBA_DV.DataSource = nv.LayDuLieuAtribute(name);
        }

        private void themHSBA_Click(object sender, EventArgs e)
        {
            GUI.CSYT.themHSBA form = new GUI.CSYT.themHSBA();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void xoaHSBA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hồ sơ bệnh án này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HSBABUS nv = new HSBABUS();
                int index_row = dataGridHSBA.CurrentCell.RowIndex;
                string name = dataGridHSBA.Rows[index_row].Cells[0].Value.ToString();
                int dropHSBA = nv.Xoa(name);
                if (dropHSBA != -1)
                {
                    MessageBox.Show("Đã xóa hồ sơ bệnh án thành công");
                }
                else
                {
                    MessageBox.Show("Xóa hồ sơ bệnh án thất bại");
                }
            }
        }

        private void xoaHSBA_DV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dịch vụ này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HSBA_DVBUS nv = new HSBA_DVBUS();
                int index_row = dataGridHSBA_DV.CurrentCell.RowIndex;
                string mahsba = dataGridHSBA_DV.Rows[index_row].Cells[0].Value.ToString();
                string madv = dataGridHSBA_DV.Rows[index_row].Cells[1].Value.ToString();
                string ngay = dataGridHSBA_DV.Rows[index_row].Cells[2].Value.ToString();
                ngay=ngay.Substring(0,ngay.IndexOf(" ")).ToString();
                int dropHSBA_DV = nv.Xoa(mahsba,madv,ngay);
                if (dropHSBA_DV != -1)
                {
                    MessageBox.Show("Đã xóa dịch vụ thành công");
                }
                else
                {
                    MessageBox.Show("Xóa dịch vụ thất bại");
                }
            }
        }

        private void themHSBA_DV_Click(object sender, EventArgs e)
        {
            int index_row = dataGridHSBA.CurrentCell.RowIndex;
            string mahsba = dataGridHSBA.Rows[index_row].Cells[0].Value.ToString();
            GUI.CSYT.themHSBA_DV form = new GUI.CSYT.themHSBA_DV(mahsba);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
