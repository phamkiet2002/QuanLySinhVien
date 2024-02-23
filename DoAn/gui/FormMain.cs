using DoAn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            panelChitiet.Visible = false;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            TruyCapDuLieu data = TruyCapDuLieu.khoiTao();
            if (data.docFile("QLSinhVien.dat") == false)
                MessageBox.Show("Không đọc được dữ liệu lên file");

            openForm(new FormTrangChu());
        }
        private void openForm(Form f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(f);

            f.BringToFront();
            f.Show();
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            openForm(new FormTrangChu());
            tabPage1.Text = "Trang chủ";
        }
        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            openForm(new FormSinhVien());
            tabPage1.Text = "Thông tin sinh viên";
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            openForm(new FormGiangVien());
            tabPage1.Text = "Thông tin giảng viên";
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            openForm(new FormMonHoc());
            tabPage1.Text = "Thông tin môn học";
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            openForm(new FormLopHoc());
            tabPage1.Text = "Thông tin lớp học";
        }

        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            TruyCapDuLieu data = TruyCapDuLieu.khoiTao();
            if (data.ghiFile("QLSinhVien.dat") == true)
                MessageBox.Show("Ghi dữ liệu thành công");
            else
                MessageBox.Show("Không ghi được dữ liệu lên file");
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            hienPanel();
            tabPage1.Text = "Chi tiết môn học";
        }
        private void hienPanel()
        {
            if (panelChitiet.Visible == false)
                panelChitiet.Visible = true;
            else
                panelChitiet.Visible = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            openForm(new FormLopHocView());
            tabPage1.Text = "Xem lớp học.";

        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            openForm(new FormTimSV());
            tabPage1.Text = "Tìm sinh viên.";

        }
        private void btbDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FormDangNhap f = new FormDangNhap();
                f.Show();
            }
        }
    }
}
