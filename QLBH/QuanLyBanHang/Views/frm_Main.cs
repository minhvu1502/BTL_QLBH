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
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //panel1.Visible = false ? true:false ;
        //    //panel2.Visible = false ? true:false;
        //    //button1.Visible = true;
        //    //button1.Location = new System.Drawing.Point(0, 0);
        //    pl_Menu.Width = (pl_Menu.Width == 195) ? 0 : 195;
        //    pl_Pictrure.Width = (pl_Pictrure.Width == 195) ? 0 : 195;
        //    //if (btn_Menu.Location.X == 0)
        //    //{
        //    //    btn_Menu.Location = new System.Drawing.Point(150, 0);
        //    //}
        //    //else
        //    //{
        //    //    btn_Menu.Location = new System.Drawing.Point(0, 0);
        //    //}
        //}

        //private void toolStripButton3_Click(object sender, EventArgs e)
        //{
        //    TSbtn_QuanLy.BackColor = System.Drawing.Color.Gray;
        //    TSbtn_Home.BackColor = System.Drawing.Color.White;
        //    TSbtn_TimKiem.BackColor = System.Drawing.Color.White;
        //    TSbtn_Report.BackColor = System.Drawing.Color.White;
        //    TSbtn_Info.BackColor = System.Drawing.Color.White;
        //    pl_QuanLy.Visible = true;
        //    pl_BaoCao.Visible = false;
        //    pl_TimKiem.Visible = false;
        //    pl_GioiThieu.Visible = false;
        //    lb_Tag.Text = TSbtn_QuanLy.Tag.ToString();
        //    lb_Tag.Visible = true;
        //    lb_Tag.BackColor = pl_QuanLy.BackColor;
        //}

        //private void TSbtn_TimKiem_Click(object sender, EventArgs e)
        //{
        //    TSbtn_QuanLy.BackColor = System.Drawing.Color.White;
        //    TSbtn_Home.BackColor = System.Drawing.Color.White;
        //    TSbtn_TimKiem.BackColor = System.Drawing.Color.Gray;
        //    TSbtn_Report.BackColor = System.Drawing.Color.White;
        //    TSbtn_Info.BackColor = System.Drawing.Color.White;
        //    pl_QuanLy.Visible = false;
        //    pl_BaoCao.Visible = false;
        //    pl_TimKiem.Visible = true;
        //    pl_GioiThieu.Visible = false;
        //    lb_Tag.Text = TSbtn_TimKiem.Tag.ToString();
        //    lb_Tag.Visible = true;
        //    lb_Tag.BackColor = pl_TimKiem.BackColor;
        //}

        //private void TSbtn_Report_Click(object sender, EventArgs e)
        //{
        //    TSbtn_QuanLy.BackColor = System.Drawing.Color.White;
        //    TSbtn_Home.BackColor = System.Drawing.Color.White;
        //    TSbtn_TimKiem.BackColor = System.Drawing.Color.White;
        //    TSbtn_Report.BackColor = System.Drawing.Color.Gray;
        //    TSbtn_Info.BackColor = System.Drawing.Color.White;
        //    pl_QuanLy.Visible = false;
        //    pl_BaoCao.Visible = true;
        //    pl_TimKiem.Visible = false;
        //    pl_GioiThieu.Visible = false;
        //    lb_Tag.Text = TSbtn_Report.Tag.ToString();
        //    lb_Tag.Visible = true;
        //    lb_Tag.BackColor = pl_BaoCao.BackColor;
        //}

        //private void TSbtn_Info_Click(object sender, EventArgs e)
        //{
        //    TSbtn_QuanLy.BackColor = System.Drawing.Color.White;
        //    TSbtn_Home.BackColor = System.Drawing.Color.White;
        //    TSbtn_TimKiem.BackColor = System.Drawing.Color.White;
        //    TSbtn_Report.BackColor = System.Drawing.Color.White;
        //    TSbtn_Info.BackColor = System.Drawing.Color.Gray;
        //    pl_QuanLy.Visible = false;
        //    pl_BaoCao.Visible = false;
        //    pl_TimKiem.Visible = false;
        //    pl_GioiThieu.Visible = true;
        //    lb_Tag.Text = TSbtn_Info.Tag.ToString();
        //    lb_Tag.Visible = true;
        //    lb_Tag.BackColor = pl_GioiThieu.BackColor;
        //}

        //private void TSbtn_Home_Click(object sender, EventArgs e)
        //{
        //    TSbtn_QuanLy.BackColor = System.Drawing.Color.White;
        //    TSbtn_Home.BackColor = System.Drawing.Color.Gray;
        //    TSbtn_TimKiem.BackColor = System.Drawing.Color.White;
        //    TSbtn_Report.BackColor = System.Drawing.Color.White;
        //    TSbtn_Info.BackColor = System.Drawing.Color.White;
        //    pl_QuanLy.Visible = false;
        //    pl_BaoCao.Visible = false;
        //    pl_TimKiem.Visible = false;
        //    pl_GioiThieu.Visible = false;
        //    lb_Tag.Text = TSbtn_Home.Tag.ToString();
        //    lb_Tag.Visible = true;
           
        }
    }

