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
    public partial class FrmCuaHang : Form
    {
        DataTable tblCuaHang;
        public FrmCuaHang()
        {
            InitializeComponent();
        }

        private void FrmCuaHang_Load(object sender, EventArgs e)
        {
            txtMaCH.Enabled = false;
            loadDataToGridview();
        }
        private void loadDataToGridview()
        {
            string sql = "select * from tblCuaHang";
            tblCuaHang = Functions.GetDataToTable(sql);
            DataGridView_CH.DataSource = tblCuaHang;

        }
        private void DataGridView_CH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCH.Text = DataGridView_CH.CurrentRow.Cells["MaCH"].Value.ToString();
            txtTenCH.Text = DataGridView_CH.CurrentRow.Cells["TenCH"].Value.ToString();
            txtDiaChi.Text = DataGridView_CH.CurrentRow.Cells["DiaChi"].Value.ToString();
            msk_SDT.Text = DataGridView_CH.CurrentRow.Cells["SDT"].Value.ToString();
            txtMaCH.Enabled = false;
        }
        private void ResetValue()
        {
            txtMaCH.Text = "";
            txtTenCH.Text = "";
            txtDiaChi.Text = "";
            msk_SDT.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();
            txtMaCH.Enabled = true;
            txtMaCH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCuaHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }
            if (txtMaCH.Text == "")
            {
                MessageBox.Show("Nhập mã cửa hàng");
                txtMaCH.Focus();

            }
            if (txtTenCH.Text == "")
            {
                MessageBox.Show("Nhập tên cửa hàng ");
                txtTenCH.Focus();
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Nhập địa chỉ");
                txtDiaChi.Focus();
            }
            if (msk_SDT.Text == "")
            {
                MessageBox.Show("Nhập số điện thoại");
                msk_SDT.Focus();
            }
            sql = "select MaCH from tblCuaHang where MaCH='" + txtMaCH.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã này đã tồn tại trong hệ thống. Vui lòng nhập mã khác!!");
                txtMaCH.Focus();
                return;
            }
            sql = "insert into tblCuaHang values('" + txtMaCH.Text + "','" + txtTenCH.Text + "',N'" + txtDiaChi.Text + "',N'" + msk_SDT.Text + "')";
            Functions.RunSqlDel(sql);
            loadDataToGridview();
            ResetValue();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCuaHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
            }
            if (txtMaCH.Text == "")
            {
                MessageBox.Show(" Bạn chưa chọn mã cửa hàng nào", " Thông báo",

                MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            if (txtTenCH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên cửa hàng", " Thông báo",

                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTenCH.Focus();

            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", " Thông báo",

                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();

            }
            if (msk_SDT.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", " Thông báo",

                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msk_SDT.Focus();

            }

            sql = " UPDATE tblCuaHang SET TenCH =  N'" + txtTenCH.Text.ToString() +
            " ',DiaChi=N'" + txtDiaChi.Text.Trim().ToString() + "',SDT='" + msk_SDT.Text.Trim().ToString() +
            " 'WHERE MaCH='" + txtMaCH.Text + "'";

            Functions.RunSqlDel(sql);
            loadDataToGridview();
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCuaHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!!");
            }
            if (txtMaCH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã cửa hàng!!");
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from tblCuaHang where MaCH = '" + txtMaCH.Text + "'";
                Functions.RunSqlDel(sql);
                loadDataToGridview();
                ResetValue();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnHuy.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            txtMaCH.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mskSDT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView_CH_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCH.Text = DataGridView_CH.CurrentRow.Cells["MaCH"].Value.ToString();
            txtTenCH.Text = DataGridView_CH.CurrentRow.Cells["TenCH"].Value.ToString();
            txtDiaChi.Text = DataGridView_CH.CurrentRow.Cells["DiaChi"].Value.ToString();
            msk_SDT.Text = DataGridView_CH.CurrentRow.Cells["SDT"].Value.ToString();
            txtMaCH.Enabled = false;
        }
    }
}
