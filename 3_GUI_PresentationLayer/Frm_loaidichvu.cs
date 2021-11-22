using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IBUSService;
using _2_BUS_BusinessLayer.BUSService;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_loaidichvu : Form
    {
        IBUSloaidichvu _BUSloaidichvus;
        public Frm_loaidichvu()
        {
            InitializeComponent();
            _BUSloaidichvus = new BUSloaidichvu();
            rbxhd.Checked = true;
            loadloaidv();
        }
        void loadloaidv()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Mã loai dich vu";
            dataGridView1.Columns[1].Name = "Tên loai dich vu";
            dataGridView1.Columns[2].Name = "trang thai";
            dataGridView1.Rows.Clear();
            foreach(var x in _BUSloaidichvus.getLoaidichvu())
            {
                dataGridView1.Rows.Add(x.Maloaidichvu, x.Tenloaidichvu, x.Trangthai);
            };
        }

        private void Frm_loaidichvu_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == _BUSloaidichvus.getLoaidichvu().Count || rowindex == -1) return;
            txt_maloaidv.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            txt_tenloaidv.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            string tt;
            tt= dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            if (tt == "hoatdong")
            {
                rbxhd.Checked = true;
            }
            if (tt == "ngunghd")
            {
                rbxnhd.Checked = true;
            }
        }
        bool checkma()
        {
            foreach (var x in _BUSloaidichvus.getLoaidichvu())
            {
                if (x.Maloaidichvu == txt_maloaidv.Text)
                {
                    return true;
                }
            }
            return false;
        }
        bool checkten() {
            foreach (var x in _BUSloaidichvus.getLoaidichvu())
            {
                if (x.Tenloaidichvu == txt_tenloaidv.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_maloaidv.Text == "" || txt_tenloaidv.Text == "")
            { MessageBox.Show("chưa nhap du lieu?", "Thông báo"); return; };
            if (checkten() == true) { MessageBox.Show("ten loai dv da có?", "Thông báo"); return; }
            if (checkma()==true)// bắt buộc phải có dữ liệu trước mới chạy được checkma()
            { MessageBox.Show("ma loai dv da ton tai", "Thông báo"); return; }
            Loaidichvu ldv = new Loaidichvu();
                ldv.Maloaidichvu = txt_maloaidv.Text;
                ldv.Tenloaidichvu = txt_tenloaidv.Text;
                if (rbxhd.Checked == true) { ldv.Trangthai = "hoatdong"; };
                if (rbxnhd.Checked == true) { ldv.Trangthai = "ngunghd"; };
                _BUSloaidichvus.ThemLoaidichvu(ldv);
                MessageBox.Show("them thanh cong ", "thông báo ");
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (checkma() == false)// bắt buộc phải có dữ liệu trước mới chạy được checkma()
            { MessageBox.Show("ma loai dv khong ton tai", "Thông báo"); return; };
            if (checkten() == true) { MessageBox.Show("ten loai dv da có?", "Thông báo"); return; }

            var ldv = _BUSloaidichvus.getLoaidichvu().Where(c => c.Maloaidichvu == txt_maloaidv.Text).FirstOrDefault();
            ldv.Tenloaidichvu = txt_tenloaidv.Text;
                if (rbxhd.Checked == true) { ldv.Trangthai = "hoatdong"; };
                if (rbxnhd.Checked == true) { ldv.Trangthai = "ngunghd"; };
                _BUSloaidichvus.SuaLoaidichvu(ldv);
                MessageBox.Show("sua thanh cong ", "thông báo ");
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (checkma() == false)// bắt buộc phải có dữ liệu trước mới chạy được checkma()
            { MessageBox.Show("ma loai dv khong ton tai", "Thông báo"); return; };
            _BUSloaidichvus.XoaLoaidichvu(txt_maloaidv.Text);
            MessageBox.Show("xoa thanh cong ", "thông báo ");

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            _BUSloaidichvus.SaveLoaidichvu();
            MessageBox.Show("luu thanh cong ", "thông báo");
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            loadloaidv();
            MessageBox.Show("load nhanvien thanh cong ", "thông báo");
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {

            this.Hide();
            MessageBox.Show("đóng thanh cong ", "thông báo");
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            loadloaidv(txt_timkiem.Text);
        }
        void loadloaidv(string ten)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Mã loai dich vu";
            dataGridView1.Columns[1].Name = "Tên loai dich vu";
            dataGridView1.Columns[2].Name = "trang thai";
            dataGridView1.Rows.Clear();
            foreach (var x in _BUSloaidichvus.getLoaidichvu().Where(c=>c.Tenloaidichvu.StartsWith(ten)))
            {
                dataGridView1.Rows.Add(x.Maloaidichvu, x.Tenloaidichvu, x.Trangthai);
            };
        }
    }
}
