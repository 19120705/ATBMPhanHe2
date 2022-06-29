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
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class EditRole : Form
    {
        private string _message;
        public EditRole()
        {
            InitializeComponent();
        }
        public EditRole(string Message) : this()
        {
            _message = Message;
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            editRolename.Text = _message;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            string oracleString1 = "SELECT PRIVILEGE FROM ROLE_SYS_PRIVS";
            string oracleString2 = "SELECT PRIVILEGE FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + _message + "'";
            XL_DuLieu xl = new XL_DuLieu();
            dataGridView1.DataSource = xl.LayDuLieu(oracleString1);
            dataGridView2.DataSource = xl.LayDuLieu(oracleString2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string privsGrant = textGrantPrivs.Text;
            bool checkPrivsOption = checkOptionPrivs.Checked;
            string oracleString = "GRANT " + privsGrant + " TO " + _message;
            if (checkPrivsOption)
                oracleString += " WITH ADMIN OPTION";
            HeThongBUS htbus = new HeThongBUS();
            int data = htbus.ThucThi(oracleString);
            if (data == -1)
            {
                MessageBox.Show("Cấp privilege cho role thành công");

            }
            else
            {
                MessageBox.Show("Cấp privilege cho role không thành công");
            }
            checkOptionPrivs.Checked = false;
            textGrantPrivs.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string privsRevoke = textRevokePrivs.Text;
            string oracleString = "REVOKE " + privsRevoke + " FROM " + _message;
            HeThongBUS htbus = new HeThongBUS();
            int data = htbus.ThucThi(oracleString);
            if (data == -1)
            {
                MessageBox.Show("Thu hồi privilege từ role thành công");

            }
            else
            {
                MessageBox.Show("Thu hồi privilege từ role không thành công");
            }
            textRevokePrivs.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textRevokePrivs_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = null;
            dataGridView6.DataSource = null;
            string oracleString5 = "SELECT TABLE_NAME,PRIVILEGE, GRANTEE FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + _message + "'";
            string oracleString6 = "SELECT TABLE_NAME FROM ALL_TABLES WHERE OWNER = '" + Info.NAME.ToUpper() + "'";
            XL_DuLieu xl = new XL_DuLieu();
            dataGridView5.DataSource = xl.LayDuLieu(oracleString5);
            dataGridView6.DataSource = xl.LayDuLieu(oracleString6);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string tableGrant = textTableGrant.Text;
            string privsType = EditInfo.COMBOBOX_ITEM;
            string oracleString = "GRANT " + privsType + " ON " + tableGrant + " TO " + _message;
            HeThongBUS htbus = new HeThongBUS();
            int data = htbus.ThucThi(oracleString);
            if (data == -1)
            {
                MessageBox.Show("Cấp privilege table cho role thành công");

            }
            else
            {
                MessageBox.Show("Cấp privilege table cho role không thành công");
            }
            textTableGrant.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            EditInfo.COMBOBOX_ITEM = comboBox.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            EditInfo.COMBOBOX_ITEM_REVOKE = comboBox.SelectedItem.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string tableRevoke = textTableRevoke.Text;
            string privsType = EditInfo.COMBOBOX_ITEM_REVOKE;
            string oracleString = "REVOKE " + privsType + " ON " + tableRevoke + " FROM " + _message;
            HeThongBUS htbus = new HeThongBUS();
            int data = htbus.ThucThi(oracleString);
            if (data == -1)
            {
                MessageBox.Show("Thu hồi privilege table từ role thành công");

            }
            else
            {
                MessageBox.Show("Thu hồi privilege table từ role không thành công");
            }          
            textTableRevoke.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_row = dataGridView1.CurrentCell.RowIndex;
            string name = dataGridView1.Rows[index_row].Cells[0].Value.ToString();
            textGrantPrivs.Text = name;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_row = dataGridView2.CurrentCell.RowIndex;
            string name = dataGridView2.Rows[index_row].Cells[0].Value.ToString();
            textRevokePrivs.Text = name;
        }

        private void dataGridView6_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index_row = dataGridView6.CurrentCell.RowIndex;
            string name = dataGridView6.Rows[index_row].Cells[0].Value.ToString();
            textTableGrant.Text = name;
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_row = dataGridView5.CurrentCell.RowIndex;
            string name = dataGridView5.Rows[index_row].Cells[0].Value.ToString();
            textTableRevoke.Text = name;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            EditInfo.COMBOBOX_ITEM = comboBox.SelectedItem.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            EditInfo.COMBOBOX_ITEM_REVOKE = comboBox.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = null;
            dataGridViewCollumPris.DataSource = null;
            string oracleString1 = "SELECT TABLE_NAME FROM ALL_TABLES WHERE OWNER = '" + Info.NAME.ToUpper() + "'";
            string oracleString2 = "SELECT TABLE_NAME, COLUMN_NAME, PRIVILEGE,GRANTEE,OWNER FROM DBA_COL_PRIVS WHERE GRANTEE = '" + _message + "'";
            XL_DuLieu xl = new XL_DuLieu();
            dataGridViewTable.DataSource = xl.LayDuLieu(oracleString1);
            dataGridViewCollumPris.DataSource = xl.LayDuLieu(oracleString2);
        }

        private void dataGridViewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_row = dataGridViewTable.CurrentCell.RowIndex;
            string name = dataGridViewTable.Rows[index_row].Cells[0].Value.ToString();
            string oracleString1 = "SELECT * FROM "+name+" WHERE 1!=1";
            XL_DuLieu xl = new XL_DuLieu();
            dataGridViewField.DataSource = xl.LayDuLieu(oracleString1);
            textGraintTable1.Text = name;
        }

        private void dataGridViewField_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_row = dataGridViewField.CurrentCell.RowIndex;
            string name = dataGridViewField.Rows[index_row].Cells[0].Value.ToString();
            textGraintCollum1.Text = name;
        }

        private void dataGridViewCollumPris_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_row = dataGridViewCollumPris.CurrentCell.RowIndex;
            string table = dataGridViewCollumPris.Rows[index_row].Cells[0].Value.ToString();
            string collum = dataGridViewCollumPris.Rows[index_row].Cells[1].Value.ToString();
            EditInfo.COMBOBOX_ITEM_REVOKE = dataGridViewCollumPris.Rows[index_row].Cells[2].Value.ToString();
            textRevokeTable1.Text = table;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tableGrant = textGraintTable1.Text;
            string privsType = EditInfo.COMBOBOX_ITEM;
            string colGrant = textGraintCollum1.Text;
            string oracleString = "GRANT " + privsType + "("+colGrant+")"+" ON " + tableGrant + " TO " + _message;
            HeThongBUS htbus = new HeThongBUS();
            int data = htbus.ThucThi(oracleString);
            if (data == -1)
            {
                MessageBox.Show("Cấp privilege column table cho role thành công");

            }
            else
            {
                MessageBox.Show("Cấp privilege column table cho role không thành công");
            }
            textTableGrant.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tableRevoke = textRevokeTable1.Text;
            string privsType = EditInfo.COMBOBOX_ITEM_REVOKE;
            string oracleString = "REVOKE " + privsType + " ON " + tableRevoke + " FROM " + _message;
            HeThongBUS htbus = new HeThongBUS();
            int data = htbus.ThucThi(oracleString);
            if (data == -1)
            {
                MessageBox.Show("Thu hồi privilege table từ role thành công");

            }
            else
            {
                MessageBox.Show("Thu hồi privilege table từ role không thành công");
            }
            textTableRevoke.Text = "";
        }
    }
}
