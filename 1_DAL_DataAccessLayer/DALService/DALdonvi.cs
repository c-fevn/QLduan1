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
    public class DALdonvi : IDALdonvi
    {
        List<Donvi> _lstdonvi;
        DatabaseContext _dbContext;
        public DALdonvi()
        {
            _dbContext = new DatabaseContext();
            _lstdonvi = new List<Donvi>();
            getfromdv();
        }
        public void getfromdv()
        {
            _lstdonvi = _dbContext.Donvis.ToList();
        }
        public List<Donvi> Getlistdonvi()
        {
            return _lstdonvi;
        }
        public string Adddonvi(Donvi da)
        {
            _lstdonvi.Add(da);
            _dbContext.Add(da);
            return "Thêm thành công";
        }
        public string Updatedonvi(Donvi da)
        {
            _dbContext.Update(da);
            return "Sửa thành công";
        }
        public string Deletedonvi(Donvi da)
        {
            _lstdonvi.Remove(da);
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
