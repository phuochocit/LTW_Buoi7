using KT_GiuaKy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT_GiuaKy
{
    public partial class frmSinhvien : Form
    {
        public frmSinhvien()
        {
            InitializeComponent();
        }

        private void frmSinhvien_Load(object sender, EventArgs e)
        {
            try
            {
                using (StudentModelContextDB context = new StudentModelContextDB())
                {
                    List<LOP> dsLop = context.LOP.ToList();
                    List<SINHVIEN> dsSinhVien = context.SINHVIEN.ToList();
                    LOPCombobox(dsLop);
                    BindGrid(dsSinhVien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LOPCombobox(List<LOP> dsLop)
        {
            this.cmb_Lop.DataSource = dsLop;
            this.cmb_Lop.DisplayMember = "TENLOP";
            this.cmb_Lop.ValueMember = "MALOP";
        }
        private void BindGrid(List<SINHVIEN> dsSinhVien)
        {
            dgv_sinhVien.Rows.Clear();
            foreach (var item in dsSinhVien)
            {
                int index = dgv_sinhVien.Rows.Add();
                dgv_sinhVien.Rows[index].Cells[0].Value = item.MASV;
                dgv_sinhVien.Rows[index].Cells[1].Value = item.TENSV;
                dgv_sinhVien.Rows[index].Cells[2].Value = item.NGAYSINH;
                dgv_sinhVien.Rows[index].Cells[3].Value = item.LOP.TENLOP;
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                string searchName = txt_timKiem.Text?.Trim();

                using (StudentModelContextDB context = new StudentModelContextDB())
                {
                    var dsSinhVien = context.SINHVIEN.ToList();

                    if (!string.IsNullOrEmpty(searchName))
                    {
                        searchName = searchName.ToLower();
                        var filtered = dsSinhVien.Where(sv => sv.TENSV != null && sv.TENSV.ToLower().Contains(searchName)).ToList();
                        BindGrid(filtered);
                    }
                    else
                    {
                        BindGrid(dsSinhVien); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                using (StudentModelContextDB context = new StudentModelContextDB())
                {
                    string masv = txt_maSV.Text.Trim();
                    var existingSV = context.SINHVIEN.FirstOrDefault(sv => sv.MASV == masv);

                    if (existingSV != null)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại! Vui lòng nhập mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    SINHVIEN newSV = new SINHVIEN
                    {
                        MASV = masv,
                        TENSV = txt_hoTen.Text.Trim(),
                        NGAYSINH = date_ngaySinh.Value,
                        MALOP = cmb_Lop.SelectedValue.ToString()
                    };

                    context.SINHVIEN.Add(newSV);
                    context.SaveChanges();

                    MessageBox.Show("Thêm sinh viên mới thành công!");
                    BindGrid(context.SINHVIEN.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (StudentModelContextDB context = new StudentModelContextDB())
                {
                    string masv = txt_maSV.Text.Trim();
                    var sv = context.SINHVIEN.FirstOrDefault(s => s.MASV == masv);

                    if (sv != null)
                    {
                        context.SINHVIEN.Remove(sv);
                        context.SaveChanges();
                        MessageBox.Show("Xóa sinh viên thành công!");
                        BindGrid(context.SINHVIEN.ToList());
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên để xóa!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                using (StudentModelContextDB context = new StudentModelContextDB())
                {
                    string masv = txt_maSV.Text.Trim();
                    var existingSV = context.SINHVIEN.FirstOrDefault(sv => sv.MASV == masv);

                    if (existingSV != null)
                    {
                        // Nếu sinh viên đã tồn tại, cập nhật thông tin
                        existingSV.TENSV = txt_hoTen.Text.Trim();
                        existingSV.NGAYSINH = date_ngaySinh.Value;
                        existingSV.MALOP = cmb_Lop.SelectedValue.ToString();
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
                        BindGrid(context.SINHVIEN.ToList());
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên để sửa!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin sinh viên: " + ex.Message);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                using (StudentModelContextDB context = new StudentModelContextDB())
                {
                    string masv = txt_maSV.Text.Trim();
                    var existingSV = context.SINHVIEN.FirstOrDefault(sv => sv.MASV == masv);

                    if (existingSV == null)
                    {
                        MessageBox.Show("Không tìm thấy sinh viên để lưu! Hãy sử dụng chức năng Thêm nếu đây là sinh viên mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    existingSV.TENSV = txt_hoTen.Text.Trim();
                    existingSV.NGAYSINH = date_ngaySinh.Value;
                    existingSV.MALOP = cmb_Lop.SelectedValue.ToString();

                    context.SaveChanges();

                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
                    BindGrid(context.SINHVIEN.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu thông tin sinh viên: " + ex.Message);
            }
        }

        private void btn_KLuu_Click(object sender, EventArgs e)
        {
            txt_maSV.Text = "";
            txt_hoTen.Text = "";
            date_ngaySinh.Value = DateTime.Now;
            cmb_Lop.SelectedIndex = -1;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgv_sinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_sinhVien.Rows[e.RowIndex];
                txt_maSV.Text = row.Cells[0].Value.ToString();
                txt_hoTen.Text = row.Cells[1].Value.ToString();
                date_ngaySinh.Text = row.Cells[2].Value.ToString();
                cmb_Lop.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
