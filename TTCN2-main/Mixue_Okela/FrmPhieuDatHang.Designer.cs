namespace Mixue_Okela
{
    partial class FrmPhieuDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhieuDatHang));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_PhieuDatHang = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaPDH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.dtpNgayTaoPhieu = new System.Windows.Forms.DateTimePicker();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuDatHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox3.Controls.Add(this.txtSoLuong);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cboMaSP);
            this.groupBox3.Controls.Add(this.txtTenSP);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dgv_PhieuDatHang);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(-3, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(784, 282);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(579, 27);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(144, 26);
            this.txtSoLuong.TabIndex = 31;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Số lượng";
            // 
            // cboMaSP
            // 
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(165, 22);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(147, 27);
            this.cboMaSP.TabIndex = 29;
            this.cboMaSP.SelectedIndexChanged += new System.EventHandler(this.cboMaSP_SelectedIndexChanged);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(165, 64);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(144, 26);
            this.txtTenSP.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tên SP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mã SP";
            // 
            // dgv_PhieuDatHang
            // 
            this.dgv_PhieuDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong});
            this.dgv_PhieuDatHang.Location = new System.Drawing.Point(65, 109);
            this.dgv_PhieuDatHang.Name = "dgv_PhieuDatHang";
            this.dgv_PhieuDatHang.Size = new System.Drawing.Size(679, 150);
            this.dgv_PhieuDatHang.TabIndex = 0;
            this.dgv_PhieuDatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuDatHang_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 120;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 120;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(312, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 31);
            this.label9.TabIndex = 22;
            this.label9.Text = "Phiếu đặt hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_dong);
            this.groupBox2.Controls.Add(this.btn_luu);
            this.groupBox2.Controls.Add(this.btn_huy);
            this.groupBox2.Controls.Add(this.btn_in);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(-3, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 82);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xoa.Location = new System.Drawing.Point(570, 25);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(83, 46);
            this.btn_xoa.TabIndex = 41;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dong.Location = new System.Drawing.Point(688, 25);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(83, 46);
            this.btn_dong.TabIndex = 40;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_luu.Location = new System.Drawing.Point(321, 25);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(83, 46);
            this.btn_luu.TabIndex = 39;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_huy.Location = new System.Drawing.Point(453, 25);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(83, 46);
            this.btn_huy.TabIndex = 38;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_in
            // 
            this.btn_in.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_in.Location = new System.Drawing.Point(193, 25);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(83, 46);
            this.btn_in.TabIndex = 37;
            this.btn_in.Text = "In phiếu";
            this.btn_in.UseVisualStyleBackColor = false;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_them.Location = new System.Drawing.Point(65, 25);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(83, 46);
            this.btn_them.TabIndex = 35;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox1.Controls.Add(this.txtMaPDH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.dtpNgayTaoPhieu);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-3, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 112);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtMaPDH
            // 
            this.txtMaPDH.Location = new System.Drawing.Point(168, 37);
            this.txtMaPDH.Name = "txtMaPDH";
            this.txtMaPDH.Size = new System.Drawing.Size(144, 26);
            this.txtMaPDH.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã PDH";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(165, 79);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(147, 27);
            this.cboMaNV.TabIndex = 23;
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            // 
            // dtpNgayTaoPhieu
            // 
            this.dtpNgayTaoPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTaoPhieu.Location = new System.Drawing.Point(579, 77);
            this.dtpNgayTaoPhieu.Name = "dtpNgayTaoPhieu";
            this.dtpNgayTaoPhieu.Size = new System.Drawing.Size(144, 26);
            this.dtpNgayTaoPhieu.TabIndex = 22;
            this.dtpNgayTaoPhieu.Value = new System.DateTime(2021, 5, 18, 0, 0, 0, 0);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(579, 34);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(144, 26);
            this.txtTenNV.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày tạo";
            // 
            // FrmPhieuDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.ClientSize = new System.Drawing.Size(778, 537);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPhieuDatHang";
            this.Text = "Phiếu đặt hàng";
            this.Load += new System.EventHandler(this.FrmPhieuDatHang_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuDatHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_PhieuDatHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaPDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayTaoPhieu;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}