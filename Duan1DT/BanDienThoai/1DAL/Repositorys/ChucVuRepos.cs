using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
using _1DAL.ConText;
using _1DAL.IRepository;
namespace _1DAL.Repositorys
{
    public class ChucVuRepos : IChucVuRepos
    {
        DBContextDienThoai _context = new DBContextDienThoai();
        public bool Add(ChucVu chucVu)
        {
            _context.Add(chucVu);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu chucVu)
        {
            _context.Remove(chucVu);
            _context.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _context.chucVus.ToList();
        }

        public bool Update(ChucVu chucVu)
        {
            _context.Update(chucVu);
            _context.SaveChanges();
            return true;
        }
    }
}
