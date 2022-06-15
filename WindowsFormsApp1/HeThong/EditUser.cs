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

    public partial class EditUser : Form
    {

        public EditUser()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            editUsername.Text = EditInfo.NAME_EDIT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = editUsername.Text;
            string pass  = textRepPassword.Text;
            string cpass = textCRepPassword.Text;
            if (pass == cpass)
            {
                string oracleString = "ALTER USER " + name + " IDENTIFIED BY " + pass; 
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
                        MessageBox.Show("Cập nhật password của user thành công");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString1 = "SELECT DISTINCT ROLE FROM DBA_ROLES";
                string oracleString2 = "SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + EditInfo.NAME_EDIT+"'";
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

        private void button3_Click(object sender, EventArgs e)
        {
            string roleGraint = textGrant.Text;
            bool checkGraintOption = checkOption.Checked;
            string oracleString = "GRANT " + roleGraint + " TO " + EditInfo.NAME_EDIT;

            if (checkGraintOption)
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
                    MessageBox.Show("Cấp role cho user thành công");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            checkOption.Checked = false;
            textGrant.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string roleRevoke = textRevoke.Text;
            string oracleString = "REVOKE " + roleRevoke + " FROM " + EditInfo.NAME_EDIT;
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
                    MessageBox.Show("Thu hồi role từ user thành công");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString3 = "SELECT PRIVILEGE FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + EditInfo.NAME_EDIT+"'";
                string oracleString4 = "SELECT PRIVILEGE FROM USER_SYS_PRIVS";
                OracleCommand command3 = new OracleCommand(oracleString3, conn);
                OracleCommand command4 = new OracleCommand(oracleString4, conn);
                DataTable dtTable3 = new DataTable();
                DataTable dtTable4 = new DataTable();
                OracleDataAdapter adapter3 = new OracleDataAdapter(command3);
                adapter3.Fill(dtTable3);
                OracleDataAdapter adapter4 = new OracleDataAdapter(command4);
                adapter4.Fill(dtTable4);
                dataGridView3.DataSource = dtTable3;
                dataGridView4.DataSource = dtTable4;
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
            string oracleString = "GRANT " + privsGrant + " TO " + EditInfo.NAME_EDIT;

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
                    MessageBox.Show("Cấp privilege cho user thành công");
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
            string oracleString = "REVOKE " + privsRevoke + " FROM " + EditInfo.NAME_EDIT;
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
                    MessageBox.Show("Thu hồi privilege từ user thành công");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            textRevokePrivs.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            EditInfo.COMBOBOX_ITEM = comboBox.SelectedItem.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = null;
            dataGridView6.DataSource = null;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString5 =  "SELECT TABLE_NAME,PRIVILEGE, GRANTEE FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + EditInfo.NAME_EDIT + "'";
                string oracleString6 =  "SELECT TABLE_NAME FROM ALL_TABLES WHERE OWNER = '" + Info.NAME.ToUpper() + "'";
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
            string oracleString = "GRANT " + privsType + " ON " + tableGrant + " TO " + EditInfo.NAME_EDIT;
           
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
                    MessageBox.Show("Cấp privilege table cho user thành công");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            textTableGrant.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string tableRevoke = textTableRevoke.Text;
            string privsType = EditInfo.COMBOBOX_ITEM_REVOKE;
            string oracleString = "REVOKE " + privsType + " ON " + tableRevoke + " FROM " + EditInfo.NAME_EDIT;
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
                    MessageBox.Show("Thu hồi privilege table từ user thành công");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            textTableRevoke.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            EditInfo.COMBOBOX_ITEM_REVOKE = comboBox.SelectedItem.ToString();
        }
    }
}
