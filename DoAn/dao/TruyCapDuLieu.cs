using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;

namespace DoAn
{
    [Serializable]
    internal class TruyCapDuLieu
    {
        private List<SinhVien> dsSinhVien;
        private List<MonHoc> dsMonHoc;
        private List<LopHoc> dsLopHoc;
        private List<GiangVien> dsGiangVien;
        private static TruyCapDuLieu data = null;
        private TruyCapDuLieu()
        {
            dsSinhVien = new List<SinhVien>();
            dsMonHoc = new List<MonHoc>();
            dsLopHoc = new List<LopHoc>();
            dsGiangVien = new List<GiangVien>();
        }
        public static TruyCapDuLieu khoiTao()
        {
            if (data == null)
                data = new TruyCapDuLieu();
            return data;
        }
        public List<SinhVien> getDSSinhVien()
        {
            return dsSinhVien;
        }
        public List<MonHoc> getDSMonHoc()
        {
            return dsMonHoc;
        }
        public List<GiangVien> getDSGiangVien()
        {
            return dsGiangVien;
        }
        public List<LopHoc> getDSLopHoc()
        {
            return dsLopHoc;
        }
        public bool ghiFile(string tenFile)
        {
            try
            {
                FileStream f = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, data);
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool docFile(string tenFile)
        {
            try
            {
                FileStream f = new FileStream(tenFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                data = bf.Deserialize(f) as TruyCapDuLieu;
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
