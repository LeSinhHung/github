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

namespace QLCHSUA
{
    public partial class DangNhap : Form
    {
        SqlConnection sqlcon = null;
        private string tentaikhoan;
        private string matkhau;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(@"Data Source=DESKTOP-8DCO9H8;Initial Catalog=ChiNhanhSua;Integrated Security=True");
            }
            LayThongTinDangNhap();
        }

        private void LayThongTinDangNhap()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                string query = "SELECT TaiKhoan, MatKhau FROM DangNhap";
                using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tentaikhoan = reader["TaiKhoan"].ToString();
                            matkhau = reader["MatKhau"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tk = tb_taikhoan.Text.Trim();
            string mk = tb_matkhau.Text.Trim();

            if (KiemTraDangNhap(tk, mk))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_taikhoan.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            return tentaikhoan.Equals(this.tentaikhoan, StringComparison.Ordinal) && 
                   matkhau.Equals(this.matkhau, StringComparison.Ordinal);
        }
    }
}
