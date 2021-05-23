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
    public partial class FrmTimKiemSP : Form
    {
        DataTable tblSanPham;
        public FrmTimKiemSP()
        {
            InitializeComponent();
        }

        private void FrmTimKiemSP_Load(object sender, EventArgs e)
        {
            Functions.FillCombo1("select MaNCC from tblNhaCungCap", cboMaNCC, "MaNCC");
            cboMaNCC.SelectedIndex = -1;
            Functions.FillCombo1("select TenSP from tblSanPham", cboTenSP,"TenSP");
            cboTenSP.SelectedIndex = -1;
            Functions.FillCombo1("select MaSP from tblSanPham", cboMaSP, "MaSP");
            cboMaSP.SelectedIndex = -1;
            dgvTimKiemSP.DataSource = null;
        }
        private void ResetValues()
        {
            cboMaSP.Text = "";
            cboTenSP.Text = "";
            txtDonGia.Text = "";
            txtDonVi.Text = "";
            cboMaNCC.Text = "";
            txtSoLuong.Text = "";
            cboMaSP.Focus();
        }

        private void dgvTimKiemSP_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cboMaSP.Text = dgvTimKiemSP.CurrentRow.Cells["MaSP"].Value.ToString();
                cboMaNCC.Text = dgvTimKiemSP.CurrentRow.Cells["MaNCC"].Value.ToString();
                cboTenSP.Text = dgvTimKiemSP.CurrentRow.Cells["TenSP"].Value.ToString();
                txtSoLuong.Text = dgvTimKiemSP.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = dgvTimKiemSP.CurrentRow.Cells["DonGia"].Value.ToString();
                txtDonVi.Text = dgvTimKiemSP.CurrentRow.Cells["DonVi"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboMaSP.Text == "") && (cboMaNCC.Text == "") && (cboTenSP.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select *from tblSanPham where 1=1";
            if (cboMaSP.Text != "")
            {
                sql = sql + " AND MaSP ='" + cboMaSP.Text+"'" ;
            }
            if (cboMaNCC.Text != "")
            {
                sql = sql + " AND MaNCC='" + cboMaNCC.Text +"'";
            }
            if (cboTenSP.Text != "")
            {
                sql = sql + " AND TenSP='" + cboTenSP.Text+"'";
            }
            Functions.Connection();
            tblSanPham = Functions.GetDataToTable(sql);
            if (tblSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblSanPham.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvTimKiemSP.DataSource = tblSanPham;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            //string sql;
            //sql = "select *from";
            //tblSanPham = Functions.GetDataToTable(sql);
            //dgvTimKiemSP.DataSource = tblSanPham;
            dgvTimKiemSP.AllowUserToAddRows = false;
            dgvTimKiemSP.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvTimKiemSP.DataSource = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void dgvTimKiemSP_DoubleClick_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cboMaSP.Text = dgvTimKiemSP.CurrentRow.Cells["MaSP"].Value.ToString();
                cboMaNCC.Text = dgvTimKiemSP.CurrentRow.Cells["MaNCC"].Value.ToString();
                cboTenSP.Text = dgvTimKiemSP.CurrentRow.Cells["TenSP"].Value.ToString();
                txtSoLuong.Text = dgvTimKiemSP.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = dgvTimKiemSP.CurrentRow.Cells["DonGia"].Value.ToString();
                txtDonVi.Text = dgvTimKiemSP.CurrentRow.Cells["DonVi"].Value.ToString();
            }
        }
    }
}
