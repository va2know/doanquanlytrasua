using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class frm_TrangChu : Form
    {
        private frm_TrangChinh frmChinh;

        public frm_TrangChu()
        {
            InitializeComponent();
            this.Load += frm_TrangChu_Load;
            frmChinh = new frm_TrangChinh();
            frmChinh.MdiParent = this;
            frmChinh.Show();
        }

        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
 
        }

        private void btn_ThucDon_Click(object sender, EventArgs e)
        {
            // Mở form frm_SanPham
            if (Application.OpenForms["frm_SanPham"] == null)
            {
                frm_SanPham frm_SanPham = new frm_SanPham();
                frm_SanPham.MdiParent = this;
                frm_SanPham.Show();
            }
            else
            {
                Application.OpenForms["frm_SanPham"].Activate();
            }
        }

        private void btn_DanhSachBan_Click(object sender, EventArgs e)
        {
            // Mở form frm_DSBan
            if (Application.OpenForms["frm_DSBan"] == null)
            {
                frm_DSBan frm_DSBan = new frm_DSBan();
                frm_DSBan.MdiParent = this;
                frm_DSBan.Show();
            }
            else
            {
                Application.OpenForms["frm_DSBan"].Activate();
            }
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            // Mở form frm_HoaDon
            if (Application.OpenForms["frm_HoaDon"] == null)
            {
                frm_HoaDon frm_HoaDon = new frm_HoaDon();
                frm_HoaDon.MdiParent = this;
                frm_HoaDon.Show();
            }
            else
            {
                Application.OpenForms["frm_HoaDon"].Activate();
            }
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            // Kích hoạt lại form frm_TrangChinh
            if (frmChinh != null)
            {
                frmChinh.Activate();
            }
        }
    }
}
