using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Configuration;
using _1DAL.Models;
using _1DAL.IRepository;
using _1DAL.ConText;
namespace _1DAL.Repositorys
{
    public class NhanVienRepos : INhanVienRepos
    {
        DBContextDienThoai _context = new DBContextDienThoai();
        public bool Add(NhanVien chucVu)
        {
            _context.Add(chucVu);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien chucVu)
        {
           _context.Remove(chucVu);
            _context.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _context.nhanViens.ToList();
        }

        public bool Update(NhanVien chucVu)
        {
            _context.Update(chucVu);
            _context.SaveChanges();
            return true;
        }
    }
}
