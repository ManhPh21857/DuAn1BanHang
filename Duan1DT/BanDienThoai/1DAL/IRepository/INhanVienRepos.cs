using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
namespace _1DAL.IRepository
{
    internal interface INhanVienRepos
    {
        bool Add(NhanVien chucVu);
        bool Update(NhanVien chucVu);
        bool Delete(NhanVien chucVu);
        List<NhanVien> GetAll();
    }
}
