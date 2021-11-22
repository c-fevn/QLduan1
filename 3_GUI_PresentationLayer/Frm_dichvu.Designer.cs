
namespace _3_GUI_PresentationLayer
{
    partial class Frm_dichvu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbx_chonldv = new System.Windows.Forms.ComboBox();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_danhsach = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_giadv = new System.Windows.Forms.TextBox();
            this.txt_madv = new System.Windows.Forms.TextBox();
            this.txt_tendv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datengaysudung = new System.Windows.Forms.DateTimePicker();
            this.rdo_hoatdong = new System.Windows.Forms.RadioButton();
            this.rdo_ngunghd = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_chonldv
            // 
            this.cbx_chonldv.FormattingEnabled = true;
            this.cbx_chonldv.Location = new System.Drawing.Point(185, 54);
            this.cbx_chonldv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_chonldv.Name = "cbx_chonldv";
            this.cbx_chonldv.Size = new System.Drawing.Size(150, 23);
            this.cbx_chonldv.TabIndex = 64;
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(737, 435);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.TabIndex = 62;
            this.btn_dong.Text = "ĐÓNG";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_danhsach
            // 
            this.btn_danhsach.Location = new System.Drawing.Point(618, 435);
            this.btn_danhsach.Name = "btn_danhsach";
            this.btn_danhsach.Size = new System.Drawing.Size(87, 23);
            this.btn_danhsach.TabIndex = 61;
            this.btn_danhsach.Text = "DANH SÁCH";
            this.btn_danhsach.UseVisualStyleBackColor = true;
            this.btn_danhsach.Click += new System.EventHandler(this.btn_danhsach_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(499, 435);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(75, 23);
            this.btn_boqua.TabIndex = 60;
            this.btn_boqua.Text = "LOAD";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(391, 435);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 59;
            this.btn_luu.Text = "LƯU";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(287, 435);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 58;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(185, 435);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 57;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(81, 435);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 56;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(538, 383);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 63;
            this.btn_timkiem.Text = "TÌM KIẾM";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(844, 176);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(299, 383);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(204, 23);
            this.txt_timkiem.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "TRẠNG THÁI";
            // 
            // txt_giadv
            // 
            this.txt_giadv.Location = new System.Drawing.Point(185, 151);
            this.txt_giadv.Name = "txt_giadv";
            this.txt_giadv.Size = new System.Drawing.Size(150, 23);
            this.txt_giadv.TabIndex = 50;
            // 
            // txt_madv
            // 
            this.txt_madv.Location = new System.Drawing.Point(185, 84);
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.Size = new System.Drawing.Size(150, 23);
            this.txt_madv.TabIndex = 49;
            // 
            // txt_tendv
            // 
            this.txt_tendv.Location = new System.Drawing.Point(185, 117);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(150, 23);
            this.txt_tendv.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "NGÀY SỬ DỤNG DV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "LOẠI DỊCH VỤ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Giá Dịch Vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "TÊN DỊCH VỤ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "MÃ DỊCH VỤ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(380, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "DỊCH VỤ";
            // 
            // datengaysudung
            // 
            this.datengaysudung.CustomFormat = "yyyy/mm/dd";
            this.datengaysudung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaysudung.Location = new System.Drawing.Point(566, 62);
            this.datengaysudung.Name = "datengaysudung";
            this.datengaysudung.Size = new System.Drawing.Size(200, 23);
            this.datengaysudung.TabIndex = 65;
            this.datengaysudung.Value = new System.DateTime(2021, 11, 22, 0, 41, 2, 0);
            // 
            // rdo_hoatdong
            // 
            this.rdo_hoatdong.AutoSize = true;
            this.rdo_hoatdong.Location = new System.Drawing.Point(538, 132);
            this.rdo_hoatdong.Name = "rdo_hoatdong";
            this.rdo_hoatdong.Size = new System.Drawing.Size(82, 19);
            this.rdo_hoatdong.TabIndex = 66;
            this.rdo_hoatdong.TabStop = true;
            this.rdo_hoatdong.Text = "Hoạt động";
            this.rdo_hoatdong.UseVisualStyleBackColor = true;
            // 
            // rdo_ngunghd
            // 
            this.rdo_ngunghd.AutoSize = true;
            this.rdo_ngunghd.Location = new System.Drawing.Point(672, 130);
            this.rdo_ngunghd.Name = "rdo_ngunghd";
            this.rdo_ngunghd.Size = new System.Drawing.Size(120, 19);
            this.rdo_ngunghd.TabIndex = 67;
            this.rdo_ngunghd.TabStop = true;
            this.rdo_ngunghd.Text = "Ngừng hoạt động";
            this.rdo_ngunghd.UseVisualStyleBackColor = true;
            // 
            // Frm_dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 485);
            this.Controls.Add(this.rdo_ngunghd);
            this.Controls.Add(this.rdo_hoatdong);
            this.Controls.Add(this.datengaysudung);
            this.Controls.Add(this.cbx_chonldv);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_danhsach);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_giadv);
            this.Controls.Add(this.txt_madv);
            this.Controls.Add(this.txt_tendv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_dichvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_dichvu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_chonldv;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_danhsach;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_giadv;
        private System.Windows.Forms.TextBox txt_madv;
        private System.Windows.Forms.TextBox txt_tendv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datengaysudung;
        private System.Windows.Forms.RadioButton rdo_hoatdong;
        private System.Windows.Forms.RadioButton rdo_ngunghd;
    }
}