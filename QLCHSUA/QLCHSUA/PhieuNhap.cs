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
    public partial class PhieuNhap : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-NNG5TEB9\\SQLEXPRESS;Initial Catalog=QLCHSua;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from PhieuNhap";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public PhieuNhap()
        {
            InitializeComponent();
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentCell.RowIndex;
            tb_map.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_manv.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_masp.Text = dgv.Rows[i].Cells[2].Value.ToString();
            dtime_ngaynhap.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tb_tenncc.Text = dgv.Rows[i].Cells[4].Value.ToString();
            tb_tong.Text = dgv.Rows[i].Cells[5].Value.ToString();
        }

        private void nut_them_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "insert into PhieuNhap values('" + tb_map.Text + "', '" + tb_manv.Text + "', '" + tb_masp.Text + "', '" + dtime_ngaynhap.Text + "', '" + tb_tenncc.Text + "', '"+tb_tong.Text+"')";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void nut_sua_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "update PhieuNhap  set MaNV = '"+tb_manv.Text+"', MaSP = '"+tb_masp.Text+"', NgayNhap = '" + dtime_ngaynhap.Text + "', TenNCC = '" + tb_tenncc.Text + "', Tong = '" + tb_tong.Text + "' where MaP = '" + tb_map.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void nut_xoa_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "delete from PhieuNhap where MaP = '" + tb_map.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
        }
    }
}
