using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class DienThoaiCT
    {
        public Guid MaDTCT { get; set; }
        public Guid MaHang { get; set; }
        public Guid MaMau { get; set; }
        public Guid MaDT { get; set; }
        public Guid MaDungLuong { get; set; }
        public int SoLuong { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public string LinkAnh { get; set; }
        public DienThoai DienThoaiS { get; set; }
        public DungLuong DungLuongS { get; set; }
        public HangSX HangSXS { get; set; }
        public MauSac MauSacS { get; set; }
        public List<HoaDon> HoaDonS { get; set; }
    }
}
