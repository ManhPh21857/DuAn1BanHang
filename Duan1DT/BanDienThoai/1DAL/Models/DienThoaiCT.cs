using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class DienThoaiCT
    {
        public int MaDTCT { get; set; }
        public int MaHang { get; set; }
        public int MaMau { get; set; }
        public int MaDT { get; set; }
        public int MaDungLuong { get; set; }
        public int SoLuong { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public string LinkAnh { get; set; }
        public DienThoai DienThoaiS { get; set; }
        public DungLuong DungLuongS { get; set; }
        public HangSX HangSXS { get; set; }
        public MauSac MauSacS { get; set; }
        public  List<HoaDonChiTiet> HoaDonCTs { get; set; }
        public  List<GioHangCT> GioHangCTS { get; set; }
    }
}
