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


namespace WindowsFormsApp1
{
    public partial class EditRole : Form
    {
        public EditRole()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            editRolename.Text = EditInfo.ROLE_EDIT;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString1 = "SELECT PRIVILEGE FROM ROLE_SYS_PRIVS";
                string oracleString2 = "SELECT PRIVILEGE FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + EditInfo.ROLE_EDIT + "'";
                OracleCommand command1 = new OracleCommand(oracleString1, conn);
                OracleCommand command2 = new OracleCommand(oracleString2, conn);
                DataTable dtTable1 = new DataTable();
                DataTable dtTable2 = new DataTable();
                OracleDataAdapter adapter1 = new OracleDataAdapter(command1);
                adapter1.Fill(dtTable1);
                OracleDataAdapter adapter2 = new OracleDataAdapter(command2);
                adapter2.Fill(dtTable2);
                dataGridView1.DataSource = dtTable1;
                dataGridView2.DataSource = dtTable2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string privsGrant = textGrantPrivs.Text;
            bool checkPrivsOption = checkOptionPrivs.Checked;
            string oracleString = "GRANT " + privsGrant + " TO " + EditInfo.ROLE_EDIT;

            if (checkPrivsOption)
                oracleString += " WITH ADMIN OPTION";
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                OracleCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                cmd2.ExecuteNonQuery();

                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = oracleString;
                int data = cmd.ExecuteNonQuery();
                if (data == -1)
                {
                    MessageBox.Show("Cấp privilege cho role thành công");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            checkOptionPrivs.Checked = false;
            textGrantPrivs.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string privsRevoke = textRevokePrivs.Text;
            string oracleString = "REVOKE " + privsRevoke + " FROM " + EditInfo.ROLE_EDIT;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                OracleCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                cmd2.ExecuteNonQuery();

                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = oracleString;
                int data = cmd.ExecuteNonQuery();
                if (data == -1)
                {
                    MessageBox.Show("Thu hồi privilege từ role thành công");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
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
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString5 = "SELECT TABLE_NAME,PRIVILEGE, GRANTEE FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + EditInfo.ROLE_EDIT + "'";
                string oracleString6 = "SELECT TABLE_NAME FROM ALL_TABLES WHERE OWNER = '" + Info.NAME.ToUpper() + "'";
                OracleCommand command5 = new OracleCommand(oracleString5, conn);
                OracleCommand command6 = new OracleCommand(oracleString6, conn);
                DataTable dtTable5 = new DataTable();
                DataTable dtTable6 = new DataTable();
                OracleDataAdapter adapter5 = new OracleDataAdapter(command5);
                adapter5.Fill(dtTable5);
                OracleDataAdapter adapter6 = new OracleDataAdapter(command6);
                adapter6.Fill(dtTable6);
                dataGridView5.DataSource = dtTable5;
                dataGridView6.DataSource = dtTable6;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string tableGrant = textTableGrant.Text;
            string privsType = EditInfo.COMBOBOX_ITEM;
            string oracleString = "GRANT " + privsType + " ON " + tableGrant + " TO " + EditInfo.ROLE_EDIT;

            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                OracleCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                cmd2.ExecuteNonQuery();

                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = oracleString;
                int data = cmd.ExecuteNonQuery();
                if (data == -1)
                {
                    MessageBox.Show("Cấp privilege table cho role thành công");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
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
            string oracleString = "REVOKE " + privsType + " ON " + tableRevoke + " FROM " + EditInfo.ROLE_EDIT;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                OracleCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                cmd2.ExecuteNonQuery();

                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = oracleString;
                int data = cmd.ExecuteNonQuery();
                if (data == -1)
                {
                    MessageBox.Show("Thu hồi privilege table từ role thành công");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            textTableRevoke.Text = "";
        }
    }
}
