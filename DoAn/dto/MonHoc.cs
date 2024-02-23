using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    [Serializable]
    internal class MonHoc
    {
        //các thành phần dữ liệu
        private string m_maMH;
        private string m_tenMH;
        private int m_soTC;
        private int m_soTietTH;
        private int m_soTietLT;
        //các properties
        public string MaMH
        {
            get { return m_maMH; }
            set { m_maMH = value; }
        }
        public string TenMH
        {
            get { return m_tenMH; }
            set { m_tenMH = value; }
        }
        public int SoTC
        {
            get { return m_soTC; }
            set { m_soTC = value; }
        }
        public int SoTietTH
        {
            get { return m_soTietTH; }
            set { m_soTietTH = value; }
        }
        public int SoTietLT
        {
            get { return m_soTietLT; }
            set { m_soTietLT = value; }
        }
        // các phương thức tạo lập
        public MonHoc()
        {
            m_maMH = "";
            m_tenMH = "";
            m_soTC = 0;
            m_soTietTH = 0;
            m_soTietLT = 0;
        }
        public MonHoc(string maMH, string tenMH, int soTC, int soTietTH, int soTietLT)
        {
            m_maMH = maMH;
            m_tenMH = tenMH;
            m_soTC = soTC;
            m_soTietTH = soTietTH;
            m_soTietLT = soTietLT;
        }
    }
}
