namespace Mixue_Okela
{
    partial class FrmTimKiemPXK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemPXK));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataGridView_TK_PXK = new System.Windows.Forms.DataGridView();
            this.MaXK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaCH = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TK_PXK)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(858, 500);
            this.splitContainer1.SplitterDistance = 527;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox3.Controls.Add(this.DataGridView_TK_PXK);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 234);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // DataGridView_TK_PXK
            // 
            this.DataGridView_TK_PXK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_TK_PXK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXK,
            this.MaNV,
            this.MaSP,
            this.MaCH,
            this.NgayXuat,
            this.TongTien});
            this.DataGridView_TK_PXK.Location = new System.Drawing.Point(-12, 7);
            this.DataGridView_TK_PXK.Name = "DataGridView_TK_PXK";
            this.DataGridView_TK_PXK.RowHeadersWidth = 25;
            this.DataGridView_TK_PXK.Size = new System.Drawing.Size(536, 220);
            this.DataGridView_TK_PXK.TabIndex = 3;
            this.DataGridView_TK_PXK.DoubleClick += new System.EventHandler(this.DataGridView_TK_PXK_DoubleClick_1);
            // 
            // MaXK
            // 
            this.MaXK.DataPropertyName = "MaXK";
            this.MaXK.HeaderText = "Mã phiếu xuất kho";
            this.MaXK.Name = "MaXK";
            this.MaXK.Width = 150;
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
            // MaCH
            // 
            this.MaCH.DataPropertyName = "MaCH";
            this.MaCH.HeaderText = "Mã cửa hàng";
            this.MaCH.Name = "MaCH";
            this.MaCH.Width = 120;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuat";
            this.NgayXuat.HeaderText = "Ngày Xuất";
            this.NgayXuat.Name = "NgayXuat";
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
            this.groupBox1.Controls.Add(this.cboMaCH);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.cboMaSP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 211);
            this.groupBox1.TabIndex = 1;
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
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã cửa hàng";
            // 
            // cboMaCH
            // 
            this.cboMaCH.FormattingEnabled = true;
            this.cboMaCH.Location = new System.Drawing.Point(363, 42);
            this.cboMaCH.Name = "cboMaCH";
            this.cboMaCH.Size = new System.Drawing.Size(121, 27);
            this.cboMaCH.TabIndex = 5;
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
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm Phiếu xuất kho";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox2.Controls.Add(this.dtpNgayXuat);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtXK);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 455);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung ";
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.CalendarFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayXuat.Location = new System.Drawing.Point(134, 111);
            this.dtpNgayXuat.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(174, 26);
            this.dtpNgayXuat.TabIndex = 25;
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
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày xuất";
            // 
            // txtXK
            // 
            this.txtXK.Location = new System.Drawing.Point(134, 40);
            this.txtXK.Name = "txtXK";
            this.txtXK.Size = new System.Drawing.Size(174, 26);
            this.txtXK.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã phiếu xuất kho";
            // 
            // FrmTimKiemPXK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 500);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTimKiemPXK";
            this.Text = "Tìm kiếm phiếu xuất kho";
            this.Load += new System.EventHandler(this.FrmTimKiemPXK_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TK_PXK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaCH;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtXK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DataGridView_TK_PXK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}