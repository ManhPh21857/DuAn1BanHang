using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class GioHang
    {
        public Guid MaGH { get; set; }
        public Guid MaNV { get; set; }
        public Guid MaKH { get; set; }
        public int TongGia { get; set; }
        public virtual List<GioHangCT> GioHangCTS { get; set; }
        public NhanVien NhanVienS { get; set; }
        public KhachHang KhachHangS { get; set; }
    }
}
