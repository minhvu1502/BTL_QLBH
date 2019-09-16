using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frm_Main frm = new frm_Main();
            frm.FormClosed += new FormClosedEventHandler(frm_Closed);
            frm.Show();
            this.Hide();
        }
        private void frm_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ret =
                MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(ret == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
