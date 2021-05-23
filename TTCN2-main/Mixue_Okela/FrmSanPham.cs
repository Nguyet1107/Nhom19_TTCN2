using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mixue_Okela
{
    public partial class FrmSanPham : Form
    {
        DataTable tableSanPham;
        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            txtMaSP.Enabled = false;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            Functions.FillCombo("select MaNCC,TenNCC from tblNhaCungCap", cboMaNCC, "MaNCC", "TenNCC");
            cboMaNCC.SelectedIndex = -1;

            loatDaTaToGridview();
            ResetValues();
        }
        private void loatDaTaToGridview()
        {
            string sql = "select *from tblSanPham";
            tableSanPham = Functions.GetDataToTable(sql);

            DataGridView_SP.DataSource = tableSanPham;

        }
        private void ResetValues()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cboMaNCC.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtDonVi.Text = "";
            txtSoLuong.Enabled = true;
            //txtDonGiaNhap.Enabled = false;
            // txtDonGiaBan.Enabled = false;

        
    }

        private void DataGridView_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaNCC;
            txtMaSP.Text = DataGridView_SP.CurrentRow.Cells["MaSP"].Value.ToString();
            txtTenSP.Text = DataGridView_SP.CurrentRow.Cells["TenSP"].Value.ToString();
            MaNCC = DataGridView_SP.CurrentRow.Cells["MaNCC"].Value.ToString();
            cboMaNCC.Text = Functions.GetFieldValues("select TenNCC from tblNhaCungCap where MaNCC='" + MaNCC + "'");
            txtSoLuong.Text = DataGridView_SP.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDonGia.Text = DataGridView_SP.CurrentRow.Cells["DonGia"].Value.ToString();
            txtDonVi.Text = DataGridView_SP.CurrentRow.Cells["DonVi"].Value.ToString();
            txtMaSP.Enabled = false;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Bạn đang nhập sai dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("bạn đang nhập sai dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_huy.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            ResetValues();
            txtMaSP.Enabled = true;
            txtMaSP.Focus();
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            txtDonVi.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSP.Focus();
                return;
            }
            if (cboMaNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNCC.Focus();
                return;
            }
            if (txtDonGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNCC.Focus();
                return;
            }
            if (txtDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNCC.Focus();
                return;
            }
            sql = "select MaSP From tblSanPham Where MaSP='" + txtMaSP.Text.Trim() + "'";

            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn vui lòng nhập mã khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return;
            }

            sql = "INSERT INTO tblSanPham(MaSP,TenSP,MaNCC,SoLuong,DonGia, DonVi) VALUES('" + txtMaSP.Text.Trim() + "',N'" + txtTenSP.Text.Trim() + "','" + cboMaNCC.SelectedValue.ToString() +
                "','" + txtSoLuong.Text.Trim() + "','" + txtDonGia.Text + "',N'" + txtDonVi.Text + "')";

            Functions.RunSQL(sql);
            loatDaTaToGridview();
            ResetValues();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
            txtMaSP.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tableSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSP.Focus();
                return;
            }
            if (cboMaNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNCC.Focus();
                return;
            }
            if (txtDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã đơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNCC.Focus();
                return;
            }
            sql = "UPDATE tblSanPham SET TenSP=N'" + txtTenSP.Text +
                "',MaSP='" + cboMaNCC.SelectedValue.ToString() +
                "',SoLuong='" + txtSoLuong.Text + "',DonGia='" + txtDonGia.Text + "',DonVi=N'" + txtDonVi.Text + "' WHERE MaSP='" + txtMaSP.Text + "'";
            Functions.RunSQL(sql);
            loatDaTaToGridview();
            ResetValues();
            btn_huy.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tableSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblSanPham WHERE MaSP='" + txtMaSP.Text + "'";
                Functions.RunSqlDel(sql);
                loatDaTaToGridview();
                ResetValues();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            txtMaSP.Enabled = false;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
