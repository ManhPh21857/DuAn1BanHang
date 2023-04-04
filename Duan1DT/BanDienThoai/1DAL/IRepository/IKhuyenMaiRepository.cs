using _1DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.IRepository
{
    public interface IKhuyenMaiRepository
    {
        bool Add(KhuyenMai khuyenMai);
        bool Update(KhuyenMai khuyenMai);
        bool Delete(KhuyenMai khuyenMai);
        List<KhuyenMai> GetAll();
    }
}
