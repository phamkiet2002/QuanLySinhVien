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
    public partial class FormLopHocView : Form
    {
        private CXuLySV xl = new CXuLySV();
        private CXuLyLH xllh = new CXuLyLH();
        private LopHoc lh1 = new LopHoc();
        private List<SinhVien> dssv;

        public FormLopHocView()
        {
            InitializeComponent();
        }
        private void hienThi(List<SinhVien> dsSV)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsSV;
            dgvSV.DataSource = bs;
        }
        private void FormLopHocView_Load(object sender, EventArgs e)
        {
            cmbMaLop.DataSource = xllh.GetLopHoc();
            cmbMaLop.Focus();
        }
        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = cmbMaLop.SelectedValue.ToString();
            LopHoc lh = xllh.tim(ma);
            txtTenLop.Text = lh.TenLop;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            lh1 = new LopHoc();
            dssv = new List<SinhVien>();
            foreach (SinhVien sv in xl.GetSinhVien())
            {
                if (cmbMaLop.Text.ToString() == sv.lophoc.MaLop)
                {
                    dssv.Add(sv);
                }
                hienThi(dssv);
            }
        }
    }
}
