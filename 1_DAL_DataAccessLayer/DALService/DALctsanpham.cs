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
    public class DALctsanpham : IDALctsanpham
    {
        List<Ctsanpham> _lstctsanpham;
        DatabaseContext _dbContext;
        public DALctsanpham()
        {
            _dbContext = new DatabaseContext();
            _lstctsanpham = new List<Ctsanpham>();
            getfromdv();
        }
        public void getfromdv()
        {
            _lstctsanpham = _dbContext.Ctsanphams.ToList();
        }
        public List<Ctsanpham> Getlistctsanpham()
        {
            return _lstctsanpham;
        }
        public string Addctsanpham(Ctsanpham da)
        {
            _lstctsanpham.Add(da);
            _dbContext.Add(da);
            return "Thêm thành công";
        }
        public string Updatectsanpham(Ctsanpham da)
        {
            _dbContext.Update(da);
            return "Sửa thành công";
        }
        public string Deletectsanpham(Ctsanpham da)
        {
            _lstctsanpham.Remove(da);
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
