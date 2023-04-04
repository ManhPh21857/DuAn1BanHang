using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
namespace _2BUS.ViewModel
{
    public class HoaDonChiTietView
    {
        public HoaDonChiTiet hoaDonChiTiet { get; set; }
        public HoaDon hoaDon { get; set; }
        public KhuyenMai khuyenMai { get; set; }
        public DienThoaiCT dienThoaiCT { get; set; }
    }
}
