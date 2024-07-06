using Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Filtering.Templates;

namespace Test
{
    public partial class frm_HoaDon : Form
    {
        DataTable dtChiTietHoaDon = new DataTable();
        public frm_HoaDon()
        {
            InitializeComponent();
            LoadSanPhamToCombobox();

            dtChiTietHoaDon.Columns.Add("TenSanPham", typeof(string));
            dtChiTietHoaDon.Columns.Add("SoLuong", typeof(int));
            dtChiTietHoaDon.Columns.Add("DonGia", typeof(decimal));
            dtChiTietHoaDon.Columns.Add("ThanhTien", typeof(decimal));
            dt_gridMon.DataSource = dtChiTietHoaDon;

            
        }

        LOPDUNGCHUNG LopChung = new LOPDUNGCHUNG();



        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadSanPhamToCombobox()
        {
            try
            {
                DataTable dt = LopChung.LoadDL("SELECT TenSanPham FROM SanPham");
                if (dt != null && dt.Rows.Count > 0)
                {
                    cb_Mon.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        cb_Mon.Items.Add(row["TenSanPham"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu sản phẩm!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sản phẩm: " + ex.Message);
            }
        }
       

        private decimal GetDonGiaByTenSanPham(string tenSanPham)
        {
            try
            {
                string sql = $"SELECT DonGia FROM SanPham WHERE TenSanPham = '{tenSanPham}'";
                decimal donGia = (decimal)LopChung.LayGT(sql);
                return donGia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy giá sản phẩm: " + ex.Message);
                return 0;
            }
        }


        private void btn_ThemMon_Click_1(object sender, EventArgs e)
        {
            if (cb_Mon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
                return;
            }

            if (nud_SoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                return;
            }

            // Get product details
            string tenSanPham = cb_Mon.SelectedItem.ToString();
            int soLuong = (int)nud_SoLuong.Value;
            decimal donGia = GetDonGiaByTenSanPham(tenSanPham);

            // Calculate total price
            decimal thanhTien = soLuong * donGia;

            // Add order detail to DataTable
            DataRow newRow = dtChiTietHoaDon.NewRow();
            newRow["TenSanPham"] = tenSanPham;
            newRow["SoLuong"] = soLuong;
            newRow["DonGia"] = donGia;
            newRow["ThanhTien"] = thanhTien;
            dtChiTietHoaDon.Rows.Add(newRow);
       
            txt_TongTien.Text = UpdateTongTien().ToString("N0");
            // Clear selection and input fields
            cb_Mon.SelectedIndex = -1;
            nud_SoLuong.Value = 0;          
        }
        private decimal UpdateTongTien()
        {
            decimal tongTien = 0;
            foreach (DataRow row in dtChiTietHoaDon.Rows)
            {
                tongTien += (decimal)row["ThanhTien"];
            }
            return tongTien;
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (dt_gridMon.Rows.Count < 2)
            {

                MessageBox.Show("Thanh toán thất bại. Vui lòng thêm các mục trong giỏ hàng trước khi thanh toán.");
            }
            else
            {

                MessageBox.Show("Thanh toán thành công");
            }
        }
        public DataTable GridData
        {
            get { return dt_gridMon.DataSource as DataTable; }
            set { dt_gridMon.DataSource = value; }
        }
       
        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            frm_InHoaDon hd = new frm_InHoaDon();

            hd.Show();
            hd.GridData = this.GridData;
        }
    }
}
