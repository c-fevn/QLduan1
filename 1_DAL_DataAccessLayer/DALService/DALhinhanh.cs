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
    public class DALhinhanh : IDALhinhanh
    {
        List<Hinhanh> _lsthinhanh;
        DatabaseContext _dbContext;
        public DALhinhanh()
        {
            _dbContext = new DatabaseContext();
            _lsthinhanh = new List<Hinhanh>();
            getfromdv();
        }
        public void getfromdv()
        {
            _lsthinhanh = _dbContext.Hinhanhs.ToList();
        }
        public List<Hinhanh> Getlisthinhanh()
        {
            return _lsthinhanh;
        }
        public string Addhinhanh(Hinhanh da)
        {
            _lsthinhanh.Add(da);
            _dbContext.Add(da);
            return "Thêm thành công";
        }
        public string Updatehinhanh(Hinhanh da)
        {
            _dbContext.Update(da);
            return "Sửa thành công";
        }
        public string Deletehinhanh(Hinhanh da)
        {
            _lsthinhanh.Remove(da);
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
