namespace Test
{
    partial class frm_TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.grb_Menu = new System.Windows.Forms.GroupBox();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.btn_DanhSachBan = new System.Windows.Forms.Button();
            this.btn_ThucDon = new System.Windows.Forms.Button();
            this.btn_TrangChu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grb_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.grb_Menu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 648);
            this.panel1.TabIndex = 18;
            // 
            // grb_Menu
            // 
            this.grb_Menu.Controls.Add(this.btn_HoaDon);
            this.grb_Menu.Controls.Add(this.btn_DanhSachBan);
            this.grb_Menu.Controls.Add(this.btn_ThucDon);
            this.grb_Menu.Controls.Add(this.btn_TrangChu);
            this.grb_Menu.Location = new System.Drawing.Point(3, 129);
            this.grb_Menu.Name = "grb_Menu";
            this.grb_Menu.Size = new System.Drawing.Size(248, 343);
            this.grb_Menu.TabIndex = 0;
            this.grb_Menu.TabStop = false;
            this.grb_Menu.Text = "Quản Lý";
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.Coral;
            this.btn_HoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_HoaDon.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btn_HoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_HoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoaDon.Location = new System.Drawing.Point(3, 256);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(242, 79);
            this.btn_HoaDon.TabIndex = 3;
            this.btn_HoaDon.Text = "Hóa Đơn";
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // btn_DanhSachBan
            // 
            this.btn_DanhSachBan.BackColor = System.Drawing.Color.Coral;
            this.btn_DanhSachBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DanhSachBan.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btn_DanhSachBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_DanhSachBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_DanhSachBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DanhSachBan.Location = new System.Drawing.Point(3, 177);
            this.btn_DanhSachBan.Name = "btn_DanhSachBan";
            this.btn_DanhSachBan.Size = new System.Drawing.Size(242, 79);
            this.btn_DanhSachBan.TabIndex = 2;
            this.btn_DanhSachBan.Text = "Danh Sách Bàn";
            this.btn_DanhSachBan.UseVisualStyleBackColor = false;
            this.btn_DanhSachBan.Click += new System.EventHandler(this.btn_DanhSachBan_Click);
            // 
            // btn_ThucDon
            // 
            this.btn_ThucDon.BackColor = System.Drawing.Color.Coral;
            this.btn_ThucDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ThucDon.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btn_ThucDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_ThucDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_ThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThucDon.Location = new System.Drawing.Point(3, 97);
            this.btn_ThucDon.Name = "btn_ThucDon";
            this.btn_ThucDon.Size = new System.Drawing.Size(242, 80);
            this.btn_ThucDon.TabIndex = 1;
            this.btn_ThucDon.Text = "Thực Đơn";
            this.btn_ThucDon.UseVisualStyleBackColor = false;
            this.btn_ThucDon.Click += new System.EventHandler(this.btn_ThucDon_Click);
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.BackColor = System.Drawing.Color.Coral;
            this.btn_TrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TrangChu.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btn_TrangChu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_TrangChu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_TrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu.Location = new System.Drawing.Point(3, 18);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(242, 79);
            this.btn_TrangChu.TabIndex = 0;
            this.btn_TrangChu.Text = "Trang Chủ";
            this.btn_TrangChu.UseVisualStyleBackColor = false;
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trà Sữa Ma";
            // 
            // frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 648);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frm_TrangChu";
            this.Text = "Phan Mem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grb_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grb_Menu;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.Button btn_DanhSachBan;
        private System.Windows.Forms.Button btn_ThucDon;
        private System.Windows.Forms.Button btn_TrangChu;
        private System.Windows.Forms.Label label1;
    }
}

