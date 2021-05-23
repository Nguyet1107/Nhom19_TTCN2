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
    public partial class FrmTimKiemPXK : Form
    {
        DataTable tblPXK;
        public FrmTimKiemPXK()
        {
            InitializeComponent();
        }

        private void FrmTimKiemPXK_Load(object sender, EventArgs e)
        {
            Functions.FillCombo1("select MaNV from tblNhanVien", cboMaNV, "MaNV");
            cboMaNV.SelectedIndex = -1;
            Functions.FillCombo1("select MaCH from tblCuaHang", cboMaCH, "MaCH");
            cboMaCH.SelectedIndex = -1;
            Functions.FillCombo1("select MaSP from tblSanPham", cboMaSP, "MaSP");
            cboMaSP.SelectedIndex = -1;
            DataGridView_TK_PXK.DataSource = null;
        }
        private void loadDataGridView()
        {
            //string sql;
            //sql = "select a.MaXK,a.MaNV,b.MaSP,a.MaCH,a.NgayXuat,a.TongTien" + "from tblPhieuXuatKho as a,tblChiTietXuatKho as b" +
              //  "where a.MaXK=b.MaXK";
            //tblPXK = Functions.GetDataToTable(sql);
            //DataGridView_TK_PXK.DataSource = tblPXK;
            DataGridView_TK_PXK.AllowUserToAddRows = false;
            DataGridView_TK_PXK.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_TK_PXK_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                txtXK.Text = DataGridView_TK_PXK.CurrentRow.Cells["MaXK"].Value.ToString();
                cboMaNV.Text = DataGridView_TK_PXK.CurrentRow.Cells["MaNV"].Value.ToString();
                cboMaCH.Text = DataGridView_TK_PXK.CurrentRow.Cells["MaCH"].Value.ToString();
                txtTongTien.Text = DataGridView_TK_PXK.CurrentRow.Cells["TongTien"].Value.ToString();
                dtpNgayXuat.Text = DataGridView_TK_PXK.CurrentRow.Cells["NgayXuat"].Value.ToString();
                cboMaSP.Text = DataGridView_TK_PXK.CurrentRow.Cells["MaSP"].Value.ToString();

            }

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboMaNV.Text == "") && (cboMaCH.Text == "") && (cboMaSP.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select a.MaXK,a.MaNV,a.NgayXuat,a.MaCH,a.TongTien,b.MaSP from tblPhieuXuatKho as a join tblChiTietXuatKho as b" +
                " on a.MaXK=b.MaXK where 1=1";
            if (cboMaNV.Text != "")
            {
                sql = sql + " AND MaNV='" + cboMaNV.Text + "'";
            }
            if (cboMaCH.Text != "")
            {
                sql = sql + " and MaCH='" + cboMaCH.Text + "'";
            }
            if (cboMaSP.Text != "")
            {
                sql = sql + "and b.MaSP='"+cboMaSP.Text + "'";
               
            }
            tblPXK = Functions.GetDataToTable(sql);
            if(tblPXK.Rows.Count==0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblPXK.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridView_TK_PXK.DataSource = tblPXK;
            loadDataGridView();
        }
        private void ResetValues()
        {
            cboMaCH.Text = "";
            cboMaNV.Text = "";
            txtXK.Text = "";
            txtTongTien.Text = "";
            dtpNgayXuat.Text = "";
            cboMaSP.Text = "";
            cboMaNV.Focus();
        }
        
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView_TK_PXK.DataSource = null;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void DataGridView_TK_PXK_DoubleClick_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtXK.Text = DataGridView_TK_PXK.CurrentRow.Cells["MaXK"].Value.ToString();
                cboMaNV.Text = DataGridView_TK_PXK.CurrentRow.Cells["MaNV"].Value.ToString();
                cboMaCH.Text = DataGridView_TK_PXK.CurrentRow.Cells["MaCH"].Value.ToString();
                txtTongTien.Text = DataGridView_TK_PXK.CurrentRow.Cells["TongTien"].Value.ToString();
                dtpNgayXuat.Text = DataGridView_TK_PXK.CurrentRow.Cells["NgayXuat"].Value.ToString();
                cboMaSP.Text = DataGridView_TK_PXK.CurrentRow.Cells["MaSP"].Value.ToString();

            }
        }
    }
}
