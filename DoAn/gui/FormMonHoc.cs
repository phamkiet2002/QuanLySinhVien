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
    public partial class FormMonHoc : Form
    {
        private CXuLyMH xuly = new CXuLyMH();
        public FormMonHoc()
        {
            InitializeComponent();
        }
        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            hienThi(xuly.GetMonHoc());
            txtMaMH.Focus();
        }
        private void hienThi(List<MonHoc>dsMH)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsMH;
            dgvMH.DataSource = bs;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.MaMH = txtMaMH.Text;
            mh.TenMH = txtTenMH.Text;
            mh.SoTC = ((int)nudSoTC.Value);
            mh.SoTietTH = ((int)nudSoTietTH.Value);
            mh.SoTietLT = ((int)nudSoTietLT.Value);
            if (txtMaMH.Text == "" && txtTenMH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ.", "Thông báo");
                txtMaMH.Focus();
            }    
            else if (txtMaMH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã môn học.", "Thông báo");
                txtMaMH.Focus();
            }    
            else if (txtTenMH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên môn học.", "Thông báo");
                txtTenMH.Focus();
            }    
            else
            {
                if (xuly.kiemMa(txtMaMH.Text) == false)
                {
                    MessageBox.Show("Mã môn học có 7 ký tự, phải bắt đầu bằng CSxxxxx và không có khoảng trắng và ký tự.");
                    txtMaMH.Focus();
                    return;
                }

                if (xuly.kiemTen(txtTenMH.Text) == false)
                {
                    MessageBox.Show("Vui lòng nhập họ tên không có ký tự và số.");
                    txtTenMH.Focus();
                    return;
                }
                if (xuly.them(mh) == true)
                {
                    hienThi(xuly.GetMonHoc());
                    reset();
                    txtMaMH.Focus();
                }
                else
                {
                    MessageBox.Show("Mã số môn học " + mh.MaMH + " đã tồn tại. Không thêm được");
                    txtMaMH.Focus();
                }    
            }
        }
        private void reset()
        {
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            nudSoTC.Value = 0;
            nudSoTietLT.Value = 0;
            nudSoTietTH.Value = 0;
            txtMaMH.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            MonHoc mh = xuly.tim(txtMaMH.Text);
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("không có dữ liệu để xóa.");
                return;
            }
            if (mh == null)
            {
                if (xuly.xoa(txtMaMH.Text) == false)
                {
                    MessageBox.Show("Mã môn học không tồn tại.");
                    txtMaMH.Focus();
                }    
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    reset();
                    txtMaMH.Focus();
                }
                else
                {
                    xuly.xoa(txtMaMH.Text);
                    MessageBox.Show("Xóa thành công");
                    txtMaMH.Focus();
                }
            }
            hienThi(xuly.GetMonHoc());
            reset();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.MaMH = txtMaMH.Text;
            mh.TenMH = txtTenMH.Text;
            mh.SoTC = ((int)nudSoTC.Value);
            mh.SoTietTH = ((int)nudSoTietTH.Value);
            mh.SoTietLT = ((int)nudSoTietLT.Value);
            if (txtMaMH.Text == "" || txtTenMH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa.", "Thông báo");
                txtMaMH.Focus();
            }

            if (xuly.kiemTen(txtTenMH.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập họ tên không có ký tự và số.");
                txtTenMH.Focus();
                return;
            }
            if (xuly.sua(mh) == true)
            {
                hienThi(xuly.GetMonHoc());
                txtMaMH.Focus();
            }    
            else
            {
                MessageBox.Show("Mã môn học không tồn tại.","Thông báo.");
                txtMaMH.Focus();
            }    
            reset();
        }
        private void dgvMH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMH.SelectedCells.Count > 0)
            {
                txtMaMH.Text = dgvMH.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenMH.Text = dgvMH.Rows[e.RowIndex].Cells[1].Value.ToString();
                nudSoTC.Value = Convert.ToInt64(dgvMH.Rows[e.RowIndex].Cells[2].Value.ToString());
                nudSoTietTH.Value = Convert.ToInt64(dgvMH.Rows[e.RowIndex].Cells[3].Value.ToString());
                nudSoTietLT.Value = Convert.ToInt64(dgvMH.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
        }
        private void txtMaMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}
