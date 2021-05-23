namespace Mixue_Okela
{
    partial class FrmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhaCungCap));
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskSDT = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataGridView_NCC = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_NCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(323, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nhà cung cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_luu);
            this.groupBox2.Controls.Add(this.btn_huy);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 81);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_thoat.Location = new System.Drawing.Point(672, 27);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(83, 46);
            this.btn_thoat.TabIndex = 40;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_luu.Location = new System.Drawing.Point(429, 27);
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
            this.btn_huy.Location = new System.Drawing.Point(552, 27);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(83, 46);
            this.btn_huy.TabIndex = 38;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sua.Location = new System.Drawing.Point(169, 27);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(83, 46);
            this.btn_sua.TabIndex = 37;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xoa.Location = new System.Drawing.Point(291, 27);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(83, 46);
            this.btn_xoa.TabIndex = 36;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_them.Location = new System.Drawing.Point(55, 27);
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
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mskSDT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenNCC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 166);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thực hiện nhập";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(583, 127);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 26);
            this.txtEmail.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email";
            // 
            // mskSDT
            // 
            this.mskSDT.Location = new System.Drawing.Point(582, 80);
            this.mskSDT.Mask = "(999) 000-0000";
            this.mskSDT.Name = "mskSDT";
            this.mskSDT.Size = new System.Drawing.Size(157, 26);
            this.mskSDT.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Điện thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(579, 34);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(160, 26);
            this.txtDiaChi.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Địa chỉ";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(165, 80);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(147, 26);
            this.txtTenNCC.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên NCC";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(165, 34);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(147, 26);
            this.txtMaNCC.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã NCC";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.groupBox3.Controls.Add(this.DataGridView_NCC);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(2, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 201);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // DataGridView_NCC
            // 
            this.DataGridView_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_NCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DiaChi,
            this.SDT,
            this.Email});
            this.DataGridView_NCC.Location = new System.Drawing.Point(59, 11);
            this.DataGridView_NCC.Name = "DataGridView_NCC";
            this.DataGridView_NCC.RowHeadersWidth = 51;
            this.DataGridView_NCC.RowTemplate.Height = 24;
            this.DataGridView_NCC.Size = new System.Drawing.Size(665, 179);
            this.DataGridView_NCC.TabIndex = 17;
            this.DataGridView_NCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_NCC_CellClick_1);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 150;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên nhà cung cấp";
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.Width = 130;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // FrmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mixue_Okela.Properties.Resources.z2507552868280_9e71c154d4a8c151e3805d2d8d5559c1;
            this.ClientSize = new System.Drawing.Size(786, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNhaCungCap";
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.FrmNhaCungCap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_NCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DataGridView_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}