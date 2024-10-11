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
        string str = "Data Source=LAPTOP-NNG5TEB9\\SQLEXPRESS;Initial Catalog=QLCHSua;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from SP";
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
            tb_masp.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_hangsx.Text = dgv.Rows[i].Cells[1].Value.ToString();
            dtime_hsd.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_mota.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tb_gia.Text = dgv.Rows[i].Cells[4].Value.ToString();
            tb_soluong.Text = dgv.Rows[i].Cells[5].Value.ToString();
            tb_loaisp.Text = dgv.Rows[i].Cells[6].Value.ToString();
        }

        private void nut_them_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "insert into SP values('" + tb_masp.Text + "', '" + tb_hangsx.Text + "', '" + dtime_hsd.Text + "', '" + tb_mota.Text + "', '" + tb_gia.Text + "', '"+tb_soluong.Text+"', '"+tb_loaisp.Text+"')";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void nut_sua_Click(object sender, EventArgs e)
        {

            cmd = connection.CreateCommand();
            cmd.CommandText = "update SP set HangSX = '" + tb_hangsx.Text + "', HSD = '" + dtime_hsd.Text + "', MoTa = '" + tb_mota.Text + "', Gia = '" + tb_gia.Text + "', SoLuong = '"+tb_soluong.Text +"', LoaiSP = '"+tb_loaisp.Text+"' where MaSP = '" + tb_masp.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void nut_xoa_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "delete from SP where MaSP = '" + tb_masp.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
        }
    }
}
