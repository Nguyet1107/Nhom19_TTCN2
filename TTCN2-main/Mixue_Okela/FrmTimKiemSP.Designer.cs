namespace Mixue_Okela
{
    partial class FrmTimKiemSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemSP));
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTenSP = new System.Windows.Forms.ComboBox();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMua = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTimKiemSP = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.OrangeRed;
            this.label16.Location = new System.Drawing.Point(291, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(205, 25);
            this.label16.TabIndex = 26;
            this.label16.Text = "Tìm Kiếm Sản Phẩm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(29, 433);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(415, 19);
            this.label15.TabIndex = 25;
            this.label15.Text = "Kích đúp chuột vào một sản phẩm để hiển thị thông tin chi tiết ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnLamLai);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 465);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 77);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chức năng ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(525, 27);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 38);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLamLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamLai.Location = new System.Drawing.Point(283, 27);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(107, 38);
            this.btnLamLai.TabIndex = 12;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = false;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(43, 27);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 38);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox1.Controls.Add(this.cboTenSP);
            this.groupBox1.Controls.Add(this.cboMaNCC);
            this.groupBox1.Controls.Add(this.cboMaSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaMua);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtDonVi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 187);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm ";
            // 
            // cboTenSP
            // 
            this.cboTenSP.FormattingEnabled = true;
            this.cboTenSP.Location = new System.Drawing.Point(111, 150);
            this.cboTenSP.Name = "cboTenSP";
            this.cboTenSP.Size = new System.Drawing.Size(156, 27);
            this.cboTenSP.TabIndex = 63;
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(111, 91);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(156, 27);
            this.cboMaNCC.TabIndex = 62;
            // 
            // cboMaSP
            // 
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(111, 39);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(156, 27);
            this.cboMaSP.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "Mã SP";
            // 
            // txtMaMua
            // 
            this.txtMaMua.Location = new System.Drawing.Point(444, -32);
            this.txtMaMua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaMua.Name = "txtMaMua";
            this.txtMaMua.Size = new System.Drawing.Size(175, 26);
            this.txtMaMua.TabIndex = 58;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(569, 40);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(151, 26);
            this.txtSoLuong.TabIndex = 57;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(569, 155);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(151, 26);
            this.txtDonVi.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(467, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 46;
            this.label10.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, -24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "Mã Mùa";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(569, 96);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(151, 26);
            this.txtDonGia.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "Đơn vị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tên SP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mã NCC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-13, -29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mã GD";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox3.Controls.Add(this.dgvTimKiemSP);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(-1, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(754, 190);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // dgvTimKiemSP
            // 
            this.dgvTimKiemSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKiemSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.MaNCC,
            this.TenSP,
            this.SoLuong,
            this.DonGia,
            this.DonVi});
            this.dgvTimKiemSP.Location = new System.Drawing.Point(34, 6);
            this.dgvTimKiemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTimKiemSP.Name = "dgvTimKiemSP";
            this.dgvTimKiemSP.RowHeadersWidth = 62;
            this.dgvTimKiemSP.RowTemplate.Height = 28;
            this.dgvTimKiemSP.Size = new System.Drawing.Size(687, 178);
            this.dgvTimKiemSP.TabIndex = 24;
            this.dgvTimKiemSP.DoubleClick += new System.EventHandler(this.dgvTimKiemSP_DoubleClick_1);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
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
            // FrmTimKiemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.ClientSize = new System.Drawing.Size(753, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTimKiemSP";
            this.Text = "Tìm kiếm sản phẩm";
            this.Load += new System.EventHandler(this.FrmTimKiemSP_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMua;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTenSP;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTimKiemSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
    }
}