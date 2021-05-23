using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace Mixue_Okela
{
    public partial class FrmBC_TK : Form
    {
        DataTable tblBaoCao;
        public FrmBC_TK()
        {
            InitializeComponent();
        }

        private void FrmBC_TK_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_BC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = DataGridView_BC.CurrentRow.Cells["MaSP"].Value.ToString();
            txtSoLuong.Text = DataGridView_BC.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtTenNCC.Text = DataGridView_BC.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtDonGia.Text = DataGridView_BC.CurrentRow.Cells["DonGia"].Value.ToString();
            txtDonVi.Text = DataGridView_BC.CurrentRow.Cells["DonVi"].Value.ToString();
            txtTenSP.Text = DataGridView_BC.CurrentRow.Cells["TenSP"].Value.ToString();
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select a.MaSP,a.TenSP,a.SoLuong,a.DonGia,a.DonVi,b.TenNCC from tblSanPham as a join tblNhaCungCap as b" +
                " on a.MaNCC=b.MaNCC where a.SoLuong >0 order by a.SoLuong asc";
            tblBaoCao = Functions.GetDataToTable(sql);
            DataGridView_BC.DataSource = tblBaoCao;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongTinSP_TK;
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
            exRange.Range["C4:E4"].Font.Size = 16;
            exRange.Range["C4:E4"].Font.Bold = true;
            exRange.Range["C4:E4"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C4:E4"].MergeCells = true;
            exRange.Range["C4:E4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C4:E4"].Value = "BÁO CÁO SẢN PHẨM TỒN KHO";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "select a.TenSP,a.SoLuong,a.DonGia,a.DonVi,b.TenNCC from tblSanPham as a join tblNhaCungCap as b" +
                " on a.MaNCC=b.MaNCC where a.SoLuong >0 order by a.SoLuong asc";
            tblThongTinSP_TK = Functions.GetDataToTable(sql);
            /*exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã nhập kho:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = "'" + tblThongTinNK.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Nhà cung cấp:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongTinNK.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongTinNK.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = "'" + tblThongTinNK.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenSP, a.SoLuong, b.DonGia, b.DonVi, a.ThanhTien " +
                  "FROM tblChiTietNhapKho AS a , tblSanPham AS b WHERE a.MaNK = N'" +
                  txtMaNK.Text + "' AND a.MaSP = b.MaSP";
            tblThongTinSP = Functions.GetDataToTable(sql);*/
            //Tạo dòng tiêu đề bảng
            exRange.Range["A6:M6"].Font.Bold = true;
            exRange.Range["A6:M6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C6:O6"].ColumnWidth = 12;
            exRange.Range["A6:A6"].Value = "STT";
            exRange.Range["B6:B6"].Value = "Tên sản phẩm";
            exRange.Range["C6:C6"].Value = "Số lượng";
            exRange.Range["D6:D6"].Value = "Đơn giá";
            exRange.Range["E6:E6"].Value = "Đơn vị";
            exRange.Range["F6:F6"].Value = "Tên nhà cung cấp";
            for (hang = 0; hang < tblThongTinSP_TK.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 7] = hang + 1;
                for (cot = 0; cot < tblThongTinSP_TK.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 7] = tblThongTinSP_TK.Rows[hang][cot].ToString();
                   // if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongTinSP.Rows[hang][cot].ToString();
                }
            }
            /*exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongTinNK.Rows[0][2].ToString();
            /* exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
             exRange.Range["A1:F1"].MergeCells = true;
             exRange.Range["A1:F1"].Font.Bold = true;
             exRange.Range["A1:F1"].Font.Italic = true;
             exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
             exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(tblThongTinXK.Rows[0][2].ToString()));*/
           // exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["D20:F20"].MergeCells = true;
            exRange.Range["D20:F20"].Font.Italic = true;
            exRange.Range["D20:F20"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            //DateTime d = Convert.ToDateTime(tblThongTinNK.Rows[0][1]);
            exRange.Range["D20:F20"].Value = "Hà Nội, ngày " + day + " tháng " + month + " năm " + year;
            exRange.Range["D21:F21"].MergeCells = true;
            exRange.Range["D21:F21"].Font.Italic = true;
            exRange.Range["D21:F21"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D21:F21"].Value = "Nhân viên lập phiếu";
            exRange.Range["D22:F22"].MergeCells = true;
            exRange.Range["D22:F22"].Font.Italic = true;
            exRange.Range["D22:F22"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D22:F22"].Value = "(Kí và ghi rõ họ tên)";
            exSheet.Name = "Báo cáo";
            exApp.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
