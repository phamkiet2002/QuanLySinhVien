using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    internal class CXuLyLH
    {
        private TruyCapDuLieu data = TruyCapDuLieu.khoiTao();
        private List<LopHoc> dsLH;
        public CXuLyLH()
        {
            dsLH = data.getDSLopHoc();
        }
        public List<LopHoc> GetLopHoc()
        {
            return dsLH;
        }
        public LopHoc tim(string maso)
        {
            foreach (LopHoc lh in dsLH)
            {
                if (lh.MaLop == maso)
                    return lh;
            }
            return null;
        }
        public bool them(LopHoc lh)
        {
            if (tim(lh.MaLop) == null)
            {
                dsLH.Add(lh);
                return true;
            }
            else
                return false;
        }
        public bool xoa(string maso)
        {
            LopHoc lh = tim(maso);
            if (lh != null)
            {
                dsLH.Remove(tim(maso));
                return true;
            }
            else
                return false;
        }
        public bool sua(LopHoc lh)
        {
            LopHoc b = tim(lh.MaLop);
            if (b == null)
                return false;
            b.MaLop = lh.MaLop;
            b.TenLop = lh.TenLop;
            return true;
        }
        public bool kiemMa(string ma)
        {
            if (ma[0] != 'C') return false;
            for (int i = 1; i < ma.Length; i++)
            {
                if (!(ma[i] >= '0' && ma[i] <= '9'))
                    return false;
                if ((ma[i] >= 32 && ma[i] <= 47) || 
                    (ma[i] >= 58 && ma[i] <= 64) 
                    || (ma[i] >= 91 && ma[i] <= 96) || 
                    (ma[i] >= 123 && ma[i] <= 126))
                    return false;
            }
            if (ma.Length < 4)
                return false;
            return true;
        }
        public bool kiemTen(string ma)
        {
            for (int i = 0; i < ma.Length; i++)
            {
                if ((ma[i] >= 33 && ma[i] <= 63) || 
                    (ma[i] >= 91 && ma[i] <= 96) || 
                    (ma[i] >= 123 && ma[i] <= 126))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
