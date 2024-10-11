using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHSUA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLNV qLNV = new QLNV();
            qLNV.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PhieuNhap phieuNhap = new PhieuNhap();
            phieuNhap.Show();
        }

        private void qlkh_Click(object sender, EventArgs e)
        {
            QLKH qLKH = new QLKH();
            qLKH.Show();
        }

        private void qlsp_Click(object sender, EventArgs e)
        {
            SP sP = new SP();
            sP.Show();
        }

        private void qlhd_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.Show();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNV qLNV = new QLNV();
            qLNV.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKH qLKH = new QLKH();
            qLKH.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SP sP = new SP();
            sP.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.Show();
        }

        private void quảnLýPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuNhap phieuNhap = new PhieuNhap();
            phieuNhap.Show();
        }
    }
}
