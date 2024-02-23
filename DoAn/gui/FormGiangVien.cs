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
    public partial class FormGiangVien : Form
    {
        private CXuLyGV xuly = new CXuLyGV();
        public FormGiangVien()
        {
            InitializeComponent();
        }
        private void FormGiangVien_Load(object sender, EventArgs e)
        {
            hienThi(xuly.GetGiangVien());
            txtMaGV.Focus();
        }
        private void hienThi(List<GiangVien> dsGV)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsGV;
            dgvGV.DataSource = bs;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien();
            gv.MaGiangVien = txtMaGV.Text;
            gv.HoTenGiangVien = txtHoTenGV.Text;
            gv.Phai = rdoNam.Checked;
            if (txtMaGV.Text == "" && txtHoTenGV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ.", "Thông báo");
                txtMaGV.Focus();
            }    
            else if (txtMaGV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã giảng viên.", "Thông báo");
                txtMaGV.Focus();
            }
            else if (txtHoTenGV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thông báo");
                txtHoTenGV.Focus();
            }    
            else if (rdoNam.Checked == false && rdoNu.Checked == false)
                MessageBox.Show("Vui lòng chọn giới tinh.", "Thông báo");
            else
            {
                if (xuly.kiemMa(txtMaGV.Text) == false)
                {
                    MessageBox.Show("Mã giảng viên có 5 ký tự, phải bắt đầu bằng GVxxx và không có khoảng trắng và ký tự.");
                    txtMaGV.Focus();
                    return;
                }

                if (xuly.kiemTen(txtHoTenGV.Text) == false)
                {
                    MessageBox.Show("Vui lòng nhập họ tên không có ký tự và số.");
                    txtHoTenGV.Focus();
                    return;
                }
                if (xuly.them(gv) == true)
                {
                    hienThi(xuly.GetGiangVien());
                    reset();
                }
                else
                {
                    MessageBox.Show("Mã số giảng viên " + gv.MaGiangVien + " đã tồn tại. Không thêm được");
                    txtMaGV.Focus();
                }    
            }
        }
        private void reset()
        {
            txtMaGV.Text = "";
            txtHoTenGV.Text = "";
            rdoNam.Checked = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiangVien gv = xuly.tim(txtMaGV.Text);
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("không có dữ liệu để xóa.");
                txtMaGV.Focus();
                return;
            }
            if (gv == null)
            {
                if (xuly.xoa(txtMaGV.Text) == false)
                {
                    MessageBox.Show("không có dữ liệu để xóa");
                    txtMaGV.Focus();
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
                    xuly.xoa(txtMaGV.Text);
                    MessageBox.Show("Xóa thành công");
                }
            }
            hienThi(xuly.GetGiangVien());
            reset();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien();
            gv.MaGiangVien = txtMaGV.Text;
            gv.HoTenGiangVien = txtHoTenGV.Text;
            gv.Phai = rdoNam.Checked;
            if (txtMaGV.Text == "" && txtHoTenGV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa.", "Thông báo");
                txtMaGV.Focus();
                return;
            }

            if (xuly.kiemTen(txtHoTenGV.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập họ tên không có ký tự và số.");
                txtHoTenGV.Focus();
                return;
            }
            if (xuly.sua(gv) == true)
            {
                hienThi(xuly.GetGiangVien());
                txtMaGV.Focus();
            }    
            else
            {
                MessageBox.Show("Mã giảng viên không tồn tại.");
                txtMaGV.Focus();
            }    
            reset();
        }
        private void dgvGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGV.SelectedCells.Count > 0)
            {
                txtMaGV.Text = dgvGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTenGV.Text = dgvGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (dgvGV.Rows[e.RowIndex].Cells[2].Value.ToString() == "True")
                    rdoNam.Checked = true;
                else if (dgvGV.Rows[e.RowIndex].Cells[2].Value.ToString() == "False")
                    rdoNu.Checked = true;
            }
        }

        private void txtMaGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}
