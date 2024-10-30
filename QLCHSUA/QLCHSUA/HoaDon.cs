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
    public partial class HoaDon : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-8DCO9H8;Initial Catalog=ChiNhanhSua;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from HoaDon";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "insert into HoaDon values('" + tb_mahd.Text + "', '" + tb_manv.Text + "', '" + tb_makh.Text + "', '" + tb_masp.Text + "', '" + dtime_ngayban.Text + "', '"+tb_tongtien.Text+"')";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "update HoaDon set MaNV = '" + tb_manv.Text + "', MaKH = '" + tb_makh.Text + "', MaSP = '" + tb_masp.Text + "', NgayBan = '" + dtime_ngayban.Text + "', TongTien = '"+tb_tongtien.Text+"' where MaHD = '" + tb_mahd.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentCell.RowIndex;
            tb_mahd.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_manv.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_makh.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_masp.Text = dgv.Rows[i].Cells[3].Value.ToString();
            dtime_ngayban.Text = dgv.Rows[i].Cells[4].Value.ToString();
            tb_tongtien.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "delete from HoaDon where MaHD = '" + tb_mahd.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
        }
    }
}
