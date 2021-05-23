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
    public partial class FrmTimKiemPNK : Form
    {
        DataTable tblPNK;
        public FrmTimKiemPNK()
        {
            InitializeComponent();
        }

        private void FrmTimKiemPNK_Load(object sender, EventArgs e)
        {
            Functions.FillCombo1("select MaNV from tblNhanVien", cboMaNV, "MaNV");
            cboMaNV.SelectedIndex = -1;
            Functions.FillCombo1("select MaNCC from tblNhaCungCap", cboMaNCC, "MaNCC");
            cboMaNCC.SelectedIndex = -1;
            Functions.FillCombo1("select MaSP from tblSanPham", cboMaSP, "MaSP");
            cboMaSP.SelectedIndex = -1;
            DataGridView_TK_PNK.DataSource = null;
        }
        private void loadDataGridView()
        {
            //string sql;
            //sql = "select a.MaXK,a.MaNV,b.MaSP,a.MaCH,a.NgayXuat,a.TongTien" + "from tblPhieuXuatKho as a,tblChiTietXuatKho as b" +
            //  "where a.MaXK=b.MaXK";
            //tblPXK = Functions.GetDataToTable(sql);
            //DataGridView_TK_PXK.DataSource = tblPXK;
            DataGridView_TK_PNK.AllowUserToAddRows = false;
            DataGridView_TK_PNK.EditMode = DataGridViewEditMode.EditProgrammatically;
        
         }

        private void DataGridView_TK_PNK_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtNK.Text = DataGridView_TK_PNK.CurrentRow.Cells["MaNK"].Value.ToString();
                cboMaNV.Text = DataGridView_TK_PNK.CurrentRow.Cells["MaNV"].Value.ToString();
                cboMaNCC.Text = DataGridView_TK_PNK.CurrentRow.Cells["MaNCC"].Value.ToString();
                txtTongTien.Text = DataGridView_TK_PNK.CurrentRow.Cells["TongTien"].Value.ToString();
                dtpNgayNhap.Text = DataGridView_TK_PNK.CurrentRow.Cells["NgayNhap"].Value.ToString();
                cboMaSP.Text = DataGridView_TK_PNK.CurrentRow.Cells["MaSP"].Value.ToString();
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboMaNV.Text == "") && (cboMaNCC.Text == "") && (cboMaSP.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select a.MaNK,a.MaNV,a.NgayNhap,a.MaNCC,a.TongTien,b.MaSP from tblPhieuNhapKho as a join tblChiTietNhapKho as b" +
                " on a.MaNK=b.MaNK where 1=1";
            if (cboMaNV.Text != "")
            {
                sql = sql + " AND MaNV='" + cboMaNV.Text + "'";
            }
            if (cboMaNCC.Text != "")
            {
                sql = sql + " and MaNCC='" + cboMaNCC.Text + "'";
            }
            if (cboMaSP.Text != "")
            {
                sql = sql + "and b.MaSP='" + cboMaSP.Text + "'";

            }
            tblPNK = Functions.GetDataToTable(sql);
            if (tblPNK.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblPNK.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridView_TK_PNK.DataSource = tblPNK;
            loadDataGridView();
        }
        private void ResetValues()
        {
            cboMaNCC.Text = "";
            cboMaNV.Text = "";
            txtNK.Text = "";
            txtTongTien.Text = "";
            dtpNgayNhap.Text = "";
            cboMaSP.Text = "";
            cboMaNV.Focus();
         }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView_TK_PNK.DataSource = null;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void DataGridView_TK_PNK_DoubleClick_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtNK.Text = DataGridView_TK_PNK.CurrentRow.Cells["MaNK"].Value.ToString();
                cboMaNV.Text = DataGridView_TK_PNK.CurrentRow.Cells["MaNV"].Value.ToString();
                cboMaNCC.Text = DataGridView_TK_PNK.CurrentRow.Cells["MaNCC"].Value.ToString();
                txtTongTien.Text = DataGridView_TK_PNK.CurrentRow.Cells["TongTien"].Value.ToString();
                dtpNgayNhap.Text = DataGridView_TK_PNK.CurrentRow.Cells["NgayNhap"].Value.ToString();
                cboMaSP.Text = DataGridView_TK_PNK.CurrentRow.Cells["MaSP"].Value.ToString();
            }
        }
    }
}
