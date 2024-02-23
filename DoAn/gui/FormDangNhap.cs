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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" && txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
                txtTenDangNhap.Focus();
                return;
            }
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập.");
                txtTenDangNhap.Focus();
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu.");
                txtMatKhau.Focus();
                return;
            }
            if (kiemTra(txtTenDangNhap.Text, txtMatKhau.Text) == false)
            {
                MessageBox.Show("sai tên đăng nhập hoặc mật khẩu.");
                txtTenDangNhap.Focus();
                return;
            }    
            FormMain f = new FormMain();
            f.ShowDialog();
            this.Hide();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool kiemTra(string tenTK, string tenMK)
        {
            if(tenTK=="Admin" && tenMK== "admin")
                return true;
            return false;
        }
        private void btnDangNhap_MouseHover(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.PeachPuff;
        }
        private void btnDangNhap_MouseLeave(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.WhiteSmoke;
        }
        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.WhiteSmoke;
            
        }
        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.PeachPuff;
        }
    }
}
