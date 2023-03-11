using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class GioHang
    {
        public int MaGH { get; set; }
        public int MaNV { get; set; }
        public int MaKH { get; set; }

        public virtual List<GioHangCT> GioHangCTs { get; set; }
        public NhanVien NhanVienS { get; set; }
        public KhachHang KhachHangS { get; set; }
    }
}
