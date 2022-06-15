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

namespace WindowsFormsApp1.GUI
{
    public partial class tesst : Form
    {
        public tesst()
        {
            InitializeComponent();
        }

        private void clickTableNhanVien_Click(object sender, EventArgs e)
        {
            dataGridViewTest.DataSource = null;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString = "SELECT * FROM S_DBA.S_NHANVIEN";
                OracleCommand command = new OracleCommand(oracleString, conn);
                DataTable dtTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dtTable);
                dataGridViewTest.DataSource = dtTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void clickKhachHang_Click(object sender, EventArgs e)
        {
            dataGridViewTest.DataSource = null;
            OracleConnection conn = DBUtils.GetDBConnection(Info.NAME, Info.PASSWORD);
            try
            {
                conn.Open();
                string oracleString = "SELECT * FROM S_DBA.S_BENHNHAN";
                OracleCommand command = new OracleCommand(oracleString, conn);
                DataTable dtTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dtTable);
                dataGridViewTest.DataSource = dtTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }
    }
}
