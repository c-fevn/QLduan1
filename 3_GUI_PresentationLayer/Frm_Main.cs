using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            FrmBanhang frmBanhang = new FrmBanhang();
            frmBanhang.MdiParent = this;
            frmBanhang.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {

            MessageBox.Show("thanhtoan mo", "thông báo");
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {

            MessageBox.Show("khachhang mo", "thông báo");
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            Frm_nhanvien frm_Nhanvien = new Frm_nhanvien();
            frm_Nhanvien.MdiParent = this;
            frm_Nhanvien.Show();
            MessageBox.Show("nhanvien mo", "thông báo");
        }

        private void dịchVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_dichvu frm_Dichvu = new Frm_dichvu();
            frm_Dichvu.MdiParent = this;
            frm_Dichvu.Show();
            MessageBox.Show("nhanvien mo", "thông báo");
        }

        private void loạiDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_loaidichvu frm_Loaidichvu = new Frm_loaidichvu();
            frm_Loaidichvu.MdiParent = this;
            frm_Loaidichvu.Show();
            MessageBox.Show("nhanvien mo", "thông báo");
        }
    }
}
