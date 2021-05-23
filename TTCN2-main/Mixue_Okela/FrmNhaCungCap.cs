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
    public partial class FrmNhaCungCap : Form
    {
        DataTable tblNhaCungCap;
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }

        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            loadDatatoGridview();
        }

        private void DataGridView_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = DataGridView_NCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = DataGridView_NCC.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtDiaChi.Text = DataGridView_NCC.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskSDT.Text = DataGridView_NCC.CurrentRow.Cells["SDT"].Value.ToString();
            txtEmail.Text = DataGridView_NCC.CurrentRow.Cells["Email"].Value.ToString();
            txtMaNCC.Enabled = false;
        }
        private void loadDatatoGridview()
        {
            string sql;
            sql = "Select * from tblNhaCungCap";
            Functions.Connection();
            tblNhaCungCap = Functions.GetDataToTable(sql);
            DataGridView_NCC.DataSource = tblNhaCungCap;
        }
        private void ResetValue()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            mskSDT.Text = "";
            txtEmail.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_huy.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            ResetValue();
            txtMaNCC.Enabled = true;
            txtMaNCC.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhaCungCap.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mskSDT.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskSDT.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("bạn nhập email nhà cung cấp", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            sql = "UPDATE tblNhaCungCap SET  TenNCC='" + txtTenNCC.Text.Trim().ToString() +
                    "',Địa chỉ='" + txtDiaChi.Text.Trim().ToString() +
                    "',SDT='" + mskSDT.Text.ToString() + "',Email='" + txtEmail.Text.Trim().ToString() +
                    "' WHERE MaNCC='" + txtMaNCC.Text + "'";
            Functions.RunSQL(sql);
            loadDatatoGridview();
            ResetValue();
            btn_huy.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhaCungCap.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp?", "thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from tblNhaCungCap where MaNCC ='" + txtMaNCC.Text + "'";
                Functions.RunSQL(sql);
                loadDatatoGridview();
                ResetValue();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhaCungCap.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Nhập mã nhà cung cấp");
                txtMaNCC.Focus();

            }
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Nhập tên mã nhà cung cấp");
                txtTenNCC.Focus();
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Nhập địa chỉ nhà cung cấp");
                txtDiaChi.Focus();

            }
            if (mskSDT.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskSDT.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Nhập email nhà cung cấp");
                txtEmail.Focus();

            }
            sql = "select MaNCC from tblNhaCungCap where MaNCC ='" + txtMaNCC.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã này đã tồn tại, mời nhập mã khác");
                txtMaNCC.Focus();
                return;
            }
            sql = "INSERT INTO tblNhaCungCap(MaNCC,TenNCC,DiaChi,SDT,Email) " +
                "VALUES ('" + txtMaNCC.Text.Trim() + "','" + txtTenNCC.Text.Trim()
                + "','" + txtDiaChi.Text.ToString() + "','" + mskSDT.Text + "','" + txtEmail.Text.Trim() + "')";
            Functions.RunSQL(sql);
            loadDatatoGridview();
            ResetValue();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
            txtMaNCC.Enabled = false;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btn_huy.Enabled = false;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            txtMaNCC.Enabled = false;
        }

       
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void DataGridView_NCC_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = DataGridView_NCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = DataGridView_NCC.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtDiaChi.Text = DataGridView_NCC.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskSDT.Text = DataGridView_NCC.CurrentRow.Cells["SDT"].Value.ToString();
            txtEmail.Text = DataGridView_NCC.CurrentRow.Cells["Email"].Value.ToString();
            txtMaNCC.Enabled = false;
        }
    }
    
}
