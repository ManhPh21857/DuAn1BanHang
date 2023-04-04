using _1DAL.IRepository;
using _1DAL.Models;
using _1DAL.Repositorys;
using _2BUS.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BUS.Service
{
    public class KhuyenMaiService : IKhuyenMaiService
    {
        IKhuyenMaiRepository _ikhuyenMaiRepository = new KhuyenMaiRepository();
        public bool Add(KhuyenMai obj)
        {
            _ikhuyenMaiRepository.Add(obj);
            return true;
        }

        public bool Delete(KhuyenMai obj)
        {
            _ikhuyenMaiRepository.Delete(obj);
            return true;
        }

        public List<KhuyenMai> GetAll()
        {
            return _ikhuyenMaiRepository.GetAll();
        }

        public bool Update(KhuyenMai obj)
        {
            _ikhuyenMaiRepository.Update(obj);
            return true;
        }
    }
}
