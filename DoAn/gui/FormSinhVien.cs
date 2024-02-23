using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DoAn;

namespace DoAn
{
    public partial class FormSinhVien : Form
    {
        private CXuLySV xulySV = new CXuLySV();
        
        public FormSinhVien()
        {
            InitializeComponent();
        }
        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            hienThi(xulySV.GetSinhVien());
            hienThiLopHoc(xulySV.GetLopHoc);
            txtMaSSV.Focus();
        }
        private void hienThi(List<SinhVien> dsSV)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsSV;
            dgvSV.DataSource = bs;
        }
        private void hienThiLopHoc(List<LopHoc> dslh)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dslh;
            cmbMaLop.DataSource = bs;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            LopHoc lh = xulySV.GetLopHoc[cmbMaLop.SelectedIndex];

            if ((txtMaSSV.Text == "" && txtHoTenSV.Text == "")
                || (txtMaSSV.Text == "" && txtDiaChi.Text == "")
                || (txtHoTenSV.Text == "" && txtDiaChi.Text == "")
                || (txtMaSSV.Text == "" && txtHoTenSV.Text == "" && txtDiaChi.Text == ""))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ.", "Thông báo");
                txtMaSSV.Focus();
            }
            else if (txtMaSSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên.", "Thông báo");
                txtMaSSV.Focus();
            }
            else if (txtHoTenSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thông báo");
                txtHoTenSV.Focus();
            }   
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thông báo");
                txtDiaChi.Focus();
            }    
            else if (dtpNgaySinhSV.Value >= DateTime.Today)
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin ngày sinh.", "Thông báo");
                dtpNgaySinhSV.Focus();
            }    
            else if (rdoNam.Checked == false && rdoNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tinh.", "Thông báo");
            }    
            else
            {
                if (xulySV.kiemMa(txtMaSSV.Text) == false)
                {
                    MessageBox.Show("Mã sinh viên có 10 ký tự, phải bắt đầu bằng DH5xxxxxxx và không có khoảng trắng và ký tự.");
                    txtMaSSV.Focus();
                    return;
                }

                if (xulySV.kiemTen(txtHoTenSV.Text) == false)
                {
                    MessageBox.Show("Vui lòng nhập họ tên không có ký tự và số.");
                    txtHoTenSV.Focus();
                    return;
                }

                if (xulySV.kiemMa(txtMaSSV.Text) == true)
                {
                    if (xulySV.them(new SinhVien(txtMaSSV.Text, txtHoTenSV.Text, dtpNgaySinhSV.Value, rdoNam.Checked, txtDiaChi.Text, lh)) == true)
                    {
                        hienThi(xulySV.GetSinhVien());
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Mã số sinh viên " + txtMaSSV.Text + " đã tồn tại. Không thêm được");
                        txtMaSSV.Focus();
                    }
                }
            }
        }
        private void reset()
        {
            txtMaSSV.Text = "";
            txtHoTenSV.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinhSV.Value = DateTime.Now;
            rdoNam.Checked = false;
            txtMaSSV.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            SinhVien sv = xulySV.tim(txtMaSSV.Text);
            if (txtMaSSV.Text == "")
            {
                MessageBox.Show("không có dữ liệu để xóa.");
                txtMaSSV.Focus();
                return;
            }    
            if (sv == null)
            {
                if (xulySV.xoa(txtMaSSV.Text) == false)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại.");
                    txtMaSSV.Focus();
                }    
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    reset();
                    txtMaSSV.Focus();
                }
                else
                {
                    xulySV.xoa(txtMaSSV.Text);
                    MessageBox.Show("Xóa thành công");
                    txtMaSSV.Focus();
                }
            }
            hienThi(xulySV.GetSinhVien());
            reset();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {   
            LopHoc lh = xulySV.GetLopHoc[cmbMaLop.SelectedIndex];
            if (txtMaSSV.Text == "" || txtHoTenSV.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa.", "Thông báo");
                txtMaSSV.Focus();
                return;
            }
            if (xulySV.kiemTen(txtHoTenSV.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập họ tên không có ký tự và số.");
                txtHoTenSV.Focus();
                return;
            }
            if (xulySV.sua(new SinhVien(txtMaSSV.Text, txtHoTenSV.Text, dtpNgaySinhSV.Value, rdoNam.Checked, txtDiaChi.Text, lh)) == true)
            {
                hienThi(xulySV.GetSinhVien());
                reset();
                txtMaSSV.Focus();
            }
            else
            {
                MessageBox.Show("Mã sinh viên bạn sửa không tồn tại.", "Thông báo.");
                txtMaSSV.Focus();
            }    
        }
        private void dgvSV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSV.SelectedCells.Count > 0)
            {
                txtMaSSV.Text = dgvSV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTenSV.Text = dgvSV.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgaySinhSV.Value = Convert.ToDateTime(dgvSV.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (dgvSV.Rows[e.RowIndex].Cells[3].Value.ToString() == "True") 
                    rdoNam.Checked = true;
                else if (dgvSV.Rows[e.RowIndex].Cells[3].Value.ToString() == "False")
                    rdoNu.Checked = true;
                txtDiaChi.Text = dgvSV.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbMaLop.Text = dgvSV.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        private void txtMaSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}
