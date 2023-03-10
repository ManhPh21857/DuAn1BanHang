using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class HoaDon
    {
        public Guid MaHD { get; set; }
        public Guid MaNV { get; set; }
        public Guid MaKH { get; set; }
        public DateTime NgayTT { get; set; }
        public DateTime NgayBan { get; set; }
        public int GiamGia { get; set; }
        public int TrangThai { get; set; }
        public virtual List<HoaDonChiTiet> HoaDonChiTietS { get; set; }
        public NhanVien NhanVienS { get; set; }
        public KhachHang KhachHangS { get; set; }
    }
}
