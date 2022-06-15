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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textDanhsach_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString = "SELECT USERNAME, USER_ID,ACCOUNT_STATUS, DEFAULT_TABLESPACE, CREATED FROM DBA_USERS";
                OracleCommand command = new OracleCommand(oracleString, conn);
                DataTable dtTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dtTable);
                dataGridView1.DataSource = dtTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void textRole_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString = "SELECT * FROM DBA_ROLES";
                OracleCommand command = new OracleCommand(oracleString, conn);
                DataTable dtTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dtTable);
                dataGridView1.DataSource = dtTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString = "SELECT * FROM DBA_SYS_PRIVS";
                OracleCommand command = new OracleCommand(oracleString, conn);
                DataTable dtTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dtTable);
                dataGridView2.DataSource = dtTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString = "SELECT * FROM DBA_TAB_PRIVS";
                OracleCommand command = new OracleCommand(oracleString, conn);
                DataTable dtTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dtTable);
                dataGridView2.DataSource = dtTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString = "SELECT * FROM DBA_COL_PRIVS";
                OracleCommand command = new OracleCommand(oracleString, conn);
                DataTable dtTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dtTable);
                dataGridView2.DataSource = dtTable;
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
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString = "SELECT * FROM ROLE_SYS_PRIVS";
                OracleCommand command = new OracleCommand(oracleString, conn);
                DataTable dtTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dtTable);
                dataGridView3.DataSource = dtTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString = "SELECT * FROM ROLE_TAB_PRIVS";
                OracleCommand command = new OracleCommand(oracleString, conn);
                DataTable dtTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dtTable);
                dataGridView3.DataSource = dtTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string name = textCreUsername.Text;
            string password = textCrePassword.Text;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleStringCreate = "CREATE USER " + name + " identified by " + password;

                OracleCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                cmd2.ExecuteNonQuery();
     
                //Create User
                OracleCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = oracleStringCreate;
                int data = cmd1.ExecuteNonQuery();
                if (data == -1)
                {
                    MessageBox.Show("Đã tạo user thành công");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            textCreUsername.Text = "";
            textCrePassword.Text = "";
            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = null;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString = "SELECT DISTINCT USERNAME FROM DBA_USERS";
                OracleCommand command = new OracleCommand(oracleString, conn);
                DataTable dtTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dtTable);
                dataGridView4.DataSource = dtTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = null;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString = "SELECT DISTINCT ROLE FROM DBA_ROLES";
                OracleCommand command = new OracleCommand(oracleString, conn);
                DataTable dtTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dtTable);
                dataGridView5.DataSource = dtTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Drop user
        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa user này?","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                string name = textDropName.Text;
                string oracleStringDrop = "DROP USER " + name;
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
                    cmd.CommandText = oracleStringDrop;
                    int data = cmd.ExecuteNonQuery();
                    if (data == -1)
                    {
                        MessageBox.Show("Đã xóa user thành công");
                    }    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();
            }
            textDropName.Text = "";
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditInfo.NAME_EDIT = textEditUser.Text;
            EditUser edit = new EditUser();
            this.Hide();
            edit.ShowDialog();
            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            EditInfo.ROLE_EDIT = textEditRolename.Text;
            EditRole edit = new EditRole();
            this.Hide();
            edit.ShowDialog();
            this.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string name = textRolename.Text;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleStringCreate = "CREATE ROLE " + name;

                OracleCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                cmd2.ExecuteNonQuery();

                //Create User
                OracleCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = oracleStringCreate;
                int data = cmd1.ExecuteNonQuery();
                if (data == -1)
                {
                    MessageBox.Show("Đã tạo role thành công");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            textRolename.Text = "";
            conn.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa user này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string name = textDropRolename.Text;
                string oracleStringDrop = "DROP ROLE " + name;
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
                    cmd.CommandText = oracleStringDrop;
                    int data = cmd.ExecuteNonQuery();
                    if (data == -1)
                    {
                        MessageBox.Show("Đã xóa role thành công");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();
            }
            textDropRolename.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
