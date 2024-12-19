namespace KT_GiuaKy
{
    partial class frmSinhvien
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
            this.gr_thongTin = new System.Windows.Forms.GroupBox();
            this.date_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.cmb_Lop = new System.Windows.Forms.ComboBox();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.txt_maSV = new System.Windows.Forms.TextBox();
            this.lbl_Lop = new System.Windows.Forms.Label();
            this.lbl_hoTen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_maSV = new System.Windows.Forms.Label();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_KLuu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_sinhVien = new System.Windows.Forms.DataGridView();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr_thongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gr_thongTin
            // 
            this.gr_thongTin.Controls.Add(this.date_ngaySinh);
            this.gr_thongTin.Controls.Add(this.cmb_Lop);
            this.gr_thongTin.Controls.Add(this.txt_hoTen);
            this.gr_thongTin.Controls.Add(this.txt_maSV);
            this.gr_thongTin.Controls.Add(this.lbl_Lop);
            this.gr_thongTin.Controls.Add(this.lbl_hoTen);
            this.gr_thongTin.Controls.Add(this.label4);
            this.gr_thongTin.Controls.Add(this.lbl_maSV);
            this.gr_thongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_thongTin.Location = new System.Drawing.Point(148, 12);
            this.gr_thongTin.Name = "gr_thongTin";
            this.gr_thongTin.Size = new System.Drawing.Size(634, 179);
            this.gr_thongTin.TabIndex = 0;
            this.gr_thongTin.TabStop = false;
            this.gr_thongTin.Text = "THÔNG TIN CHI TIẾT";
            // 
            // date_ngaySinh
            // 
            this.date_ngaySinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ngaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ngaySinh.Location = new System.Drawing.Point(102, 134);
            this.date_ngaySinh.Name = "date_ngaySinh";
            this.date_ngaySinh.Size = new System.Drawing.Size(200, 24);
            this.date_ngaySinh.TabIndex = 0;
            // 
            // cmb_Lop
            // 
            this.cmb_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Lop.FormattingEnabled = true;
            this.cmb_Lop.Location = new System.Drawing.Point(394, 131);
            this.cmb_Lop.Name = "cmb_Lop";
            this.cmb_Lop.Size = new System.Drawing.Size(223, 26);
            this.cmb_Lop.TabIndex = 0;
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoTen.Location = new System.Drawing.Point(394, 38);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(223, 24);
            this.txt_hoTen.TabIndex = 0;
            // 
            // txt_maSV
            // 
            this.txt_maSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maSV.Location = new System.Drawing.Point(119, 38);
            this.txt_maSV.Name = "txt_maSV";
            this.txt_maSV.Size = new System.Drawing.Size(121, 24);
            this.txt_maSV.TabIndex = 0;
            // 
            // lbl_Lop
            // 
            this.lbl_Lop.AutoSize = true;
            this.lbl_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lop.Location = new System.Drawing.Point(343, 139);
            this.lbl_Lop.Name = "lbl_Lop";
            this.lbl_Lop.Size = new System.Drawing.Size(33, 18);
            this.lbl_Lop.TabIndex = 0;
            this.lbl_Lop.Text = "Lớp";
            // 
            // lbl_hoTen
            // 
            this.lbl_hoTen.AutoSize = true;
            this.lbl_hoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoTen.Location = new System.Drawing.Point(315, 44);
            this.lbl_hoTen.Name = "lbl_hoTen";
            this.lbl_hoTen.Size = new System.Drawing.Size(52, 18);
            this.lbl_hoTen.TabIndex = 0;
            this.lbl_hoTen.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // lbl_maSV
            // 
            this.lbl_maSV.AutoSize = true;
            this.lbl_maSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maSV.Location = new System.Drawing.Point(23, 44);
            this.lbl_maSV.Name = "lbl_maSV";
            this.lbl_maSV.Size = new System.Drawing.Size(90, 18);
            this.lbl_maSV.TabIndex = 0;
            this.lbl_maSV.Text = "Mã sinh viên";
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timKiem.Location = new System.Drawing.Point(12, 212);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(180, 24);
            this.txt_timKiem.TabIndex = 0;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(198, 197);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(93, 57);
            this.btn_Tim.TabIndex = 2;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_KLuu);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Location = new System.Drawing.Point(297, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 57);
            this.panel1.TabIndex = 3;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(408, 9);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 39);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(246, 9);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 39);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(84, 9);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 39);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "Xóa ";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_KLuu
            // 
            this.btn_KLuu.Location = new System.Drawing.Point(327, 9);
            this.btn_KLuu.Name = "btn_KLuu";
            this.btn_KLuu.Size = new System.Drawing.Size(75, 39);
            this.btn_KLuu.TabIndex = 0;
            this.btn_KLuu.Text = "K. Lưu";
            this.btn_KLuu.UseVisualStyleBackColor = true;
            this.btn_KLuu.Click += new System.EventHandler(this.btn_KLuu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(165, 9);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 39);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(3, 9);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 39);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_sinhVien
            // 
            this.dgv_sinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.tenSV,
            this.ngaySinh,
            this.lop});
            this.dgv_sinhVien.Location = new System.Drawing.Point(12, 260);
            this.dgv_sinhVien.Name = "dgv_sinhVien";
            this.dgv_sinhVien.RowHeadersWidth = 51;
            this.dgv_sinhVien.RowTemplate.Height = 24;
            this.dgv_sinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sinhVien.Size = new System.Drawing.Size(907, 292);
            this.dgv_sinhVien.TabIndex = 4;
            this.dgv_sinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sinhVien_CellClick);
            // 
            // maSV
            // 
            this.maSV.HeaderText = "Mã SV";
            this.maSV.MinimumWidth = 6;
            this.maSV.Name = "maSV";
            this.maSV.Width = 125;
            // 
            // tenSV
            // 
            this.tenSV.HeaderText = "Họ và tên";
            this.tenSV.MinimumWidth = 6;
            this.tenSV.Name = "tenSV";
            this.tenSV.Width = 125;
            // 
            // ngaySinh
            // 
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Width = 125;
            // 
            // lop
            // 
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 125;
            // 
            // frmSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 564);
            this.Controls.Add(this.dgv_sinhVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.gr_thongTin);
            this.Controls.Add(this.txt_timKiem);
            this.Name = "frmSinhvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.frmSinhvien_Load);
            this.gr_thongTin.ResumeLayout(false);
            this.gr_thongTin.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_thongTin;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.Label lbl_hoTen;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_maSV;
        private System.Windows.Forms.DateTimePicker date_ngaySinh;
        private System.Windows.Forms.ComboBox cmb_Lop;
        private System.Windows.Forms.Label lbl_Lop;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_KLuu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_maSV;
        private System.Windows.Forms.DataGridView dgv_sinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
    }
}

