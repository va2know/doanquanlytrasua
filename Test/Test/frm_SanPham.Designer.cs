namespace Test
{
    partial class frm_SanPham
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
            this.btn_XoaSP = new System.Windows.Forms.Button();
            this.btn_SuaSP = new System.Windows.Forms.Button();
            this.btn_ThemSP = new System.Windows.Forms.Button();
            this.gb_SP = new System.Windows.Forms.GroupBox();
            this.txt_Mota = new System.Windows.Forms.TextBox();
            this.pic_SP = new System.Windows.Forms.PictureBox();
            this.txt_GiaSP = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.txt_IDSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_gridTTSP = new System.Windows.Forms.DataGridView();
            this.gb_SP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_gridTTSP)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_XoaSP
            // 
            this.btn_XoaSP.Location = new System.Drawing.Point(257, 27);
            this.btn_XoaSP.Name = "btn_XoaSP";
            this.btn_XoaSP.Size = new System.Drawing.Size(79, 36);
            this.btn_XoaSP.TabIndex = 18;
            this.btn_XoaSP.Text = "Xóa";
            this.btn_XoaSP.UseVisualStyleBackColor = true;
            this.btn_XoaSP.Click += new System.EventHandler(this.btn_XoaSP_Click);
            // 
            // btn_SuaSP
            // 
            this.btn_SuaSP.Location = new System.Drawing.Point(392, 27);
            this.btn_SuaSP.Name = "btn_SuaSP";
            this.btn_SuaSP.Size = new System.Drawing.Size(79, 36);
            this.btn_SuaSP.TabIndex = 19;
            this.btn_SuaSP.Text = "Sửa";
            this.btn_SuaSP.UseVisualStyleBackColor = true;
            this.btn_SuaSP.Click += new System.EventHandler(this.btn_SuaSP_Click);
            // 
            // btn_ThemSP
            // 
            this.btn_ThemSP.Location = new System.Drawing.Point(115, 27);
            this.btn_ThemSP.Name = "btn_ThemSP";
            this.btn_ThemSP.Size = new System.Drawing.Size(79, 36);
            this.btn_ThemSP.TabIndex = 17;
            this.btn_ThemSP.Text = "Thêm";
            this.btn_ThemSP.UseVisualStyleBackColor = true;
            this.btn_ThemSP.Click += new System.EventHandler(this.btn_ThemSP_Click);
            // 
            // gb_SP
            // 
            this.gb_SP.Controls.Add(this.txt_Mota);
            this.gb_SP.Controls.Add(this.pic_SP);
            this.gb_SP.Controls.Add(this.txt_GiaSP);
            this.gb_SP.Controls.Add(this.txt_TenSP);
            this.gb_SP.Controls.Add(this.txt_IDSP);
            this.gb_SP.Controls.Add(this.label4);
            this.gb_SP.Controls.Add(this.label3);
            this.gb_SP.Controls.Add(this.label2);
            this.gb_SP.Controls.Add(this.label1);
            this.gb_SP.Location = new System.Drawing.Point(525, 9);
            this.gb_SP.Name = "gb_SP";
            this.gb_SP.Size = new System.Drawing.Size(333, 538);
            this.gb_SP.TabIndex = 16;
            this.gb_SP.TabStop = false;
            // 
            // txt_Mota
            // 
            this.txt_Mota.Location = new System.Drawing.Point(168, 310);
            this.txt_Mota.Name = "txt_Mota";
            this.txt_Mota.Size = new System.Drawing.Size(100, 22);
            this.txt_Mota.TabIndex = 15;
            // 
            // pic_SP
            // 
            this.pic_SP.Location = new System.Drawing.Point(42, 354);
            this.pic_SP.Name = "pic_SP";
            this.pic_SP.Size = new System.Drawing.Size(226, 138);
            this.pic_SP.TabIndex = 14;
            this.pic_SP.TabStop = false;
            // 
            // txt_GiaSP
            // 
            this.txt_GiaSP.Location = new System.Drawing.Point(168, 282);
            this.txt_GiaSP.Name = "txt_GiaSP";
            this.txt_GiaSP.Size = new System.Drawing.Size(100, 22);
            this.txt_GiaSP.TabIndex = 13;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(168, 223);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(100, 22);
            this.txt_TenSP.TabIndex = 12;
            // 
            // txt_IDSP
            // 
            this.txt_IDSP.Location = new System.Drawing.Point(168, 166);
            this.txt_IDSP.Name = "txt_IDSP";
            this.txt_IDSP.Size = new System.Drawing.Size(100, 22);
            this.txt_IDSP.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Sản Phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // dt_gridTTSP
            // 
            this.dt_gridTTSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_gridTTSP.Location = new System.Drawing.Point(65, 97);
            this.dt_gridTTSP.Name = "dt_gridTTSP";
            this.dt_gridTTSP.RowHeadersWidth = 51;
            this.dt_gridTTSP.RowTemplate.Height = 24;
            this.dt_gridTTSP.Size = new System.Drawing.Size(452, 450);
            this.dt_gridTTSP.TabIndex = 15;
            this.dt_gridTTSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_gridTTSP_CellClick);
            // 
            // frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 557);
            this.Controls.Add(this.btn_XoaSP);
            this.Controls.Add(this.btn_SuaSP);
            this.Controls.Add(this.btn_ThemSP);
            this.Controls.Add(this.gb_SP);
            this.Controls.Add(this.dt_gridTTSP);
            this.Name = "frm_SanPham";
            this.Text = "ThucDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_SanPham_Load);
            this.gb_SP.ResumeLayout(false);
            this.gb_SP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_gridTTSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_XoaSP;
        private System.Windows.Forms.Button btn_SuaSP;
        private System.Windows.Forms.Button btn_ThemSP;
        private System.Windows.Forms.GroupBox gb_SP;
        private System.Windows.Forms.PictureBox pic_SP;
        private System.Windows.Forms.TextBox txt_GiaSP;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.TextBox txt_IDSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt_gridTTSP;
        private System.Windows.Forms.TextBox txt_Mota;
    }
}