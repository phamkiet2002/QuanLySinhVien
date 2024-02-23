using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    [Serializable]
    internal class SinhVien
    {
        //các thành phần dữ liệu
        private string m_maSV;
        private string m_hoTen;
        private DateTime m_ngaySinh;
        private bool m_phai;
        private string m_diaChi;
        private LopHoc m_ctlh;
        //các properties
        public string MaSV
        {
            get { return m_maSV; }
            set { m_maSV = value; }
        }
        public string HoTen
        {
            get { return m_hoTen; }
            set { m_hoTen = value; }
        }
        public DateTime NgaySinh
        {
            get { return m_ngaySinh; }
            set { m_ngaySinh = value; }
        }
        public bool Phai
        {
            get { return m_phai; }
            set { m_phai = value; }
        }
        public string DiaChi
        {
            get { return m_diaChi; }
            set { m_diaChi = value; }
        }
        public LopHoc lophoc
        {
            get { return m_ctlh; }
            set { m_ctlh = value; }
        }
        // các phương thức tạo lập
        public SinhVien()
        {
            m_maSV = "";
            m_hoTen = "";
            m_ngaySinh = DateTime.Now;
            m_phai = false;
            m_diaChi = "";
            m_ctlh = null;
        }
        public SinhVien(string maSo, string hoTen, DateTime ngaySinh, bool phai, string diaChi, LopHoc lh)
        {
            m_maSV = maSo;
            m_hoTen = hoTen;
            m_ngaySinh = ngaySinh;
            m_phai = phai;
            m_diaChi = diaChi;
            m_ctlh = lh;
        }
    }
}
