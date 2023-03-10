using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class DienThoai
    {
        public Guid MaDT { get; set; }
        public string TenDT { get; set; }
        public virtual List<DienThoaiCT> DienThoaiCTS { get; set; }
    }
}
