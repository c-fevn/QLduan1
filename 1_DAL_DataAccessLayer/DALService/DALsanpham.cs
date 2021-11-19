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
    public class DALsanpham : IDALsanpham
    {
        List<Sanpham> _lstsanpham;
        DatabaseContext _dbContext;
        public DALsanpham()
        {
            _dbContext = new DatabaseContext();
            _lstsanpham = new List<Sanpham>();
            getfromsp();
        }
        public void getfromsp()
        {
            _lstsanpham = _dbContext.Sanphams.ToList();
        }
        public List<Sanpham> Getlistsanpham()
        {
            return _lstsanpham;
        }
        public string Addsanpham(Sanpham da)
        {
            _lstsanpham.Add(da);
            _dbContext.Add(da);
            return "Thêm thành công";
        }
        public string Updatesanpham(Sanpham da)
        {
            _dbContext.Update(da);
            return "Sửa thành công";
        }
        public string Deletesanpham(Sanpham da)
        {
            _lstsanpham.Remove(da);
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
