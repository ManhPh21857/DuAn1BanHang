using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class HangSX
    {
        public Guid MaHang { get; set; }
        public string TenHang { get; set; }
        public virtual List<DienThoaiCT> DienThoaiCTS { get; set; }
    }
}
