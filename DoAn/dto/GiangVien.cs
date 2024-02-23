using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    [Serializable]
    internal class GiangVien
    {
        //các thành phần dữ liệu
        private string m_maGiangVien;
        private string m_hoTenGiangVien;
        private bool m_phai;
        //các properties
        public string MaGiangVien
        {
            get { return m_maGiangVien; }
            set { m_maGiangVien = value; }
        }
        public string HoTenGiangVien
        {
            get { return m_hoTenGiangVien; }
            set { m_hoTenGiangVien = value; }
        }
        public bool Phai
        {
            get { return m_phai; }
            set { m_phai = value; }
        }
        // các phương thức tạo lập
        public GiangVien()
        {
            m_maGiangVien = "";
            m_hoTenGiangVien = "";
            m_phai = false;
        }
        public GiangVien(string maGiangVien, string hoTenGiangVien, bool phai)
        {
            m_maGiangVien = maGiangVien;
            m_hoTenGiangVien = hoTenGiangVien;
            m_phai = phai;
        }
    }
}
