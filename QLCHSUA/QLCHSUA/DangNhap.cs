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
        string tentaikhoan = "lesinhhung";
        string matkhau = "lehung2112003";
        SqlConnection sqlcon = null; // đối tượng kết nối
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(KiemTraDangNhap(tb_taikhoan.Text, tb_matkhau.Text))
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection("Data Source=LAPTOP-NNG5TEB9\\SQLEXPRESS;Initial Catalog=QLCHSua;Integrated Security=True");
                }
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                string tk = tb_taikhoan.Text.Trim();
                string mk = tb_matkhau.Text.Trim();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "SELECT * FROM DangNhap WHERE TaiKhoan = '" + tk + "' AND MatKhau = '" + mk + "' ";

                sqlcmd.Connection = sqlcon;

                SqlDataReader data = sqlcmd.ExecuteReader();
                if (data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
                //Đóng reader
                data.Close();
            }
            else
            {
                MessageBox.Show(" Sai thông tin tài khoản hoặc mật khẩu");
                tb_taikhoan.Focus();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            if(tentaikhoan == this.tentaikhoan && matkhau == this.matkhau )
            {
                return true;
            }
            return false;
        }
    }
 }

