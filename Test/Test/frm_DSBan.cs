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
    public partial class frm_DSBan : Form
    {
        public frm_DSBan()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG LopChung = new LOPDUNGCHUNG();
        private void btn_ThemBan_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Ban values ('" + txt_IDBan.Text + "', N'" + txt_TenBan.Text + "',N'" + cb_TT.Text + "')";
            int kq = LopChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Xóa không thành công");
            LoadBan();
        }
        public void LoadBan()
        {
            string sql = "Select * from Ban";
            dtgrid_DSBan.DataSource = LopChung.LoadDL(sql);
        }
        private void btn_XoaBan_Click(object sender, EventArgs e)
        {
            string sql = "DELETE Ban where MaBan ='" + txt_IDBan.Text + "'";
            int kq = LopChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa không thành công");
            LoadBan();
        }

        private void btn_SuaBan_Click(object sender, EventArgs e)
        {
            string sql = "Update Ban set TenBan= N'" + txt_TenBan.Text + "',MoTa=N'" + cb_TT.Text + "' where  MaBan='" + txt_IDBan.Text + "'";
            int kq = LopChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật thành công");
            else MessageBox.Show("Cập nhật thất bại");
            LoadBan();
        }

        private void frm_DSBan_Load(object sender, EventArgs e)
        {
            LoadBan();
        }

        private void dtgrid_DSBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IDBan.Text = dtgrid_DSBan.CurrentRow.Cells["MaBan"].Value.ToString();
            txt_TenBan.Text = dtgrid_DSBan.CurrentRow.Cells["TenBan"].Value.ToString();
            cb_TT.Text = dtgrid_DSBan.CurrentRow.Cells["MoTa"].Value.ToString();
        }

       
    }
}