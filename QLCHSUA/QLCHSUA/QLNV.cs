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
        string str = "Data Source=LAPTOP-NNG5TEB9\\SQLEXPRESS;Initial Catalog=QLCHSua;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from QLNV";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public QLNV()
        {
            InitializeComponent();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void nut_them_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "insert into QLNV values('" + tb_manv.Text + "', '" + tb_tennv.Text + "', '" + tb_sdt.Text + "', '" + tb_diachi.Text + "', '"+dtime_ngaysinh.Text+"')";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentCell.RowIndex;
            tb_manv.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_tennv.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_sdt.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_diachi.Text = dgv.Rows[i].Cells[3].Value.ToString();
            dtime_ngaysinh.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void nut_sua_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "update QLNV set HoTen = '" + tb_tennv.Text + "', SDT = '" + tb_sdt.Text + "', DiaChi = '" + tb_diachi.Text + "', NgaySinh = '"+dtime_ngaysinh.Text+"' where MaNV = '" + tb_manv.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void nut_xoa_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "delete from QLNV where MaNV = '" + tb_manv.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
        }
    }
}
