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
    public partial class NghienCuu : Form
    {
        public NghienCuu()
        {
            InitializeComponent();
        }

        private void NghienCuu_Load(object sender, EventArgs e)
        {
            dataGridHSBA.DataSource = null;
            dataGridHSBA_DV.DataSource = null;
            HSBA_DVBUS hsba_dv = new HSBA_DVBUS();
            HSBABUS hsba = new HSBABUS();
            dataGridHSBA.DataSource = hsba.LayDuLieuViewNC();
            dataGridHSBA_DV.DataSource = hsba_dv.LayDuLieuViewNC();
        }
    }
}
