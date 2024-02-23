using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    [Serializable]
    internal class LopHoc
    {
        private string m_maLop;
        private string m_tenLop;
        public string MaLop
        {
            get { return m_maLop; }
            set { m_maLop = value; }
        }
        public string TenLop
        {
            set { m_tenLop = value; }
            get { return m_tenLop; }
        }
        public LopHoc()
        {
            m_maLop = "";
            m_tenLop = "";
        }
        public LopHoc(string maLop, string tenLop)
        {
            m_maLop = maLop;
            m_tenLop = tenLop;
        }
        public override string ToString()
        {
            return MaLop;
        }
    }
}
