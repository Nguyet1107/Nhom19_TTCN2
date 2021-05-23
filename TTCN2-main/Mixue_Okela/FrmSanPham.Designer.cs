namespace Mixue_Okela
{
    partial class FrmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridView_SP = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SP)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox1.Controls.Add(this.cboMaNCC);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtDonVi);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Thông tin chung";
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(367, 40);
            this.cboMaNCC.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(123, 27);
            this.cboMaNCC.TabIndex = 26;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(103, 80);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(123, 26);
            this.txtTenSP.TabIndex = 25;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(611, 40);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(123, 26);
            this.txtDonGia.TabIndex = 24;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(611, 80);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(123, 26);
            this.txtDonVi.TabIndex = 23;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(367, 80);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(123, 26);
            this.txtSoLuong.TabIndex = 22;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(103, 40);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(123, 26);
            this.txtMaSP.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tên sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mã nhà cung cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Số lượng ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Đơn vị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã sản phẩm ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox2.Controls.Add(this.DataGridView_SP);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(-1, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 188);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // DataGridView_SP
            // 
            this.DataGridView_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_SP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.MaNCC,
            this.SoLuong,
            this.DonGia,
            this.DonVi});
            this.DataGridView_SP.Location = new System.Drawing.Point(0, 9);
            this.DataGridView_SP.Name = "DataGridView_SP";
            this.DataGridView_SP.Size = new System.Drawing.Size(747, 165);
            this.DataGridView_SP.TabIndex = 0;
            this.DataGridView_SP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_SP_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.FillWeight = 125F;
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
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.FillWeight = 125F;
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 140;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.Name = "DonVi";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox3.Controls.Add(this.btn_luu);
            this.groupBox3.Controls.Add(this.btn_huy);
            this.groupBox3.Controls.Add(this.btn_thoat);
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(-1, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 81);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_luu.Location = new System.Drawing.Point(167, 32);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(74, 32);
            this.btn_luu.TabIndex = 11;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_huy.Location = new System.Drawing.Point(494, 32);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(74, 32);
            this.btn_huy.TabIndex = 10;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_thoat.Location = new System.Drawing.Point(611, 32);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(74, 32);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sua.Location = new System.Drawing.Point(278, 32);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(74, 32);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xoa.Location = new System.Drawing.Point(383, 32);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(74, 32);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_them.Location = new System.Drawing.Point(61, 32);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(74, 32);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.ClientSize = new System.Drawing.Size(746, 456);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSanPham";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGridView_SP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
    }
}