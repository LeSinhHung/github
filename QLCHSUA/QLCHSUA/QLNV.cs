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
    public partial class QLNV : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-8DCO9H8;Initial Catalog=ChiNhanhSua;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "select * from TB_NhanVien";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                dgv.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        public QLNV()
        {
            InitializeComponent();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(str);
                connection.Open();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void nut_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_manv.Text) || string.IsNullOrEmpty(tb_tennv.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                cmd = connection.CreateCommand();
                cmd.CommandText = "insert into TB_NhanVien values(@MaNV, @HoTen, @SDT, @DiaChi, @NgaySinh)";
                cmd.Parameters.AddWithValue("@MaNV", tb_manv.Text);
                cmd.Parameters.AddWithValue("@HoTen", tb_tennv.Text);
                cmd.Parameters.AddWithValue("@SDT", tb_sdt.Text);
                cmd.Parameters.AddWithValue("@DiaChi", tb_diachi.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtime_ngaysinh.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm nhân viên thành công!");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        

        private void nut_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_manv.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                    return;
                }

                cmd = connection.CreateCommand();
                cmd.CommandText = "update TB_NhanVien set Hoten = @Hoten, SDT = @SDT, Diachi = @Diachi, Ngaysinh = @Ngaysinh where MaNV = @MaNV";
                cmd.Parameters.AddWithValue("@MaNV", tb_manv.Text);
                cmd.Parameters.AddWithValue("@Hoten", tb_tennv.Text);
                cmd.Parameters.AddWithValue("@SDT", tb_sdt.Text);
                cmd.Parameters.AddWithValue("@Diachi", tb_diachi.Text);
                cmd.Parameters.AddWithValue("@Ngaysinh", dtime_ngaysinh.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin thành công!");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void nut_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_manv.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", 
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "delete from TB_NhanVien where MaNV = @MaNV";
                    cmd.Parameters.AddWithValue("@MaNV", tb_manv.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa nhân viên thành công!");
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void nut_tim_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_tim.Text))
                {
                    loadData();
                    return;
                }

                cmd = connection.CreateCommand();
                cmd.CommandText = "select * from TB_NhanVien where MaNV = @TimKiem";
                cmd.Parameters.AddWithValue("@TimKiem", tb_tim.Text);
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                dgv.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                int i = dgv.CurrentCell.RowIndex;
                tb_manv.Text = dgv.Rows[i].Cells["MaNV"].Value.ToString();
                tb_tennv.Text = dgv.Rows[i].Cells["Hoten"].Value.ToString();
                tb_sdt.Text = dgv.Rows[i].Cells["SDT"].Value.ToString();
                tb_diachi.Text = dgv.Rows[i].Cells["Diachi"].Value.ToString();
                dtime_ngaysinh.Value = Convert.ToDateTime(dgv.Rows[i].Cells["Ngaysinh"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
    }
}
