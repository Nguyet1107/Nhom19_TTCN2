namespace Mixue_Okela
{
    partial class FrmPhieuNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhieuNhapKho));
            this.cboMaNK = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DataGridView_NK = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNK = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_NK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMaNK
            // 
            this.cboMaNK.FormattingEnabled = true;
            this.cboMaNK.Location = new System.Drawing.Point(111, 567);
            this.cboMaNK.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaNK.Name = "cboMaNK";
            this.cboMaNK.Size = new System.Drawing.Size(133, 21);
            this.cboMaNK.TabIndex = 39;
            this.cboMaNK.DropDown += new System.EventHandler(this.cboMaNK_DropDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.txtDonVi);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cboMaSP);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.DataGridView_NK);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 385);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(50, 237);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(277, 19);
            this.label19.TabIndex = 46;
            this.label19.Text = "Kích vào 1 dòng để hiển thị thông tin chi tiết \r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(50, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "Kích đúp 1 dòng hàng để xóa";
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox5.Controls.Add(this.btnThoat);
            this.groupBox5.Controls.Add(this.btnXoa);
            this.groupBox5.Controls.Add(this.btnHuy);
            this.groupBox5.Controls.Add(this.btnIn);
            this.groupBox5.Controls.Add(this.btnLuu);
            this.groupBox5.Controls.Add(this.btnThem);
            this.groupBox5.Location = new System.Drawing.Point(6, 290);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(794, 77);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Location = new System.Drawing.Point(691, 32);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 34);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(562, 32);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 34);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.Location = new System.Drawing.Point(436, 32);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 34);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIn.Location = new System.Drawing.Point(308, 32);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(80, 34);
            this.btnIn.TabIndex = 24;
            this.btnIn.Text = "In phiếu";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(179, 32);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 34);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(47, 32);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 34);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(660, 261);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(117, 26);
            this.txtTongTien.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(564, 268);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 19);
            this.label17.TabIndex = 41;
            this.label17.Text = "Tổng tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(660, 70);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(117, 26);
            this.txtThanhTien.TabIndex = 40;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(395, 71);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(117, 26);
            this.txtDonVi.TabIndex = 39;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(660, 24);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(117, 26);
            this.txtDonGia.TabIndex = 38;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(395, 24);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(117, 26);
            this.txtSoLuong.TabIndex = 37;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(564, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 19);
            this.label16.TabIndex = 36;
            this.label16.Text = "Thành tiền";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(579, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 19);
            this.label15.TabIndex = 35;
            this.label15.Text = "Đơn giá";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(319, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 19);
            this.label14.TabIndex = 34;
            this.label14.Text = "Đơn vị";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(319, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 19);
            this.label13.TabIndex = 33;
            this.label13.Text = "Số lượng";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(166, 71);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(117, 26);
            this.txtTenSP.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 73);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 19);
            this.label12.TabIndex = 31;
            this.label12.Text = "Tên sản phẩm";
            // 
            // cboMaSP
            // 
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(166, 24);
            this.cboMaSP.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(117, 27);
            this.cboMaSP.TabIndex = 30;
            this.cboMaSP.SelectedIndexChanged += new System.EventHandler(this.cboMaSP_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "Mã sản phẩm";
            // 
            // DataGridView_NK
            // 
            this.DataGridView_NK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_NK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.DonVi,
            this.DonGia,
            this.ThanhTien});
            this.DataGridView_NK.Location = new System.Drawing.Point(53, 113);
            this.DataGridView_NK.Name = "DataGridView_NK";
            this.DataGridView_NK.Size = new System.Drawing.Size(724, 121);
            this.DataGridView_NK.TabIndex = 0;
            this.DataGridView_NK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_NK_CellClick);
            this.DataGridView_NK.DoubleClick += new System.EventHandler(this.DataGridView_NK_DoubleClick);
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
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.Name = "DonVi";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboMaNCC);
            this.groupBox1.Controls.Add(this.txtTenNCC);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaNK);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 181);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(299, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 33;
            this.label2.Text = "Phiếu nhập kho";
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(583, 32);
            this.cboMaNCC.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(131, 27);
            this.cboMaNCC.TabIndex = 32;
            this.cboMaNCC.SelectedIndexChanged += new System.EventHandler(this.cboMaNCC_SelectedIndexChanged);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(583, 83);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(206, 26);
            this.txtTenNCC.TabIndex = 29;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(166, 83);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(117, 27);
            this.cboMaNV.TabIndex = 28;
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(583, 128);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(131, 26);
            this.dtpNgayNhap.TabIndex = 27;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(166, 128);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(117, 26);
            this.txtTenNV.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tên nhân viên ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mã nhân viên ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mã nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày nhập";
            // 
            // txtMaNK
            // 
            this.txtMaNK.Location = new System.Drawing.Point(166, 33);
            this.txtMaNK.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNK.Name = "txtMaNK";
            this.txtMaNK.Size = new System.Drawing.Size(117, 26);
            this.txtMaNK.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mã nhập kho";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 566);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 41;
            this.label8.Text = "Mã PNK";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(267, 557);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(80, 34);
            this.btnTimKiem.TabIndex = 42;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FrmPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboMaNK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPhieuNhapKho";
            this.Text = "Phiếu nhập kho";
            this.Load += new System.EventHandler(this.FrmPhieuNhapKho_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_NK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMaNK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DataGridView_NK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
    }
}