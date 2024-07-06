using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace Test
{
    public partial class frm_SanPham : Form
    {
        public frm_SanPham()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG LopChung = new LOPDUNGCHUNG();
        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            string sql = "Insert into SanPham values ('" + txt_IDSP.Text + "', N'" + txt_TenSP.Text + "','" + txt_GiaSP.Text + "',N'" + txt_Mota.Text + "')";

            int kq = LopChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Xóa không thành công");
            LoadSP();
        }
        public void LoadSP()
        {
            string sql = "Select * from SanPham";
            dt_gridTTSP.DataSource = LopChung.LoadDL(sql);
        }
        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            string sql = "DELETE SanPham where MaSanPham ='" + txt_IDSP.Text + "'";
            int kq = LopChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa không thành công");
            LoadSP();
        }

        private void btn_SuaSP_Click(object sender, EventArgs e)
        {
            string sql = "Update SanPham set TenSanPham =N'" + txt_TenSP.Text + "',DonGia ='" + txt_GiaSP.Text + "',MoTa =N'" + txt_Mota.Text + "' where MaSanPham ='" + txt_IDSP.Text + "'";
            int kq = LopChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật thành công");
            else MessageBox.Show("Cập nhật thất bại");
            LoadSP();
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            LoadSP();
        }

        private void dt_gridTTSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IDSP.Text = dt_gridTTSP.CurrentRow.Cells["MaSanPham"].Value.ToString();
            txt_TenSP.Text = dt_gridTTSP.CurrentRow.Cells["TenSanPham"].Value.ToString();
            txt_GiaSP.Text = dt_gridTTSP.CurrentRow.Cells["DonGia"].Value.ToString();
            txt_Mota.Text = dt_gridTTSP.CurrentRow.Cells["MoTa"].Value.ToString();
        }

       
    }
}