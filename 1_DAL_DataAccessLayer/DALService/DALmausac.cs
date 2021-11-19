using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IDALService;

namespace _1_DAL_DataAccessLayer.DALService
{
    public class DALmausac : IDALmausac
    {
        List<Mausac> _lstmausac;
        DatabaseContext _dbContext;
        public DALmausac()
        {
            _dbContext = new DatabaseContext();
            _lstmausac = new List<Mausac>();
            getfromdv();
        }
        public void getfromdv()
        {
            _lstmausac = _dbContext.Mausacs.ToList();
        }
        public List<Mausac> Getlistmausac()
        {
            return _lstmausac;
        }
        public string Addmausac(Mausac da)
        {
            _lstmausac.Add(da);
            _dbContext.Add(da);
            return "Thêm thành công";
        }
        public string Updatemausac(Mausac da)
        {

            _dbContext.Update(da);
            return "Sửa thành công";
        }
        public string Deletemausac(Mausac da)
        {
            _lstmausac.Remove(da);
            _dbContext.Remove(da);
            return "Xóa thành công";
        }
        public string Save()
        {
            _dbContext.SaveChanges();
            return "luu thanh cong";
        }
    }
}
