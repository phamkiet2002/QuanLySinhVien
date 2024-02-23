using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    internal class CXuLyMH
    {
        private TruyCapDuLieu data = TruyCapDuLieu.khoiTao();
        private List<MonHoc> dsMH;
        public CXuLyMH()
        {
            dsMH = data.getDSMonHoc();
        }
        public List<MonHoc> GetMonHoc()
        {
            return dsMH;
        }
        public MonHoc tim(string ma)
        {
            foreach (MonHoc mh in dsMH)
            {
                if(mh.MaMH == ma)
                    return mh;
            }
            return null;
        }
        public bool them(MonHoc mh)
        {
            if (tim(mh.MaMH) == null)
            {
                dsMH.Add(mh);
                return true;
            }
            else
                return false;
        }
        public bool xoa(string ma)
        {
            MonHoc mh = tim(ma);
            if (mh != null)
            {
                dsMH.Remove(mh);
                return false;
            }
            else
                return false;
        }
        public bool sua(MonHoc mh)
        {
            MonHoc b = tim(mh.MaMH);
            if (b == null)
                return false;
            b.MaMH = mh.MaMH;
            b.TenMH = mh.TenMH;
            b.SoTC = mh.SoTC;
            b.SoTietTH = mh.SoTietTH;
            b.SoTietLT = mh.SoTietLT;
            return true;
        }

        public bool kiemMa(string ma)
        {
            if (ma[0] != 'C') return false;
            if (ma[1] != 'S') return false;
            for (int i = 2; i < ma.Length; i++)
            {
                if (!(ma[i] >= '0' && ma[i] <= '9'))
                    return false;
                if ((ma[i] >= 32 && ma[i] <= 47) || 
                    (ma[i] >= 58 && ma[i] <= 64) || 
                    (ma[i] >= 91 && ma[i] <= 96) || 
                    (ma[i] >= 123 && ma[i] <= 126))
                    return false;
            }
            if (ma.Length < 7)
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
