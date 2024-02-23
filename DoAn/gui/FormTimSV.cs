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
    public partial class FormTimSV : Form
    {
        private CXuLySV xl = new CXuLySV();
        private CXuLyLH xllh = new CXuLyLH();
        private void hienThi(List<LopHoc> dsLH)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsLH;
            dgvLopHoc.DataSource = bs;
        }
        public FormTimSV()
        {
            InitializeComponent();
        }
        private void FormTimSV_Load(object sender, EventArgs e)
        {
            txtMASV.Focus();
        }
        private void addDS(SinhVien sv)
        {
            List<LopHoc> dslh = new List<LopHoc>();
            LopHoc lh = xllh.tim(sv.lophoc.MaLop);
            if (lh != null)
            {
                dslh.Add(lh);
            }
            hienThi(dslh);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if(txtMASV.Text =="")
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên cần tìm.");
                txtMASV.Focus();
                return;
            }
            SinhVien sv = xl.tim(txtMASV.Text);
            if (sv != null)
            {
                lblma.Text = sv.MaSV;
                lblten.Text = sv.HoTen;
                lblngay.Text = sv.NgaySinh.ToString();
                if (sv.Phai == true)
                    lbphai.Text = "Nam";
                else
                    lbphai.Text = "Nữ";
                lbldc.Text = sv.DiaChi;
                addDS(sv);
                txtMASV.Text = "";
                txtMASV.Focus();
            }
            else
            {
                MessageBox.Show("Không có mã số sinh viên cần tìm.");
                txtMASV.Focus();
            }
        }

        private void txtMASV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}
