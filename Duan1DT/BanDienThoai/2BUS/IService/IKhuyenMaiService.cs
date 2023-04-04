using _1DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BUS.IService
{
    public interface IKhuyenMaiService
    {
        bool Add(KhuyenMai obj);
        bool Update(KhuyenMai obj);
        bool Delete(KhuyenMai obj);
        List<KhuyenMai> GetAll();
    }
}
