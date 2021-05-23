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
using COMExcel = Microsoft.Office.Interop.Excel;


namespace Mixue_Okela
{
    public partial class FrmPhieuDatHang : Form
    {
        DataTable tblChiTietPDH;
        public FrmPhieuDatHang()
        {
            InitializeComponent();
        }

        private void FrmPhieuDatHang_Load(object sender, EventArgs e)
        {
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            btn_xoa.Enabled = false;
            txtMaPDH.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtTenSP.ReadOnly = true;
            Functions.Connection();
            Functions.FillCombo("Select MaNV from tblNhanVien", cboMaNV, "MaNV", "HoTen");
            cboMaNV.SelectedIndex = -1;
            Functions.FillCombo("Select MaSP from tblSanPham", cboMaSP, "MaSP", "TenSP");
            cboMaSP.SelectedIndex = -1;
            if (txtMaPDH.Text != "")
            {
                LoadInfoHoaDon();
                btn_xoa.Enabled = true;
                btn_huy.Enabled = true;
            }
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "Select a.MaSP, b.TenSP, a.SoLuong " +
                "from tblChiTietPDH as a, tblSanPham as b where a.MaPDH = N'"
                + txtMaPDH.Text + "'AND a.MaSP= b.MaSP";
            tblChiTietPDH = Functions.GetDataToTable(sql);
            dgv_PhieuDatHang.DataSource = tblChiTietPDH;
            dgv_PhieuDatHang.AllowUserToAddRows = false;
            dgv_PhieuDatHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadInfoHoaDon()
        {
            string str;
            str = "Select NgayThang from tblPhieuDatHang where MaPDH = N'" + txtMaPDH.Text + "'";
            dtpNgayTaoPhieu.Value = DateTime.Parse(Functions.GetFieldValues(str));
            str = "Select MaNV from tblPhieuDatHang where MaPDH = N'" + txtMaPDH.Text + "'";
            cboMaNV.Text = Functions.GetFieldValues(str);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            btn_huy.Enabled = false;
            btn_them.Enabled = false;
            ResetValues();
            txtMaPDH.Text = Functions.CreateKey("PDH");
            LoadDataGridView();
        }
        private void ResetValues()
        {
            txtMaPDH.Text = "";
            dtpNgayTaoPhieu.Value = DateTime.Now;
            cboMaNV.Text = "";
            cboMaSP.Text = "";
            txtSoLuong.Text = "";
        }
    

        private void btn_in_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinPDH, tblThongtinSP;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Công ty TNHH quản lý doanh nghiệp MIXUE BING CHENG";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Số 46 Chùa Láng-Phường Láng Thượng-Quận Đống Đa-TP.Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)38526184";
            exRange.Range["C4:E4"].Font.Size = 16;
            exRange.Range["C4:E4"].Font.Bold = true;
            exRange.Range["C4:E4"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C4:E4"].MergeCells = true;
            exRange.Range["C4:E4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C4:E4"].Value = "PHIẾU ĐẶT HÀNG";
            // Biểu diễn thông tin chung của phiếu đặt hàng
            sql = "SELECT a.MaPDH, a.NgayThang, b.HoTen FROM tblPhieuDatHang AS a join tblNhanVien AS b " +
                "on a.MaNV =b.MaNV where a.MaPDH = N'"
                + txtMaPDH.Text + "' ";
            tblThongtinPDH = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã phiếu đặt hàng:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = "'" + tblThongtinPDH.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Nhân viên:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = "'" + tblThongtinPDH.Rows[0][2].ToString();
            //Lấy thông tin các sản phẩm
            sql = "SELECT b.TenSP, a.SoLuong " +
                  "FROM tblChiTietPDH AS a , tblSanPham AS b WHERE a.MaPDH = N'" +
                  txtMaPDH.Text + "' AND a.MaSP = b.MaSP";
            tblThongtinSP = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên sản phẩm";
            exRange.Range["C11:C11"].Value = "Số lượng";
            for (hang = 0; hang < tblThongtinSP.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinSP.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinSP.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinSP.Rows[hang][cot].ToString() + "%";
                }
            }
            //exRange = exSheet.Cells[cot + 1][hang + 11];
            //exRange.Font.Bold = true;
            // exRange.Value2 = tblThongtinPDH.Rows[0][2].ToString();
            exRange = exSheet.Cells[cot + 1][hang + 14]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinPDH.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;

            exRange = exSheet.Cells[4][hang + 14]; //Ô A1     
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên tạo phiếu";
            exRange.Range["A4:C4"].MergeCells = true;
            exRange.Range["A4:C4"].Font.Italic = true;
            exRange.Range["A4:C4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A4:C4"].Value = tblThongtinPDH.Rows[0][2];
            exSheet.Name = "Phiếu đặt hàng";
            exApp.Visible = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaPDH FROM tblPhieuDatHang WHERE MaPDH=N'" + txtMaPDH.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDN được sinh tự động do đó không có trường hợp trùng khóa 
                if (cboMaNV.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNV.Focus();
                    return;
                }
                if (dtpNgayTaoPhieu.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpNgayTaoPhieu.Focus();
                    return;
                }
                sql = "INSERT INTO tblPhieuDatHang(MaPDH, MaNV, NgayThang) VALUES (N'" + txtMaPDH.Text.Trim() + "','"
                    + cboMaNV.SelectedValue + "',N'"
                    + dtpNgayTaoPhieu.Value + "'" + ")";
                Functions.RunSQL(sql);
            }

            if (cboMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaSP.Focus();
                return;
            }
            if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }



            sql = "SELECT MaSP FROM tblChiTietPDH WHERE MaSP=N'" + cboMaSP.SelectedValue + "' AND MaPDH = N'" + txtMaPDH.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesSanPham();
                cboMaSP.Focus();
                return;
            }
            sql = "INSERT INTO tblChiTietPDH(MaPDH,MaSP,SoLuong) VALUES(N'" + txtMaPDH.Text.Trim() +
                "',N'" + cboMaSP.SelectedValue + "'," + txtSoLuong.Text + ")";
            Functions.RunSQL(sql);

            LoadDataGridView();
            ResetValuesSanPham();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_huy.Enabled = true;



        }
        private void ResetValuesSanPham()
        {
            cboMaSP.Text = "";
            txtSoLuong.Text = "";
        }
    private void btn_huy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            txtMaPDH.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                //Xóa chi tiết phiếu đặt hàng
                sql = "DELETE tblChiTietPDH WHERE MaPDH=N'" + txtMaPDH.Text + "'";
                Functions.RunSqlDel(sql);

                //Xóa phiếu đặt hàng
                sql = "DELETE tblPhieuDatHang WHERE MaPDH=N'" + txtMaPDH.Text + "'";
                Functions.RunSqlDel(sql);
                ResetValues();
                LoadDataGridView();
                btn_xoa.Enabled = false;
                btn_huy.Enabled = false;
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNV.Text == "")
                txtTenNV.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select HoTen from tblNhanVien where MaNV =N'" + cboMaNV.Text + "'";
            txtTenNV.Text = Functions.GetFieldValues(str);
        }

        private void cboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaSP.Text == "")
                txtTenSP.Text = "";
            // Khi chọn mã sản phẩm thì các thông tin về sp hiện ra
            str = "SELECT TenSP FROM tblSanPham WHERE MaSP =N'" + cboMaSP.Text + "'";
            txtTenSP.Text = Functions.GetFieldValues(str);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void dgv_PhieuDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMaSP.Text = dgv_PhieuDatHang.CurrentRow.Cells["MaSP"].Value.ToString();
            txtTenSP.Text = dgv_PhieuDatHang.CurrentRow.Cells["TenSP"].Value.ToString();
            txtSoLuong.Text = dgv_PhieuDatHang.CurrentRow.Cells["SoLuong"].Value.ToString();
        }
    }
}
