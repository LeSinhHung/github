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
        string str = "Data Source=LAPTOP-NNG5TEB9\\SQLEXPRESS;Initial Catalog=QLCHSua;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from QLKH";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

            public QLKH()
        {
            InitializeComponent();
        }

        private void QLKH_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentCell.RowIndex;
            tb_makh.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_ten.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_sdt.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_diachi.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void nut_them_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "insert into QLKH values('" + tb_makh.Text+"', '"+tb_ten.Text+"', '"+tb_sdt.Text+"', '"+tb_diachi.Text+"')";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void nut_xoa_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "delete from QLKH where MaKH = '"+tb_makh.Text+"'";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void nut_sua_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "update QLKH set HoTen = '"+tb_ten.Text+"', SDT = '"+tb_sdt.Text+"', DiaChi = '"+tb_diachi.Text+"' where MaKH = '"+tb_makh.Text+"'";
            cmd.ExecuteNonQuery();  
            loadData();
        }
    }
}
