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
    public partial class FrmChucVu : Form
    {
        DataTable tblChucVu;
        public FrmChucVu()
        {
            InitializeComponent();
        }

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            txtMaCV.Enabled = false;
            loadDatatoGridview();
        }
        private void loadDatatoGridview()
        {
            string sql;
            sql = "Select * from tblChucVu";
            Functions.Connection();
            tblChucVu = Functions.GetDataToTable(sql);
            DataGridView_ChucVu.DataSource = tblChucVu;
        }
        private void ResetValue()
        {
            txtMaCV.Text = "";
            txtTenCV.Text = "";
        }

        private void DataGridView_ChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCV.Text = DataGridView_ChucVu.CurrentRow.Cells["MaCV"].Value.ToString();
            txtTenCV.Text = DataGridView_ChucVu.CurrentRow.Cells["TenCV"].Value.ToString();
            txtMaCV.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_huy.Enabled = true;
            btn_them.Enabled = false;
            ResetValue();
            txtMaCV.Enabled = true;
            txtMaCV.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblChucVu.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaCV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenCV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenCV.Focus();
                return;
            }
            sql = "UPDATE tblChucVu SET  TenCV='" + txtTenCV.Text.Trim().ToString() +
                    "' WHERE MaNV='" + txtMaCV.Text + "'";
            Functions.RunSQL(sql);
            loadDatatoGridview();
            ResetValue();
            btn_huy.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblChucVu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ?", "thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from tblChucVu where MaCV ='" + txtMaCV.Text + "'";
                Functions.RunSQL(sql);
                loadDatatoGridview();
                ResetValue();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblChucVu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }
            if (txtMaCV.Text == "")
            {
                MessageBox.Show("Nhập mã chức vụ");
                txtMaCV.Focus();

            }
            if (txtTenCV.Text == "")
            {
                MessageBox.Show("Nhập tên chức vụ");
                txtTenCV.Focus();
            }

            sql = "select MaCV from tblChucVu where MaCV ='" + txtMaCV.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã này đã tồn tại, mời nhập mã khác");
                txtMaCV.Focus();
                return;
            }
            sql = "INSERT INTO tblChucVu(MaCV,TenCV) " +
                "VALUES ('" + txtMaCV.Text.Trim() + "','"
                + txtTenCV.Text.Trim().ToString() + "')";
            Functions.RunSQL(sql);
            loadDatatoGridview();
            ResetValue();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
            txtMaCV.Enabled = false;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btn_huy.Enabled = false;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            txtMaCV.Enabled = false;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void DataGridView_ChucVu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txtMaCV.Text = DataGridView_ChucVu.CurrentRow.Cells["MaCV"].Value.ToString();
            txtTenCV.Text = DataGridView_ChucVu.CurrentRow.Cells["TenCV"].Value.ToString();
            txtMaCV.Enabled = false;
        }
    }
}
