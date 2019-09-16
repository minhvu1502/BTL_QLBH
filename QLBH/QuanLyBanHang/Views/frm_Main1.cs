using System;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private bool CheckExistFrom(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void btMenu_Click(object sender, EventArgs e)
        {
            plLeft.Width = (plLeft.Width == 256) ? 0 : 256;
            //if (btMenu.Location.X == 0 && btMenu.Location.Y == 0)
            //    btMenu.Location = new System.Drawing.Point(195, 0);
            //else
            //    btMenu.Location = new System.Drawing.Point(0, 0);


        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            btn_QuanLy.BackColor = System.Drawing.Color.White;
            btn_TrangChu.BackColor = System.Drawing.Color.Gray;
            btn_TimKiem.BackColor = System.Drawing.Color.Gray;
            btn_Report.BackColor = System.Drawing.Color.Gray;
            btn_GioiThieu.BackColor = System.Drawing.Color.Gray;
            pl_QuanLy.Visible = true;
            pl_BaoCao.Visible = false;
            pl_TimKiem.Visible = false;
            pl_GioiThieu.Visible = false;
            pl_viewMain.Visible = true;
            lbTop.Text = btn_QuanLy.Tag.ToString();
            lbTop.Visible = true;
            lbTop.BackColor = pl_QuanLy.BackColor;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            btn_QuanLy.BackColor = System.Drawing.Color.Gray;
            btn_TrangChu.BackColor = System.Drawing.Color.Gray;
            btn_TimKiem.BackColor = System.Drawing.Color.White;
            btn_Report.BackColor = System.Drawing.Color.Gray;
            btn_GioiThieu.BackColor = System.Drawing.Color.Gray;
            pl_QuanLy.Visible = false;
            pl_BaoCao.Visible = false;
            pl_TimKiem.Visible = true;
            pl_GioiThieu.Visible = false;
            pl_viewMain.Visible = true;
            lbTop.Text = btn_TimKiem.Tag.ToString();
            lbTop.Visible = true;
            lbTop.BackColor = pl_TimKiem.BackColor;
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            btn_QuanLy.BackColor = System.Drawing.Color.Gray;
            btn_TrangChu.BackColor = System.Drawing.Color.Gray;
            btn_TimKiem.BackColor = System.Drawing.Color.Gray;
            btn_Report.BackColor = System.Drawing.Color.White;
            btn_GioiThieu.BackColor = System.Drawing.Color.Gray;
            pl_QuanLy.Visible = false;
            pl_BaoCao.Visible = true;
            pl_TimKiem.Visible = false;
            pl_viewMain.Visible = true;
            pl_GioiThieu.Visible = false;
            lbTop.Text = btn_Report.Tag.ToString();
            lbTop.Visible = true;
            lbTop.BackColor = pl_BaoCao.BackColor;
        }

        private void btn_GioiThieu_Click(object sender, EventArgs e)
        {
            btn_QuanLy.BackColor = System.Drawing.Color.Gray;
            btn_TrangChu.BackColor = System.Drawing.Color.Gray;
            btn_TimKiem.BackColor = System.Drawing.Color.Gray;
            btn_Report.BackColor = System.Drawing.Color.Gray;
            btn_GioiThieu.BackColor = System.Drawing.Color.White;
            pl_QuanLy.Visible = false;
            pl_BaoCao.Visible = false;
            pl_TimKiem.Visible = false;
            pl_GioiThieu.Visible = true;
            pl_viewMain.Visible = true;
            lbTop.Text = btn_GioiThieu.Tag.ToString();
            lbTop.Visible = true;
            lbTop.BackColor = pl_GioiThieu.BackColor;
        }

        private void btn_TKNV_Click(object sender, EventArgs e)
        {

        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            frm_NhanVien frm = new frm_NhanVien();
            frm.ShowDialog();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            pl_viewMain.Visible = false;
            btn_QuanLy.BackColor = System.Drawing.Color.Gray;
            btn_TrangChu.BackColor = System.Drawing.Color.White;
            btn_TimKiem.BackColor = System.Drawing.Color.Gray;
            btn_Report.BackColor = System.Drawing.Color.Gray;
            btn_GioiThieu.BackColor = System.Drawing.Color.Gray;
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            pl_viewMain.Visible = false;
        }

        private void btn_QLMA_Click(object sender, EventArgs e)
        {
            frm_MonAn frm = new frm_MonAn();
            frm.ShowDialog();
        }

        private void btn_QLNL_Click(object sender, EventArgs e)
        {
            frm_NguyenLieu frm = new frm_NguyenLieu();
            frm.ShowDialog();
        }
    }
}

