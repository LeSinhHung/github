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
    public partial class QLKH : Form
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
                cmd.CommandText = "select * from TB_KhachHang";
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

        public QLKH()
        {
            InitializeComponent();
        }

        private void QLKH_Load(object sender, EventArgs e)
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

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = dgv.CurrentCell.RowIndex;
                tb_makh.Text = dgv.Rows[i].Cells["MKH"].Value.ToString();
                tb_ten.Text = dgv.Rows[i].Cells["Hoten"].Value.ToString();
                tb_sdt.Text = dgv.Rows[i].Cells["SDT"].Value.ToString();
                tb_diachi.Text = dgv.Rows[i].Cells["Diachi"].Value.ToString();
                dtime_ngaysinh.Value = Convert.ToDateTime(dgv.Rows[i].Cells["Ngaysinh"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void nut_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_makh.Text) || string.IsNullOrEmpty(tb_ten.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                cmd = connection.CreateCommand();
                cmd.CommandText = "insert into TB_KhachHang values(@MKH, @Hoten, @SDT, @Diachi, @Ngaysinh)";
                cmd.Parameters.AddWithValue("@MKH", tb_makh.Text);
                cmd.Parameters.AddWithValue("@Hoten", tb_ten.Text);
                cmd.Parameters.AddWithValue("@SDT", tb_sdt.Text);
                cmd.Parameters.AddWithValue("@Diachi", tb_diachi.Text);
                cmd.Parameters.AddWithValue("@Ngaysinh", dtime_ngaysinh.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm khách hàng thành công!");
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
                if (string.IsNullOrEmpty(tb_makh.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "delete from TB_KhachHang where MKH = @MKH";
                    cmd.Parameters.AddWithValue("@MKH", tb_makh.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa khách hàng thành công!");
                    loadData();
                }
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
                if (string.IsNullOrEmpty(tb_makh.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần sửa!");
                    return;
                }

                cmd = connection.CreateCommand();
                cmd.CommandText = "update TB_KhachHang set Hoten = @Hoten, SDT = @SDT, Diachi = @Diachi, Ngaysinh = @Ngaysinh where MKH = @MKH";
                cmd.Parameters.AddWithValue("@MKH", tb_makh.Text);
                cmd.Parameters.AddWithValue("@Hoten", tb_ten.Text);
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

        private void nut_tim_Click(object sender, EventArgs e)
        { 
            try
            {
                if(string.IsNullOrEmpty(tb_tim.Text))
                {
                    loadData();
                    return;
                }
                cmd = connection.CreateCommand();
                cmd.CommandText = "select * from TB_KhachHang where MKH = @TimKiem";
                cmd.Parameters.AddWithValue("@TimKiem", tb_tim.Text);
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                dgv.DataSource = table;
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
