namespace Mixue_Okela
{
    partial class FrmTimKiemPNK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemPNK));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataGridView_TK_PNK = new System.Windows.Forms.DataGridView();
            this.MaNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TK_PNK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(862, 498);
            this.splitContainer1.SplitterDistance = 545;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DataGridView_TK_PNK);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 220);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // DataGridView_TK_PNK
            // 
            this.DataGridView_TK_PNK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_TK_PNK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNK,
            this.MaNV,
            this.MaSP,
            this.MaNCC,
            this.NgayNhap,
            this.TongTien});
            this.DataGridView_TK_PNK.Location = new System.Drawing.Point(-7, 0);
            this.DataGridView_TK_PNK.Name = "DataGridView_TK_PNK";
            this.DataGridView_TK_PNK.RowHeadersWidth = 25;
            this.DataGridView_TK_PNK.Size = new System.Drawing.Size(536, 220);
            this.DataGridView_TK_PNK.TabIndex = 6;
            this.DataGridView_TK_PNK.DoubleClick += new System.EventHandler(this.DataGridView_TK_PNK_DoubleClick_1);
            // 
            // MaNK
            // 
            this.MaNK.DataPropertyName = "MaNK";
            this.MaNK.HeaderText = "Mã phiếu nhập kho";
            this.MaNK.Name = "MaNK";
            this.MaNK.Width = 150;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 120;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 120;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 140;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox1.Controls.Add(this.btnLamLai);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_tim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboMaNCC);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.cboMaSP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí";
            // 
            // btnLamLai
            // 
            this.btnLamLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLamLai.Location = new System.Drawing.Point(191, 165);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(86, 31);
            this.btnLamLai.TabIndex = 10;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = false;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_thoat.Location = new System.Drawing.Point(377, 165);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(86, 31);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_tim.Location = new System.Drawing.Point(10, 165);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(86, 31);
            this.btn_tim.TabIndex = 7;
            this.btn_tim.Text = "Tìm kiếm";
            this.btn_tim.UseVisualStyleBackColor = false;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã NCC";
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(363, 42);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(121, 27);
            this.cboMaNCC.TabIndex = 5;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(115, 42);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(121, 27);
            this.cboMaNV.TabIndex = 4;
            // 
            // cboMaSP
            // 
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(115, 99);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(121, 27);
            this.cboMaSP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sản phẩm ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(149, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm Phiếu nhập kho";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox2.Controls.Add(this.dtpNgayNhap);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNK);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(-4, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 446);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung ";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CalendarFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(134, 111);
            this.dtpNgayNhap.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(174, 26);
            this.dtpNgayNhap.TabIndex = 25;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(134, 185);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(174, 26);
            this.txtTongTien.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tổng tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày nhập";
            // 
            // txtNK
            // 
            this.txtNK.Location = new System.Drawing.Point(134, 40);
            this.txtNK.Name = "txtNK";
            this.txtNK.Size = new System.Drawing.Size(174, 26);
            this.txtNK.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã phiếu nhập kho";
            // 
            // FrmTimKiemPNK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 498);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTimKiemPNK";
            this.Text = "Tìm kiếm phiếu nhập kho";
            this.Load += new System.EventHandler(this.FrmTimKiemPNK_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TK_PNK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DataGridView_TK_PNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}