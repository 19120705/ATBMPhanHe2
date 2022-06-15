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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string password = textPassword.Text;

            if(checkLogin(name, password))
            {
                Info.NAME = name;
                Info.PASSWORD= password;
                GUI.ThanhTra form = new GUI.ThanhTra();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Error name or password");
            }
            textName.Text = "";
            textPassword.Text = "";
        }
        bool checkLogin(string name, string password)
        {
            try
            {
                OracleConnection conn = DBUtils.GetDBConnection(name, password);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
