using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }

        public ThietBi()
        {

        }

        public ThietBi(string maTB, string tenTB, string nuocSX, double donGia, int soLuong)
        {
            MaThietBi = maTB;
            TenThietBi = tenTB;
            NuocSanXuat = nuocSX;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public double ThanhTien()
        {
            return DonGia * SoLuong;
        }

        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaThietBi, TenThietBi, NuocSanXuat, DonGia, SoLuong);
        }
    }
}
