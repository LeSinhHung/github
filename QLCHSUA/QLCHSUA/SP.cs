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
    public partial class SP : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-8DCO9H8;Initial Catalog=ChiNhanhSua;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from TB_SanPham";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public SP()
        {
            InitializeComponent();
        }

        private void SP_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentCell.RowIndex;
            tb_masp.Text = dgv.Rows[i].Cells["MSP"].Value.ToString();
            tb_hangsx.Text = dgv.Rows[i].Cells["TenSP"].Value.ToString();
            dtime_hsd.Text = dgv.Rows[i].Cells["HSD"].Value.ToString();
            tb_mota.Text = dgv.Rows[i].Cells["MoTa"].Value.ToString();
            tb_gia.Text = dgv.Rows[i].Cells["Gia"].Value.ToString();
            tb_soluong.Text = dgv.Rows[i].Cells["SoLuong"].Value.ToString();
            tb_loaisp.Text = dgv.Rows[i].Cells["LoaiSP"].Value.ToString();
        }

        private void nut_them_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "insert into TB_SanPham values('" + tb_masp.Text + "', '" + tb_hangsx.Text + "', '" + dtime_hsd.Text + "', '" + tb_mota.Text + "', '" + tb_gia.Text + "', '"+tb_soluong.Text+"', '"+tb_loaisp.Text+"')";
            cmd.ExecuteNonQuery();
            loadData();
            MessageBox.Show("Thêm Sản Phẩm Thành Công!");
        }

        private void nut_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(tb_masp.Text))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                    return;
                }
                else
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "update TB_SanPham set TenSP = '" + tb_hangsx.Text + "', HSD = '" + dtime_hsd.Text + "', MoTa = '" + tb_mota.Text + "', Gia = '" + tb_gia.Text + "', SoLuong = '"+tb_soluong.Text +"', LoaiSP = '"+tb_loaisp.Text+"' where MSP = '" + tb_masp.Text + "'";
                    cmd.ExecuteNonQuery();
                    loadData();
                    MessageBox.Show("Sửa Sản Phẩm Thành Công!");
                }
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
                if(string.IsNullOrEmpty(tb_masp.Text))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
                    return;
                }
                else if(MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "delete from TB_SanPham where MSP = '" + tb_masp.Text + "'";
                    cmd.ExecuteNonQuery();
                    loadData();
                    MessageBox.Show("Xóa sản phẩm thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
