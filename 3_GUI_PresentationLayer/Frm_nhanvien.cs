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
    public partial class Frm_nhanvien : Form
    {
        IBUSnhanvien _BUSnhanviens;
        public Frm_nhanvien()
        {
            InitializeComponent();
            _BUSnhanviens = new BUSnhanvien();
            loadnhanvien();
            rbt_nhanvien.Checked = true;
            cbx_hoatdong.Checked = true;
        }
        void loadnhanvien() {
            dataGridView1.ColumnCount = 8; 
            dataGridView1.Columns[0].Name = "Mã Nhân Viên";
            dataGridView1.Columns[1].Name = "Tên nhân viên";
            dataGridView1.Columns[2].Name = "Email";
            dataGridView1.Columns[3].Name = "Mật Khẩu";
            dataGridView1.Columns[4].Name = "SĐT";
            dataGridView1.Columns[5].Name = "Địa Chỉ";
            dataGridView1.Columns[6].Name = "Vai tro";
            dataGridView1.Columns[7].Name = "Trạng Thái";
            dataGridView1.Rows.Clear();
            foreach(var x in _BUSnhanviens.getnhanvien())
            {
                dataGridView1.Rows.Add(x.Manhanvien, x.Tennhanvien, x.Email, x.Matkhau, x.Sdt, x.Diachi, x.Vaitro == 0 ? "nhan vien" : "quan ly", x.Trangthai); ;
            }
        }
        
        

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_diachi.Text == "" || txt_email.Text == "" || txt_manv.Text == "" || txt_mk.Text == "" || txt_sdt.Text == "" || txt_tennv.Text == "")
            { MessageBox.Show("chưa nhap du lieu?", "Thông báo"); return; };
            if (checkma() == true)// bắt buộc phải có dữ liệu trước mới chạy được checkma()
            { MessageBox.Show("ma nhanvien da ton tai", "Thông báo"); return; }
            if (checkmal()==true)// bắt buộc phải có dữ liệu trước mới chạy được checkma()
            { MessageBox.Show("email nhanvien da ton tai", "Thông báo"); return; }
            
            Nhanvien nv = new Nhanvien();
                nv.Manhanvien = txt_manv.Text;
                nv.Tennhanvien = txt_tennv.Text;
                nv.Email = txt_email.Text;
                nv.Matkhau = txt_mk.Text;
                nv.Diachi = txt_diachi.Text;
                nv.Sdt = txt_sdt.Text;
                if (rbt_nhanvien.Checked == true) { nv.Vaitro = 0; };
                if (rbt_qtri.Checked == true) { nv.Vaitro = 1; };
                if (cbx_hoatdong.Checked == true) { nv.Trangthai = "hoatdong"; };
                if (cbx_khonghoatdong.Checked == true) { nv.Trangthai = "ngunghd"; };
                _BUSnhanviens.ThemNhanvien(nv);
                MessageBox.Show("them thanh cong ", "thông báo ");
                return;
            
        }
        bool checkma()
        {
            foreach (var x in _BUSnhanviens.getnhanvien())
            {
                if (x.Manhanvien == txt_manv.Text)
                {
                    return true;
                }
            }
            return false;
        }
        bool checkmal()
        {
            foreach (var x in _BUSnhanviens.getnhanvien())
            {
                if (x.Email == txt_email.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(checkma()==false){ MessageBox.Show("ma nhanvien khong ton tai", "Thông báo"); return; }
            if(checkmal()==true){ MessageBox.Show("email nhanvien da ton tai", "Thông báo"); return; }
                    var manv2 = _BUSnhanviens.getnhanvien().Where(c => c.Manhanvien == txt_manv.Text).FirstOrDefault();
                    manv2.Tennhanvien = txt_tennv.Text;
                    manv2.Email = txt_email.Text;
                    manv2.Matkhau = txt_mk.Text;
                    manv2.Sdt = txt_sdt.Text;
                    if (rbt_nhanvien.Checked == true) { manv2.Vaitro = 0; };
                    if (rbt_qtri.Checked == true) { manv2.Vaitro = 1; };
                    if (cbx_hoatdong.Checked == true) { manv2.Trangthai = "hoatdong"; };
                    if (cbx_khonghoatdong.Checked == true) { manv2.Trangthai = "ngunghd"; };
                    _BUSnhanviens.SuaNhanvien(manv2);
                    MessageBox.Show("sua thanh cong ", "thông báo");
                    return;
                
            
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            DialogResult hoi = MessageBox.Show("xóa se doi thanh ngừng hoatdong?", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.No)
            {
                if (checkma() == false) { MessageBox.Show("ma dichvu khong ton tai", "Thông báo"); return; }
                if (checkma() == false) { MessageBox.Show("ma nhanvien khong ton tai", "Thông báo"); return; }
            _BUSnhanviens.XoaNhanvien(txt_manv.Text);
            MessageBox.Show("xoa thanh cong ", "thông báo ");
            }
            else
            {
                if (checkma() == false) { MessageBox.Show("ma dichvu khong ton tai", "Thông báo"); return; }
                suanv();
                MessageBox.Show("xoa thanh cong ", "thông báo ");
            }

        }
        void suanv()
        {
            if (checkma() == false) { MessageBox.Show("ma nhanvien khong ton tai", "Thông báo"); return; }
            if (checkmal() == true) { MessageBox.Show("email nhanvien da ton tai", "Thông báo"); return; }
            var manv2 = _BUSnhanviens.getnhanvien().Where(c => c.Manhanvien == txt_manv.Text).FirstOrDefault();
            manv2.Tennhanvien = txt_tennv.Text;
            manv2.Email = txt_email.Text;
            manv2.Matkhau = txt_mk.Text;
            manv2.Sdt = txt_sdt.Text;
            if (rbt_nhanvien.Checked == true) { manv2.Vaitro = 0; };
            if (rbt_qtri.Checked == true) { manv2.Vaitro = 1; };
            manv2.Trangthai = "ngunghd"; 
            _BUSnhanviens.SuaNhanvien(manv2);
            MessageBox.Show("sua thanh cong ", "thông báo");
            return;

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

            _BUSnhanviens.SaveNhanvien();
            MessageBox.Show("luu thanh cong ", "thông báo");
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            loadnhanvien();
            MessageBox.Show("load nhanvien thanh cong ", "thông báo");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == _BUSnhanviens.getnhanvien().Count || rowindex == -1) return;
            txt_manv.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            txt_tennv.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            txt_email.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            txt_mk.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            txt_sdt.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            txt_diachi.Text = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
            string vt, tt;
            vt = dataGridView1.Rows[rowindex].Cells[6].Value.ToString();
            tt = dataGridView1.Rows[rowindex].Cells[7].Value.ToString();
            if (vt =="nhanvien" ) { rbt_nhanvien.Checked = true; rbt_qtri.Checked = false; }
            if (vt == "quanly") { rbt_qtri.Checked = true; rbt_nhanvien.Checked = false; }
            if (tt == "hoatdong")
            {
                cbx_hoatdong.Checked = true;
            }
            if (tt == "ngunghd")
            {
                cbx_khonghoatdong.Checked = true;
            }
        }
        void loadnhanvien(string ten)
        {
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Mã Nhân Viên";
            dataGridView1.Columns[1].Name = "Tên nhân viên";
            dataGridView1.Columns[2].Name = "Email";
            dataGridView1.Columns[3].Name = "Mật Khẩu";
            dataGridView1.Columns[4].Name = "SĐT";
            dataGridView1.Columns[5].Name = "Địa Chỉ";
            dataGridView1.Columns[6].Name = "Vai tro";
            dataGridView1.Columns[7].Name = "Trạng Thái";
            dataGridView1.Rows.Clear();
            foreach (var x in _BUSnhanviens.getnhanvien().Where(c=>c.Tennhanvien.StartsWith(ten)))
            {
                dataGridView1.Rows.Add(x.Manhanvien, x.Tennhanvien, x.Email, x.Matkhau, x.Sdt, x.Diachi, x.Vaitro == 0 ? "nhan vien" : "quan ly", x.Trangthai);
            }
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            loadnhanvien(txt_timkiem.Text);
        }

        private void btn_đong_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("đóng thanh cong ", "thông báo");
        }

       
        private void cbx_hoatdong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_hoatdong.Checked)
            {
                cbx_khonghoatdong.Checked = false;
            }
        }

        private void cbx_khonghoatdong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_khonghoatdong.Checked)
            {
                cbx_hoatdong.Checked = false;
            }
        }

        private void Frm_nhanvien_Load(object sender, EventArgs e)
        {
        }

    }
}
