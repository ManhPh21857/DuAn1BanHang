using _1DAL.ConText;
using _1DAL.IRepository;
using _1DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Repositorys
{
    public class KhuyenMaiRepository : IKhuyenMaiRepository
    {
        DBContextDienThoai _dbcontext = new DBContextDienThoai();
        public bool Add(KhuyenMai khuyenMai)
        {
            _dbcontext.khuyenMais.Add(khuyenMai);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(KhuyenMai khuyenMai)
        {
            _dbcontext.khuyenMais.Remove(khuyenMai);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<KhuyenMai> GetAll()
        {
            return _dbcontext.khuyenMais.ToList();
        }

        public bool Update(KhuyenMai khuyenMai)
        {
            _dbcontext.khuyenMais.Update(khuyenMai);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
