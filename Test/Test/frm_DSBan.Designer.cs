namespace Test
{
    partial class frm_DSBan
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
            this.btn_XoaBan = new System.Windows.Forms.Button();
            this.btn_SuaBan = new System.Windows.Forms.Button();
            this.btn_ThemBan = new System.Windows.Forms.Button();
            this.gb_Ban = new System.Windows.Forms.GroupBox();
            this.cb_TT = new System.Windows.Forms.ComboBox();
            this.txt_TenBan = new System.Windows.Forms.TextBox();
            this.txt_IDBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrid_DSBan = new System.Windows.Forms.DataGridView();
            this.numericChartRangeControlClient1 = new DevExpress.XtraEditors.NumericChartRangeControlClient();
            this.gb_Ban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_DSBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_XoaBan
            // 
            this.btn_XoaBan.Location = new System.Drawing.Point(294, 57);
            this.btn_XoaBan.Name = "btn_XoaBan";
            this.btn_XoaBan.Size = new System.Drawing.Size(79, 36);
            this.btn_XoaBan.TabIndex = 13;
            this.btn_XoaBan.Text = "Xóa";
            this.btn_XoaBan.UseVisualStyleBackColor = true;
            this.btn_XoaBan.Click += new System.EventHandler(this.btn_XoaBan_Click);
            // 
            // btn_SuaBan
            // 
            this.btn_SuaBan.Location = new System.Drawing.Point(429, 57);
            this.btn_SuaBan.Name = "btn_SuaBan";
            this.btn_SuaBan.Size = new System.Drawing.Size(79, 36);
            this.btn_SuaBan.TabIndex = 14;
            this.btn_SuaBan.Text = "Sửa";
            this.btn_SuaBan.UseVisualStyleBackColor = true;
            this.btn_SuaBan.Click += new System.EventHandler(this.btn_SuaBan_Click);
            // 
            // btn_ThemBan
            // 
            this.btn_ThemBan.Location = new System.Drawing.Point(152, 57);
            this.btn_ThemBan.Name = "btn_ThemBan";
            this.btn_ThemBan.Size = new System.Drawing.Size(79, 36);
            this.btn_ThemBan.TabIndex = 12;
            this.btn_ThemBan.Text = "Thêm";
            this.btn_ThemBan.UseVisualStyleBackColor = true;
            this.btn_ThemBan.Click += new System.EventHandler(this.btn_ThemBan_Click);
            // 
            // gb_Ban
            // 
            this.gb_Ban.Controls.Add(this.cb_TT);
            this.gb_Ban.Controls.Add(this.txt_TenBan);
            this.gb_Ban.Controls.Add(this.txt_IDBan);
            this.gb_Ban.Controls.Add(this.label4);
            this.gb_Ban.Controls.Add(this.label3);
            this.gb_Ban.Controls.Add(this.label2);
            this.gb_Ban.Controls.Add(this.label1);
            this.gb_Ban.Location = new System.Drawing.Point(562, 39);
            this.gb_Ban.Name = "gb_Ban";
            this.gb_Ban.Size = new System.Drawing.Size(303, 538);
            this.gb_Ban.TabIndex = 11;
            this.gb_Ban.TabStop = false;
            // 
            // cb_TT
            // 
            this.cb_TT.FormattingEnabled = true;
            this.cb_TT.Items.AddRange(new object[] {
            "Trống",
            "Có Người"});
            this.cb_TT.Location = new System.Drawing.Point(171, 386);
            this.cb_TT.Name = "cb_TT";
            this.cb_TT.Size = new System.Drawing.Size(100, 24);
            this.cb_TT.TabIndex = 13;
            this.cb_TT.Text = "Trống";
            // 
            // txt_TenBan
            // 
            this.txt_TenBan.Location = new System.Drawing.Point(171, 301);
            this.txt_TenBan.Name = "txt_TenBan";
            this.txt_TenBan.Size = new System.Drawing.Size(100, 22);
            this.txt_TenBan.TabIndex = 12;
            // 
            // txt_IDBan
            // 
            this.txt_IDBan.Location = new System.Drawing.Point(171, 218);
            this.txt_IDBan.Name = "txt_IDBan";
            this.txt_IDBan.Size = new System.Drawing.Size(100, 22);
            this.txt_IDBan.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trạng Thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Bàn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "THÔNG TIN BÀN ĂN";
            // 
            // dtgrid_DSBan
            // 
            this.dtgrid_DSBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_DSBan.Location = new System.Drawing.Point(102, 127);
            this.dtgrid_DSBan.Name = "dtgrid_DSBan";
            this.dtgrid_DSBan.RowHeadersWidth = 51;
            this.dtgrid_DSBan.RowTemplate.Height = 24;
            this.dtgrid_DSBan.Size = new System.Drawing.Size(452, 450);
            this.dtgrid_DSBan.TabIndex = 10;
            this.dtgrid_DSBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_DSBan_CellClick);
            // 
            // frm_DSBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 616);
            this.Controls.Add(this.btn_XoaBan);
            this.Controls.Add(this.btn_SuaBan);
            this.Controls.Add(this.btn_ThemBan);
            this.Controls.Add(this.gb_Ban);
            this.Controls.Add(this.dtgrid_DSBan);
            this.Name = "frm_DSBan";
            this.Text = "frm_DSBan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_DSBan_Load);
            this.gb_Ban.ResumeLayout(false);
            this.gb_Ban.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_DSBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_XoaBan;
        private System.Windows.Forms.Button btn_SuaBan;
        private System.Windows.Forms.Button btn_ThemBan;
        private System.Windows.Forms.GroupBox gb_Ban;
        private System.Windows.Forms.ComboBox cb_TT;
        private System.Windows.Forms.TextBox txt_TenBan;
        private System.Windows.Forms.TextBox txt_IDBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrid_DSBan;
        private DevExpress.XtraEditors.NumericChartRangeControlClient numericChartRangeControlClient1;
    }
}