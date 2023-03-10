﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class KhachHang
    {
        public Guid MaKH { get; set; }
        public string TenKH { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public int Diem { get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }
    }
}
