using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    internal class CXuLyGV
    {
        private TruyCapDuLieu data = TruyCapDuLieu.khoiTao();
        private List<GiangVien> dsGV;
        public CXuLyGV()
        {
            dsGV = data.getDSGiangVien(); 
        }
        public List<GiangVien> GetGiangVien()
        {
            return dsGV;
        }
        public GiangVien tim(string maso)
        {
            foreach (GiangVien gv in dsGV)
            {
                if (gv.MaGiangVien == maso)
                    return gv;
            }
            return null;
        }
        public bool them(GiangVien gv)
        {
            if (tim(gv.MaGiangVien) == null)
            {
                dsGV.Add(gv);
                return true;
            }
            else
                return false;
        }
        public bool xoa(string maso)
        {
            GiangVien gv = tim(maso);
            if (gv != null)
            {
                dsGV.Remove(tim(maso));
                return true;
            }
            else
                return false;
        }
        public bool sua(GiangVien gv)
        {
            GiangVien b = tim(gv.MaGiangVien);
            if (b == null)
                return false;
            b.MaGiangVien = gv.MaGiangVien;
            b.HoTenGiangVien = gv.HoTenGiangVien;
            b.Phai = gv.Phai;
            return true;
        }
        public bool kiemMa(string ma)
        {
            if (ma[0] != 'G') return false;
            if (ma[1] != 'V') return false;
            for (int i = 2; i < ma.Length; i++)
            {
                if (!(ma[i] >= '0' && ma[i] <= '9'))
                    return false;
                if ((ma[i] >= 32 && ma[i] <= 47) || (ma[i] >= 58 && ma[i] <= 64) 
                    || (ma[i] >= 91 && ma[i] <= 96) || (ma[i] >= 123 && ma[i] <= 126))
                    return false;
            }
            if (ma.Length < 5)
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
