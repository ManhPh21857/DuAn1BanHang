﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class GioHangCT
    {
        public Guid MaGHCT { get; set; }
        public Guid MaGH { get; set; }
        public Guid MaDTCT { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public GioHang GioHangS { get; set; }
        public DienThoaiCT DienThoaiCTS { get; set; }
    }
}
