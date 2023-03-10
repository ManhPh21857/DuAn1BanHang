using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class KhuyenMai
    {
        public Guid MaKM { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgyaKetThuc { get; set; }
        public decimal GiamGia { get; set; }
        public int TrangThai { get; set; }
        public virtual List<HoaDonChiTiet> HoaDonChiTietS { get; set; }
    }
}
