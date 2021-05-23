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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        private string getId(string user, string pass)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=NGUYET\SQLEXPRESS;Initial Catalog=QuanLyKhoHang;Integrated Security=True");
            string id = "";
            SqlCommand cmd = new SqlCommand("Select * from tblTaiKhoan where TenDangNhap = N'" + txtDangNhap.Text + "'" +
                "and MatKhau=N'" + txtMatKhau.Text + "'", conn);
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    id = dr["Id"].ToString();
                }
            }
            return id;
        }

        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sql = "Select * from tblTaiKhoan where TenDangNhap=N'" + txtDangNhap.Text + "'" +
                "and MatKhau=N'" + txtMatKhau.Text + "'";
            string id_user;
            id_user = getId(txtDangNhap.Text, txtMatKhau.Text);
            if (id_user != "")
            {
                MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                Form main = new FrmChinh(); 
                main.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDangNhap.Text = "";
                txtMatKhau.Text = "";
                txtDangNhap.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
