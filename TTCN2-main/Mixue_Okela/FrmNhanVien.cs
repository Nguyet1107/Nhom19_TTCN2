using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mixue_Okela
{
    public partial class FrmNhanVien : Form
    {
        DataTable tblNhanVien;
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            loadDatatoGridview();
            Functions.FillCombo("select MaCV, TenCV from tblChucVu", cboMaCV, "MaCV", "TenCV");
            cboMaCV.SelectedIndex = -1;
        }
        private void loadDatatoGridview()
        {
            string sql;
            sql = "Select * from tblNhanVien";
            Functions.Connection();
            tblNhanVien = Functions.GetDataToTable(sql);
            DataGridView_NhanVien.DataSource = tblNhanVien;
        }
        private void ResetValue()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtQuequan.Text = "";
            mskSDT.Text = "";
            cboMaCV.Text = "";
            dtpNgaySinh.Text = "";
            chkGioiTinh.Checked = false;
        
    }

        private void DataGridView_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaCV;
            txtMaNV.Text = DataGridView_NhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            MaCV = DataGridView_NhanVien.CurrentRow.Cells["MaCV"].Value.ToString();
            txtTenNV.Text = DataGridView_NhanVien.CurrentRow.Cells["HoTen"].Value.ToString();
            dtpNgaySinh.Text = DataGridView_NhanVien.CurrentRow.Cells["NamSinh"].Value.ToString();
            mskSDT.Text = DataGridView_NhanVien.CurrentRow.Cells["SDT"].Value.ToString();
            if (DataGridView_NhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam") chkGioiTinh.Checked = true;
            else chkGioiTinh.Checked = false;
            txtQuequan.Text = DataGridView_NhanVien.CurrentRow.Cells["QueQuan"].Value.ToString();
            cboMaCV.Text = Functions.GetFieldValues("select TenCV from tblChucVu where MaCV='" + MaCV + "'");
            txtMaNV.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_huy.Enabled = true;
            btn_them.Enabled = false;
            btn_luu.Enabled = true;
            ResetValue();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtQuequan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập quê quán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuequan.Focus();
                return;
            }
            if (mskSDT.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskSDT.Focus();
                return;
            }
            if (cboMaCV.Text == "")
            {
                MessageBox.Show("bạn nhập mã chức vụ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaCV.Focus();
                return;
            }
            if (dtpNgaySinh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }

            if (chkGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE tblNhanVien SET  HoTen='" + txtTenNV.Text.Trim().ToString() +
                    "',QueQuan='" + txtQuequan.Text.Trim().ToString() +
                    "',SDT='" + mskSDT.Text.ToString() + "',GioiTinh='" + gt +
                    "',NamSinh='" + Functions.ConvertDateTime(dtpNgaySinh.Text.Trim().ToString()) +
                    "' WHERE MaNV='" + txtMaNV.Text + "'";
            Functions.RunSQL(sql);
            loadDatatoGridview();
            ResetValue();
            btn_huy.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên", "thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from tblNhanVien where MaNV ='" + txtMaNV.Text + "'";
                Functions.RunSQL(sql);
                loadDatatoGridview();
                ResetValue();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Nhập mã nhân viên");
                txtMaNV.Focus();

            }
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Nhập tên nhân viên");
                txtTenNV.Focus();
            }
            if (txtQuequan.Text == "")
            {
                MessageBox.Show("Nhập quê quán");
                txtQuequan.Focus();

            }
            if (cboMaCV.Text == "")
            {
                MessageBox.Show("Nhập mã chức vụ");
                cboMaCV.Focus();

            }
            if (mskSDT.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskSDT.Focus();
                return;
            }
            if (chkGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (dtpNgaySinh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }
            sql = "select MaNV from tblNhanVien where MaNV ='" + txtMaNV.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã này đã tồn tại, mời nhập mã khác");
                txtMaNV.Focus();
                return;
            }
            sql = "INSERT INTO tblNhanVien(MaNV,MaCV,HoTen,NamSinh,SDT, GioiTinh, QueQuan) " +
                "VALUES ('" + txtMaNV.Text.Trim() + "','" + cboMaCV.SelectedValue.ToString() + "', '"
                + txtTenNV.Text.Trim()
                + "','" + Functions.ConvertDateTime(dtpNgaySinh.Text) + "','" + mskSDT.Text + "','"
                + gt + "','" + txtQuequan.Text.Trim() + "')";
            Functions.RunSQL(sql);
            loadDatatoGridview();
            ResetValue();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btn_huy.Enabled = false;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            txtMaNV.Enabled = false;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void DataGridView_NhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string MaCV;
            txtMaNV.Text = DataGridView_NhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            MaCV = DataGridView_NhanVien.CurrentRow.Cells["MaCV"].Value.ToString();
            txtTenNV.Text = DataGridView_NhanVien.CurrentRow.Cells["HoTen"].Value.ToString();
            dtpNgaySinh.Text = DataGridView_NhanVien.CurrentRow.Cells["NamSinh"].Value.ToString();
            mskSDT.Text = DataGridView_NhanVien.CurrentRow.Cells["SDT"].Value.ToString();
            if (DataGridView_NhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam") chkGioiTinh.Checked = true;
            else chkGioiTinh.Checked = false;
            txtQuequan.Text = DataGridView_NhanVien.CurrentRow.Cells["QueQuan"].Value.ToString();
            cboMaCV.Text = Functions.GetFieldValues("select TenCV from tblChucVu where MaCV='" + MaCV + "'");
            txtMaNV.Enabled = false;
        }
    }
}
