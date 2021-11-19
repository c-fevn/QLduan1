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
    public class DALloaisanpham : IDALloaisanpham
    {
        List<Loaisanpham> _lstloaisanpham;
        DatabaseContext _dbContext;
        public DALloaisanpham()
        {
            _dbContext = new DatabaseContext();
            _lstloaisanpham = new List<Loaisanpham>();
            getfromdv();
        }
        public void getfromdv()
        {
            _lstloaisanpham = _dbContext.Loaisanphams.ToList();
        }
        public List<Loaisanpham> Getlistloaisanpham()
        {
            return _lstloaisanpham;
        }
        public string Addloaisanpham(Loaisanpham da)
        {
            _lstloaisanpham.Add(da);
            _dbContext.Add(da);
            return "Thêm thành công";
        }
        public string Updateloaisanpham(Loaisanpham da)
        {
            _dbContext.Update(da);
            return "Sửa thành công";
        }
        public string Deleteloaisanpham(Loaisanpham da)
        {
            _lstloaisanpham.Remove(da);
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
