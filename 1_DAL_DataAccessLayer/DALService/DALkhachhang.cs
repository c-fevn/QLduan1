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
    public class DALkhachhang : IDALkhachhang
    {
        List<Khachhang> _lstkhachhang;
        DatabaseContext _dbContext;
        public DALkhachhang()
        {
            _dbContext = new DatabaseContext();
            _lstkhachhang = new List<Khachhang>();
            getfromdv();
        }
        public void getfromdv()
        {
            _lstkhachhang = _dbContext.Khachhangs.ToList();
        }
        public List<Khachhang> Getlistkhachhang()
        {
            return _lstkhachhang;
        }
        public string Addkhachhang(Khachhang da)
        {
            _lstkhachhang.Add(da);
            _dbContext.Add(da);
            return "Thêm thành công";
        }
        public string Updatekhachhang(Khachhang da)
        {
            _dbContext.Update(da);
            return "Sửa thành công";
        }
        public string Deletekhachhang(Khachhang da)
        {
            _lstkhachhang.Remove(da);
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
