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
    public partial class FormLopHoc : Form
    {
        private CXuLyLH xuLy = new CXuLyLH();
        public FormLopHoc()
        {
            InitializeComponent();
        }
        private void FormLopHoc_Load(object sender, EventArgs e)
        {
            hienThi(xuLy.GetLopHoc());
            txtMaLop.Focus();
        }
        private void hienThi(List<LopHoc> dsLH)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsLH;
            dgvLopHoc.DataSource = bs;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            LopHoc lh = new LopHoc();
            lh.MaLop = txtMaLop.Text;
            lh.TenLop = txtTenLop.Text;
            if (txtMaLop.Text == "" && txtTenLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ.", "Thông báo");
                txtMaLop.Focus();
            }    
            else if (txtMaLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã lớp học.", "Thông báo");
                txtMaLop.Focus();
            }    
            else if (txtTenLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên lớp học.", "Thông báo");
                txtTenLop.Focus();
            }    
            else
            {
                if (xuLy.kiemMa(txtMaLop.Text) == false)
                {
                    MessageBox.Show("Mã lớp học có 4 ký tự, phải bắt đầu bằng Cxxx và không có khoảng trắng và ký tự.");
                    txtMaLop.Focus();
                    return;
                }

                if (xuLy.kiemTen(txtTenLop.Text) == false)
                {
                    MessageBox.Show("Vui lòng nhập tên lớp học không có ký tự và số.");
                    txtMaLop.Focus();
                    return;
                }
                if (xuLy.them(lh) == true)
                {
                    hienThi(xuLy.GetLopHoc());
                    reset();
                }
                else
                {
                    MessageBox.Show("Mã số lớp học " + lh.MaLop + " đã tồn tại. Không thêm được");
                    txtMaLop.Focus();
                }    
            }
        }
        private void reset()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            LopHoc lh = xuLy.tim(txtMaLop.Text);
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("không có dữ liệu để xóa.");
                txtMaLop.Focus();
                return;
            }
            if (lh == null)
            {
                if (xuLy.xoa(txtMaLop.Text) == false)
                {
                    MessageBox.Show("không có dữ liệu để xóa");
                    txtMaLop.Focus();
                }    
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    reset();
                }
                else
                {
                    xuLy.xoa(txtMaLop.Text);
                    MessageBox.Show("Xóa thành công");
                }
            }
            hienThi(xuLy.GetLopHoc());
            reset();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            LopHoc lh = new LopHoc();
            lh.MaLop = txtMaLop.Text;
            lh.TenLop = txtTenLop.Text;
            if (txtMaLop.Text == "" || txtTenLop.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa đầy đủ.", "Thông báo");
                return;
            }

            if (xuLy.kiemTen(txtTenLop.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập tên lớp học không có ký tự và số.");
                txtMaLop.Focus();
                return;
            }
            if (xuLy.sua(lh) == true)
                hienThi(xuLy.GetLopHoc());
            else
                MessageBox.Show("Mã lớp học không tồn tại.");
            reset();
        }
        private void dgvLopHoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvLopHoc.SelectedCells.Count > 0)
            {
                txtMaLop.Text = dgvLopHoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenLop.Text= dgvLopHoc.Rows[e.RowIndex].Cells[1].Value.ToString();
            }    
        }

        private void txtMaLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}
