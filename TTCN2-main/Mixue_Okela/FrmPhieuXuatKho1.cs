using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;


namespace Mixue_Okela
{
    public partial class FrmPhieuXuatKho1 : Form
    {
        DataTable tblChiTietPXK;
        public FrmPhieuXuatKho1()
        {
            InitializeComponent();
        }

        private void FrmPhieuXuatKho1_Load(object sender, EventArgs e)
        {
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_xoa.Enabled = false;
            btn_in.Enabled = false;
            btn_huy.Enabled = false;
            txtMaXK.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtTenCH.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTenSP.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtDonVi.ReadOnly = true;
            txtDonVi.Text = "";
            txtTongTien.Text = "0";
            Functions.FillCombo1("select MaNV from tblNhanVien", cboMaNV, "MaNV");
            cboMaNV.SelectedIndex = -1;
            Functions.FillCombo1("select MaCH from tblCuaHang", cboMaCH, "MaCH");
            cboMaCH.SelectedIndex = -1;
            Functions.FillCombo1("select MaSP from tblSanPham", cboMaSP, "MaSP");
            cboMaSP.SelectedIndex = -1;
            if (txtMaXK.Text != "")
            {
                LoadInfoHoaDon();
                btn_xoa.Enabled = true;
                btn_huy.Enabled = true;
                btn_in.Enabled = true;
            }
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaSP, b.TenSP, a.SoLuong, b.DonGia,a.ThanhTien,b.DonVi " +
                "FROM tblChiTietXuatKho AS a, tblSanPham AS b WHERE a.MaXK = '" + txtMaXK.Text + "' AND a.MaSP=b.MaSP";
            tblChiTietPXK = Functions.GetDataToTable(sql);
            DataGridView_XK.DataSource = tblChiTietPXK;
        }
        private void LoadInfoHoaDon()
        {

            string str;
            str = "SELECT NgayXuat FROM tblPhieuXuatKho WHERE MaXK = N'" + txtMaXK.Text + "'";
            dtpNgayXuat.Text = Functions.ConvertDateTime(Functions.GetFieldValues(str));
            str = "SELECT MaNV FROM tblPhieuXuatKho WHERE MaXK = N'" + txtMaXK.Text + "'";
            cboMaNV.SelectedValue = Functions.GetFieldValues(str);
            str = "SELECT MaCH FROM tblPhieuXuatKho WHERE MaXK = N'" + txtMaXK.Text + "'";
            cboMaCH.SelectedValue = Functions.GetFieldValues(str);
            str = "SELECT TongTien FROM tblPhieuXuatKho WHERE MaXK = N'" + txtMaXK.Text + "'";
            txtTongTien.Text = Functions.GetFieldValues(str);
            //lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(txtTongTien.Text));
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            btn_in.Enabled = true;
            btn_them.Enabled = false;
            ResetValues();
            txtMaXK.Text = Functions.CreateKey("PXK");
            loadDataGridView();
        }
        private void ResetValues()
        {
            txtMaXK.Text = "";
            dtpNgayXuat.Text = DateTime.Now.ToShortDateString();
            cboMaNV.Text = "";
            cboMaCH.Text = "";
            txtTongTien.Text = "0";
            cboMaSP.Text = "";
            txtSoLuong.Text = "";
            txtDonVi.Text = "";
            txtThanhTien.Text = "0";
            //lblBangChu.Text = "Bằng chữ: ";
        }
        private void ResetValuesSP()
        {
            cboMaSP.Text = "";
            txtSoLuong.Text = "";
            txtDonVi.Text = "";
            txtThanhTien.Text = "0";
        }

    

    private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MaXK FROM tblPhieuXuatKho WHERE MaXK='" + txtMaXK.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (dtpNgayXuat.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpNgayXuat.Focus();
                    return;
                }
                if (cboMaNV.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNV.Focus();
                    return;
                }
                if (cboMaCH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập cửa hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaCH.Focus();
                    return;
                }
                sql = "INSERT INTO tblPhieuXuatKho(MaXK, NgayXuat, MaNV, MaCH, TongTien) VALUES (N'" + txtMaXK.Text.Trim() + "','" +
                        Functions.ConvertDateTime(dtpNgayXuat.Text.Trim()) + "',N'" + cboMaNV.SelectedValue + "',N'" +
                        cboMaCH.SelectedValue + "'," + txtTongTien.Text + ")";
                Functions.RunSQL(sql);
            }
            // Lưu thông tin của các sản phẩm
            if (cboMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaSP.Focus();
                return;
            }
            if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSoLuong.Focus();
                return;
            }
            if (txtDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonVi.Focus();
                return;
            }
            sql = "SELECT MaSP FROM tblChiTietXuatKho WHERE MaSP=N'" + cboMaSP.SelectedValue + "' AND MaXK = N'" + txtMaXK.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesSP();
                cboMaSP.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblSanPham WHERE MaSP = N'" + cboMaSP.SelectedValue + "'"));

            if (Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng sản phẩm này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            sql = "insert into tblChiTietXuatKho (MaXK,MaSP,SoLuong,ThanhTien) values('" + txtMaXK.Text + "','" + cboMaSP.SelectedValue + "'," + txtSoLuong.Text + "," + txtThanhTien.Text + ")";
            Functions.RunSQL(sql);
            loadDataGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng SanPham
            SLcon = sl - Convert.ToDouble(txtSoLuong.Text);
            sql = "UPDATE tblSanPham SET SoLuong =" + SLcon + " WHERE MaSP= N'" + cboMaSP.SelectedValue + "'";
            Functions.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM tblPhieuXuatKho WHERE MaXK = N'"
                + txtMaXK.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
            sql = "UPDATE tblPhieuXuatKho SET TongTien =" + Tongmoi + " WHERE MaXK = N'" + txtMaXK.Text + "'";
            Functions.RunSQL(sql);
            txtTongTien.Text = Tongmoi.ToString();
            //lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(Tongmoi.ToString()));
            ResetValuesSP();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_in.Enabled = true;
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongTinXK, tblThongTinSP;
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
            exRange.Range["A1:B1"].Value = "Công Ty TNHH Quản lý Doang nghiệp Mixue BING CHENG";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Số 46 Chùa Láng, Phố Láng Thượng, Quận Đống Đa, TP.Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)38526419";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "PHIẾU XUẤT KHO";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.MaXK ,a.NgayXuat, a.TongTien, b.TenCH, b.DiaChi, b.SDT, c.HoTen " +
                "FROM tblPhieuXuatKho AS a, tblCuaHang AS b, tblNhanVien AS c WHERE a.MaXK = N'" +
                txtMaXK.Text + "' AND a.MaCH = b.MaCH AND a.MaNV = c.MaNV";
            tblThongTinXK = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã xuất kho:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = "'" + tblThongTinXK.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Cửa hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongTinXK.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongTinXK.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = "'" + tblThongTinXK.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenSP, a.SoLuong, b.DonGia, b.DonVi, a.ThanhTien " +
                  "FROM tblChiTietXuatKho AS a , tblSanPham AS b WHERE a.MaXK = N'" +
                  txtMaXK.Text + "' AND a.MaSP = b.MaSP";
            tblThongTinSP = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên sản phẩm";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Đơn vị";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongTinSP.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongTinSP.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongTinSP.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongTinSP.Rows[hang][cot].ToString();
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongTinXK.Rows[0][2].ToString();
            /* exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
             exRange.Range["A1:F1"].MergeCells = true;
             exRange.Range["A1:F1"].Font.Bold = true;
             exRange.Range["A1:F1"].Font.Italic = true;
             exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
             exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(tblThongTinXK.Rows[0][2].ToString()));*/
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongTinXK.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên lập phiếu";
            exRange.Range["A4:C4"].MergeCells = true;
            exRange.Range["A4:C4"].Font.Italic = true;
            exRange.Range["A4:C4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A4:C4"].Value = tblThongTinXK.Rows[0][6];
            exSheet.Name = "Phiếu xuất kho";
            exApp.Visible = true;
        }
    

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            txtMaXK.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaSP,SoLuong FROM tblChiTietXuatKho WHERE MaXK = N'" + txtMaXK.Text + "'";
                DataTable tblSanPham = Functions.GetDataToTable(sql);
                for (int hang = 0; hang <= tblSanPham.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các sản phẩm
                    sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblSanPham WHERE MaSP = N'" + tblSanPham.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblSanPham.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE tblSanPham SET SoLuong =" + slcon + " WHERE MaSP= N'" + tblSanPham.Rows[hang][0].ToString() + "'";
                    Functions.RunSQL(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE tblChiTietXuatKho WHERE MaXK=N'" + txtMaXK.Text + "'";
                Functions.RunSqlDel(sql);

                //Xóa hóa đơn
                sql = "DELETE tblPhieuXuatKho WHERE MaXK=N'" + txtMaXK.Text + "'";
                Functions.RunSqlDel(sql);
                ResetValues();
                loadDataGridView();
                btn_xoa.Enabled = false;
                btn_in.Enabled = false;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaXK.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã xuất kho để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaXK.Focus();
                return;
            }
            txtMaXK.Text = cboMaXK.Text;
            LoadInfoHoaDon();
            loadDataGridView();
            btn_xoa.Enabled = true;
            btn_luu.Enabled = true;
            btn_in.Enabled = true;
            btn_them.Enabled = true;
            cboMaXK.SelectedIndex = -1;
        }

        private void DataGridView_XK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMaSP.Text = DataGridView_XK.CurrentRow.Cells["MaSP"].Value.ToString();
            txtTenSP.Text = DataGridView_XK.CurrentRow.Cells["TenSP"].Value.ToString();
            txtDonGia.Text = DataGridView_XK.CurrentRow.Cells["DonGia"].Value.ToString();
            txtDonVi.Text = DataGridView_XK.CurrentRow.Cells["DonVi"].Value.ToString();
            txtThanhTien.Text = DataGridView_XK.CurrentRow.Cells["ThanhTien"].Value.ToString();
            txtSoLuong.Text = DataGridView_XK.CurrentRow.Cells["SoLuong"].Value.ToString();
        }

        private void cboMaNV_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNV.Text == "")
                txtTenNV.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select HoTen from tblNhanVien where MaNV =N'" + cboMaNV.SelectedValue + "'";
            txtTenNV.Text = Functions.GetFieldValues(str);
        }

        private void cboMaCH_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaCH.Text == "")
            {
                txtTenCH.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
            }
            //Khi chọn Mã của hàng thì các thông tin của cửa hàng sẽ hiện ra
            str = "Select TenCH from tblCuaHang where MaCH = N'" + cboMaCH.SelectedValue + "'";
            txtTenCH.Text = Functions.GetFieldValues(str);
            str = "Select DiaChi from tblCuaHang where MaCH = N'" + cboMaCH.SelectedValue + "'";
            txtDiaChi.Text = Functions.GetFieldValues(str);
            str = "Select SDT from tblCuaHang where MaCH= N'" + cboMaCH.SelectedValue + "'";
            txtSDT.Text = Functions.GetFieldValues(str);
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
        }

        private void cboMaSP_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaSP.Text == "")
            {
                txtTenSP.Text = "";
                txtDonGia.Text = "";
                txtDonVi.Text = "";
                txtSoLuong.Text = "";
                txtThanhTien.Text = "";
            }
            //Khi chọn Mã giày dép thì các thông tin của giày dép sẽ hiện ra
            str = "Select TenSP from tblSanPham where MaSP = N'" + cboMaSP.SelectedValue + "'";
            txtTenSP.Text = Functions.GetFieldValues(str);
            str = "Select DonGia from tblSanPham where MaSP='" + cboMaSP.SelectedValue + "'";
            txtDonGia.Text = Functions.GetFieldValues(str);
            str = "Select DonVi from tblSanPham where MaSP = N'" + cboMaSP.SelectedValue + "'";
            txtDonVi.Text = Functions.GetFieldValues(str);
        }

        private void cboMaXK_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo1("SELECT MaXK FROM tblPhieuXuatKho", cboMaXK, "MaXK");
            cboMaXK.SelectedIndex = -1;
        }

        private void DataGridView_XK_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblChiTietPXK.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = DataGridView_XK.CurrentRow.Cells["MaSP"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(DataGridView_XK.CurrentRow.Cells["SoLuong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(DataGridView_XK.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sql = "DELETE tblChiTietXuatKho WHERE MaXK=N'" + txtMaXK.Text + "' AND MaSP = N'" + MaHangxoa + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblSanPham WHERE MaSP = N'" + MaHangxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE tblSanPham SET SoLuong =" + slcon + " WHERE MaSP= N'" + MaHangxoa + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM tblPhieuXuatKho WHERE MaXK = N'" + txtMaXK.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE tblPhieuXuatKho SET TongTien =" + tongmoi + " WHERE MaXK = N'" + txtMaXK.Text + "'";
                Functions.RunSQL(sql);
                txtTongTien.Text = tongmoi.ToString();
                //lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(tongmoi.ToString()));
                ResetValuesSP();
                loadDataGridView();
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            btn_in.Enabled = true;
            btn_them.Enabled = false;
            ResetValues();
            txtMaXK.Text = Functions.CreateKey("PXK");
            loadDataGridView();
        }

        private void btn_luu_Click_1(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MaXK FROM tblPhieuXuatKho WHERE MaXK='" + txtMaXK.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (dtpNgayXuat.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpNgayXuat.Focus();
                    return;
                }
                if (cboMaNV.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNV.Focus();
                    return;
                }
                if (cboMaCH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập cửa hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaCH.Focus();
                    return;
                }
                sql = "INSERT INTO tblPhieuXuatKho(MaXK, NgayXuat, MaNV, MaCH, TongTien) VALUES (N'" + txtMaXK.Text.Trim() + "','" +
                        Functions.ConvertDateTime(dtpNgayXuat.Text.Trim()) + "',N'" + cboMaNV.SelectedValue + "',N'" +
                        cboMaCH.SelectedValue + "'," + txtTongTien.Text + ")";
                Functions.RunSQL(sql);
            }
            // Lưu thông tin của các sản phẩm
            if (cboMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaSP.Focus();
                return;
            }
            if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSoLuong.Focus();
                return;
            }
            if (txtDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonVi.Focus();
                return;
            }
            sql = "SELECT MaSP FROM tblChiTietXuatKho WHERE MaSP=N'" + cboMaSP.SelectedValue + "' AND MaXK = N'" + txtMaXK.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesSP();
                cboMaSP.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblSanPham WHERE MaSP = N'" + cboMaSP.SelectedValue + "'"));

            if (Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng sản phẩm này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            sql = "insert into tblChiTietXuatKho (MaXK,MaSP,SoLuong,ThanhTien) values('" + txtMaXK.Text + "','" + cboMaSP.SelectedValue + "'," + txtSoLuong.Text + "," + txtThanhTien.Text + ")";
            Functions.RunSQL(sql);
            loadDataGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng SanPham
            SLcon = sl - Convert.ToDouble(txtSoLuong.Text);
            sql = "UPDATE tblSanPham SET SoLuong =" + SLcon + " WHERE MaSP= N'" + cboMaSP.SelectedValue + "'";
            Functions.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM tblPhieuXuatKho WHERE MaXK = N'"
                + txtMaXK.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
            sql = "UPDATE tblPhieuXuatKho SET TongTien =" + Tongmoi + " WHERE MaXK = N'" + txtMaXK.Text + "'";
            Functions.RunSQL(sql);
            txtTongTien.Text = Tongmoi.ToString();
            //lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(Tongmoi.ToString()));
            ResetValuesSP();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_in.Enabled = true;
        }

        private void btn_in_Click_1(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongTinXK, tblThongTinSP;
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
            exRange.Range["A1:B1"].Value = "Công Ty TNHH Quản lý Doang nghiệp Mixue BING CHENG";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Số 46 Chùa Láng, Phố Láng Thượng, Quận Đống Đa, TP.Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)38526419";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "PHIẾU XUẤT KHO";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.MaXK ,a.NgayXuat, a.TongTien, b.TenCH, b.DiaChi, b.SDT, c.HoTen " +
                "FROM tblPhieuXuatKho AS a, tblCuaHang AS b, tblNhanVien AS c WHERE a.MaXK = N'" +
                txtMaXK.Text + "' AND a.MaCH = b.MaCH AND a.MaNV = c.MaNV";
            tblThongTinXK = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã xuất kho:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = "'" + tblThongTinXK.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Cửa hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongTinXK.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongTinXK.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = "'" + tblThongTinXK.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenSP, a.SoLuong, b.DonGia, b.DonVi, a.ThanhTien " +
                  "FROM tblChiTietXuatKho AS a , tblSanPham AS b WHERE a.MaXK = N'" +
                  txtMaXK.Text + "' AND a.MaSP = b.MaSP";
            tblThongTinSP = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên sản phẩm";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Đơn vị";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongTinSP.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongTinSP.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongTinSP.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongTinSP.Rows[hang][cot].ToString();
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongTinXK.Rows[0][2].ToString();
            /* exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
             exRange.Range["A1:F1"].MergeCells = true;
             exRange.Range["A1:F1"].Font.Bold = true;
             exRange.Range["A1:F1"].Font.Italic = true;
             exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
             exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(tblThongTinXK.Rows[0][2].ToString()));*/
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongTinXK.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên lập phiếu";
            exRange.Range["A4:C4"].MergeCells = true;
            exRange.Range["A4:C4"].Font.Italic = true;
            exRange.Range["A4:C4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A4:C4"].Value = tblThongTinXK.Rows[0][6];
            exSheet.Name = "Phiếu xuất kho";
            exApp.Visible = true;
        }

        private void btn_huy_Click_1(object sender, EventArgs e)
        {
            ResetValues();
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            txtMaXK.Enabled = false;
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaSP,SoLuong FROM tblChiTietXuatKho WHERE MaXK = N'" + txtMaXK.Text + "'";
                DataTable tblSanPham = Functions.GetDataToTable(sql);
                for (int hang = 0; hang <= tblSanPham.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các sản phẩm
                    sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblSanPham WHERE MaSP = N'" + tblSanPham.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblSanPham.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE tblSanPham SET SoLuong =" + slcon + " WHERE MaSP= N'" + tblSanPham.Rows[hang][0].ToString() + "'";
                    Functions.RunSQL(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE tblChiTietXuatKho WHERE MaXK=N'" + txtMaXK.Text + "'";
                Functions.RunSqlDel(sql);

                //Xóa hóa đơn
                sql = "DELETE tblPhieuXuatKho WHERE MaXK=N'" + txtMaXK.Text + "'";
                Functions.RunSqlDel(sql);
                ResetValues();
                loadDataGridView();
                btn_xoa.Enabled = false;
                btn_in.Enabled = false;
            }
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            if (cboMaXK.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã xuất kho để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaXK.Focus();
                return;
            }
            txtMaXK.Text = cboMaXK.Text;
            LoadInfoHoaDon();
            loadDataGridView();
            btn_xoa.Enabled = true;
            btn_luu.Enabled = true;
            btn_in.Enabled = true;
            btn_them.Enabled = true;
            cboMaXK.SelectedIndex = -1;
        }
    }
}
