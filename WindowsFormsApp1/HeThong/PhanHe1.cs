using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
    public partial class PhanHe1 : Form
    {
        public PhanHe1()
        {
            InitializeComponent();
        }

        private void textDanhsach_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            HeThongBUS nv = new HeThongBUS();
            dataGridView1.DataSource = nv.LayDuLieuUSER();
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            HeThongBUS nv = new HeThongBUS();
            dataGridView1.DataSource = nv.LayDuLieuTABLE();
        }
        private void textRole_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            HeThongBUS nv = new HeThongBUS();
            dataGridView1.DataSource = nv.LayDuLieuROLE();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView2.DataSource = null;
            HeThongBUS nv = new HeThongBUS();
            dataGridView2.DataSource = nv.LayDuLieuPRIVS_SYS_USER();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            HeThongBUS nv = new HeThongBUS();
            dataGridView2.DataSource = nv.LayDuLieuPRIVS_TAB_USER();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            HeThongBUS nv = new HeThongBUS();
            dataGridView2.DataSource = nv.LayDuLieuPRIVS_COL_USER();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            HeThongBUS nv = new HeThongBUS();
            dataGridView3.DataSource = nv.LayDuLieuPRIVS_SYS_ROLE();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            HeThongBUS nv = new HeThongBUS();
            dataGridView3.DataSource = nv.LayDuLieuPRIVS_TAB_ROLE();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string name = textCreUsername.Text;
            string password = textCrePassword.Text;
            HeThongBUS nv = new HeThongBUS();
            int createUser = nv.Create_User(name, password);
            if (createUser == -1)
            {
                MessageBox.Show("Đã tạo user thành công");
            }
            else
            {
                MessageBox.Show("Tạo user thất bại");
            }
            textCreUsername.Text = "";
            textCrePassword.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = null;
            HeThongBUS nv = new HeThongBUS();
            dataGridView4.DataSource = nv.LayDuLieuAtributeUSER("USERNAME");
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////
        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = null;
            HeThongBUS nv = new HeThongBUS();
            dataGridView5.DataSource = nv.LayDuLieuAtributeROLE("ROLE");
        }

        // Drop user
        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa user này?","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                HeThongBUS nv = new HeThongBUS();
                int index_row = dataGridView4.CurrentCell.RowIndex;
                string name = dataGridView4.Rows[index_row].Cells[0].Value.ToString();
                int dropUser = nv.Drop_User(name);
                if (dropUser == -1)
                {
                    MessageBox.Show("Đã xóa user thành công");
                }
                else
                {
                    MessageBox.Show("Xóa user thất bại");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index_row = dataGridView4.CurrentCell.RowIndex;
            string name = dataGridView4.Rows[index_row].Cells[0].Value.ToString();
            EditUser edit = new EditUser(name);
            this.Hide();
            edit.ShowDialog();
            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        { 
            int index_row = dataGridView5.CurrentCell.RowIndex;
            string name = dataGridView5.Rows[index_row].Cells[0].Value.ToString();
            EditRole edit = new EditRole(name);
            this.Hide();
            edit.ShowDialog();
            this.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string name = textRolename.Text;
            HeThongBUS nv = new HeThongBUS();
            int createRole = nv.Create_Role(name);
            if (createRole == -1)
            {
                MessageBox.Show("Đã tạo role thành công");
            }
            else
            {
                MessageBox.Show("Tạo role thất bại");
            }
            textRolename.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa role này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HeThongBUS nv = new HeThongBUS();
                int index_row = dataGridView5.CurrentCell.RowIndex;
                string name = dataGridView5.Rows[index_row].Cells[0].Value.ToString();
                int dropRole = nv.Drop_Role(name);
                if (dropRole == -1)
                {
                    MessageBox.Show("Đã xóa role thành công");
                }
                else
                {
                    MessageBox.Show("Xóa role thất bại");
                }
            }
        }


    }
}
