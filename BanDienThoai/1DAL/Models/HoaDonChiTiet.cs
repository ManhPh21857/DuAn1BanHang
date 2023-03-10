using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class HoaDonChiTiet
    {
        public Guid MaDTCT { get; set; }
        public Guid MaHD { get; set; }
        public Guid MaKM { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public DienThoaiCT DienThoaiCTS { get; set; }
        public HoaDon HoaDonS { get; set; }
        public KhuyenMai KhuyenMaiS { get; set; }
    }
}
