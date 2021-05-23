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

namespace Mixue_Okela
{
    public partial class FrmChinh : Form
    {
        public FrmChinh()
        {
            InitializeComponent();
        }

        private void FrmChinh_Load(object sender, EventArgs e)
        {
            Functions.Connection();
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

        private void mnuCuaHang_Click(object sender, EventArgs e)
        {
            FrmCuaHang DM_TL = new FrmCuaHang();
            DM_TL.ShowDialog();
        }

        private void mnuTKPhieuXuat_Click(object sender, EventArgs e)
        {
            FrmTimKiemPXK TK_XK = new FrmTimKiemPXK();
            TK_XK.ShowDialog();
        }

        private void mnuDanhMucXK_Click(object sender, EventArgs e)
        {
            FrmPhieuXuatKho1 DM_XK = new FrmPhieuXuatKho1();
            DM_XK.ShowDialog();
        }

        private void mnuThoat_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void mnuDanhMuc_NV_Click(object sender, EventArgs e)
        {
            FrmNhanVien DM_NV = new FrmNhanVien();
            DM_NV.ShowDialog();
        }

        private void mnuDanhMuc_CV_Click(object sender, EventArgs e)
        {
            FrmChucVu DM_CV = new FrmChucVu();
            DM_CV.ShowDialog();
        }

        private void mnuDanhMuc_NCC_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap DM_NCC = new FrmNhaCungCap();
            DM_NCC.ShowDialog();
        }

        private void mnuTimKiem_SP_Click(object sender, EventArgs e)
        {
            FrmTimKiemSP TK_SP = new FrmTimKiemSP();
            TK_SP.ShowDialog();
        }

        private void mnuDanhMuc_SP_Click(object sender, EventArgs e)
        {
            FrmSanPham DM_SP = new FrmSanPham();
            DM_SP.ShowDialog();
        }

        private void mnuTimKiem_PNK_Click(object sender, EventArgs e)
        {
            FrmTimKiemPNK TK_PNK = new FrmTimKiemPNK();
            TK_PNK.ShowDialog();
        }

        private void mnuPhieuNK_Click(object sender, EventArgs e)
        {
            FrmPhieuNhapKho DM_PNK = new FrmPhieuNhapKho();
            DM_PNK.ShowDialog();
        }

        private void mnuBaoCao_TK_Click(object sender, EventArgs e)
        {
            FrmBC_TK BC_TK = new FrmBC_TK();
            BC_TK.ShowDialog();
        }

        private void mnuPhieuDatHang_Click(object sender, EventArgs e)
        {
            FrmPhieuDatHang TK_PDH = new FrmPhieuDatHang();
            TK_PDH.ShowDialog();
        }
    }
}
