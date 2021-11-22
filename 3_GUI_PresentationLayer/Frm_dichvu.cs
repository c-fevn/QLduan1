using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class Frm_dichvu : Form
    {
        IBUSdichvu _BUSdichvus;
        IBUSloaidichvu _BUSloaidichvus;
        string mal;
        public Frm_dichvu()
        {
            InitializeComponent();
            _BUSdichvus = new BUSdichvu();
            _BUSloaidichvus = new BUSloaidichvu();
            rdo_hoatdong.Checked = true;
            loaddichvu();
            combodv();
        }
        void loaddichvu()
        {
            
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "Mã dich vu";
                dataGridView1.Columns[1].Name = "Tên dich vu";
                dataGridView1.Columns[2].Name = "gia dich vu";
                dataGridView1.Columns[3].Name = "ngay sudung DV";
                dataGridView1.Columns[4].Name = "trang thai";
                dataGridView1.Columns[5].Name = "ma loai DV";
                dataGridView1.Rows.Clear();
                foreach (var x in _BUSdichvus.getDichvu())
                {
                    dataGridView1.Rows.Add(x.Madichvu,x.Tendichvu,x.Giadichvu,x.Ngaysudungdichvu ,x.Trangthai,x.Maloaidichvu);
                };
            
        }
        void combodv()
        {
            foreach (var x in _BUSloaidichvus.getLoaidichvu().Select(c=>c.Tenloaidichvu))
            {
                cbx_chonldv.Items.Add(x);
                
            }
            cbx_chonldv.SelectedIndex = 0;
            var loai1 = _BUSloaidichvus.getLoaidichvu().Where(c => c.Tenloaidichvu == cbx_chonldv.Text).Select(c => c.Maloaidichvu).FirstOrDefault();
            mal = Convert.ToString(loai1);
        }
        bool checkma()
        {
            foreach (var x in _BUSdichvus.getDichvu())
            {
                if (x.Madichvu == txt_madv.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_madv.Text == "" || txt_giadv.Text == "" || txt_tendv.Text == "")
            { MessageBox.Show("chưa nhap du lieu?", "Thông báo"); return; };
            if (checkma()==true)// bắt buộc phải có dữ liệu trước mới chạy được checkma()
            { MessageBox.Show("ma dichvu da ton tai", "Thông báo"); return; }
            Dichvu dv = new Dichvu();
                dv.Madichvu = txt_madv.Text;
                dv.Tendichvu = txt_tendv.Text;
                dv.Giadichvu = Convert.ToDecimal(txt_giadv.Text);
                dv.Ngaysudungdichvu = datengaysudung.Value;

            if (rdo_hoatdong.Checked == true) { dv.Trangthai = "hoatdong"; };
            if (rdo_ngunghd.Checked == true) { dv.Trangthai = "ngunghd"; };
            dv.Maloaidichvu = mal;
                _BUSdichvus.ThemDichvu(dv);
                MessageBox.Show("them thanh cong ", "thông báo ");
                return;

            

        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(checkma() == false) { MessageBox.Show("ma dichvu khong ton tai", "Thông báo"); return; }
            var madv1 = _BUSdichvus.getDichvu().Where(c => c.Madichvu == txt_madv.Text).FirstOrDefault();
                madv1.Tendichvu = txt_tendv.Text;
                madv1.Giadichvu = Convert.ToDecimal(txt_giadv.Text);
                madv1.Ngaysudungdichvu = datengaysudung.Value;
            if (rdo_hoatdong.Checked == true) { madv1.Trangthai = "hoatdong"; };
            if (rdo_ngunghd.Checked == true) { madv1.Trangthai = "ngunghd"; };
            madv1.Maloaidichvu = mal;
                _BUSdichvus.SuaDichvu(madv1);
                MessageBox.Show("sua thanh cong ", "thông báo ");
                return;

            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == _BUSdichvus.getDichvu().Count || rowindex == -1) return;
            txt_madv.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            txt_tendv.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            txt_giadv.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            datengaysudung.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            string tt,maloai;
            tt = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            if (tt == "hoatdong")
            {
                rdo_hoatdong.Checked = true;
            }
            if (tt == "ngunghd")
            {
                rdo_ngunghd.Checked = true;
            }
            maloai=dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
            cbx_chonldv.Text = _BUSloaidichvus.getLoaidichvu().Where(c => c.Maloaidichvu == maloai)
                .Select(c => c.Tenloaidichvu).FirstOrDefault();

        }
        
        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (checkma() == false) { MessageBox.Show("ma dichvu khong ton tai", "Thông báo"); return; }
            _BUSdichvus.XoaDichvu(txt_madv.Text);
            MessageBox.Show("xoa thanh cong ", "thông báo ");
        }

        

        private void btn_luu_Click(object sender, EventArgs e)
        {
            _BUSdichvus.SaveDichvu();
            MessageBox.Show("luu thanh cong ", "thông báo");
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            loaddichvu();
            MessageBox.Show("load nhanvien thanh cong ", "thông báo");

        }

        private void btn_danhsach_Click(object sender, EventArgs e)
        {

            loaddichvu();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {

            this.Hide();
            MessageBox.Show("đóng thanh cong ", "thông báo");
        }
        void loaddichvu(string ten)
        {

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Mã dich vu";
            dataGridView1.Columns[1].Name = "Tên dich vu";
            dataGridView1.Columns[2].Name = "gia dich vu";
            dataGridView1.Columns[3].Name = "ngay sudung DV";
            dataGridView1.Columns[4].Name = "trang thai";
            dataGridView1.Columns[5].Name = "ma loai DV";
            dataGridView1.Rows.Clear();
            foreach (var x in _BUSdichvus.getDichvu().Where(c=>c.Tendichvu.StartsWith(ten)))
            {
                dataGridView1.Rows.Add(x.Madichvu, x.Tendichvu, x.Giadichvu, x.Ngaysudungdichvu, x.Trangthai, x.Maloaidichvu);
            };

        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            loaddichvu(txt_timkiem.Text);
        }

        
    }
}
