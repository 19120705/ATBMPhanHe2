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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        //BS_CS01_002
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string password = textPassword.Text;
            string vaitro = name.Substring(0, 2);
            if (checkLogin(name, password))
            {
                Info.NAME = name;
                Info.PASSWORD = password;
                switch (vaitro)
                {
                    case "BN":
                        GUI.BenhNhan form = new GUI.BenhNhan(name);
                        this.Hide();
                        form.ShowDialog();
                        this.Show();
                        break;
                    case "CS":
                        GUI.CSYT.CSYT form1 = new GUI.CSYT.CSYT();
                        this.Hide();
                        form1.ShowDialog();
                        this.Show();
                        break;
                    case "TT":
                        GUI.ThanhTra form2 = new GUI.ThanhTra();
                        this.Hide();
                        form2.ShowDialog();
                        this.Show();
                        break;
                    case "BS":
                        GUI.YBacSi form3 = new GUI.YBacSi();
                        this.Hide();
                        form3.ShowDialog();
                        this.Show();
                        break;
                    case "NC":
                        GUI.NghienCuu form4 = new GUI.NghienCuu();
                        this.Hide();
                        form4.ShowDialog();
                        this.Show();
                        break;
                    default:
                        PhanHe1 form5 = new PhanHe1();
                        this.Hide();
                        form5.ShowDialog();
                        this.Show();
                        break;
                }
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
