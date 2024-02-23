using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace DoAn
{
    internal class CXuLySV
    {
        private TruyCapDuLieu data = TruyCapDuLieu.khoiTao();
        private List<SinhVien> dsSV;
        private List<LopHoc> dslh;
        public CXuLySV()
        {
            dsSV = data.getDSSinhVien();
            dslh = data.getDSLopHoc();
        }
        public List<SinhVien> GetSinhVien()
        {
            return dsSV;
        }
        public List<LopHoc> GetLopHoc
        {
            get { return dslh; }
        }
        public SinhVien tim(string maso)
        {
            foreach (SinhVien sv in dsSV)
            {
                if (sv.MaSV == maso)
                    return sv;
            }
            return null;
        }
        public bool them(SinhVien sv)
        {
            if (tim(sv.MaSV) == null)
            {
                dsSV.Add(sv);
                return true;
            }
            else
                return false;
        }
        public bool xoa(string maso)
        {
            SinhVien sv = tim(maso);
            if (sv != null)
            {
                dsSV.Remove(tim(maso));
                return true;
            }
            return false;
        }
        public bool sua(SinhVien sv)
        {
            SinhVien b = tim(sv.MaSV);
            if (b != null)
            {
                b.HoTen = sv.HoTen;
                b.NgaySinh = sv.NgaySinh;
                b.Phai = sv.Phai;
                b.DiaChi = sv.DiaChi;
                b.lophoc = sv.lophoc;
                return true;
            }
            else return false;
        }
        public bool kiemMa(string ma)
        {
            if (ma[0] != 'D') return false;
            if (ma[1] != 'H') return false;
            if (ma[2] != '5') return false;
            for (int i = 3; i < ma.Length; i++)
            {
                if (!(ma[i] >= '0' && ma[i] <= '9'))
                    return false;
                if ((ma[i] >= 32 && ma[i] <= 47) || (ma[i] >= 58 && ma[i] <= 64) 
                    || (ma[i] >= 91 && ma[i] <= 96) || (ma[i] >= 123 && ma[i] <= 126))
                    return false;
            }
            if (ma.Length < 10)
                return false;

            return true;
        }
        public bool kiemTen(string ma)
        {
            for (int i = 0; i < ma.Length; i++)
            {
                if ((ma[i] >= 33 && ma[i] <= 63) ||
                    (ma[i] >= 91 && ma[i] <= 96) || (ma[i] >= 123 && ma[i] <= 126))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
