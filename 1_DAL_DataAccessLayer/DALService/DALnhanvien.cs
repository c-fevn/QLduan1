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
    public class DALnhanvien : IDALnhanvien
    {
        List<Nhanvien> _lstnhanvien;
        DatabaseContext _dbContext;
        public DALnhanvien()
        {
            _dbContext = new DatabaseContext();
            _lstnhanvien = new List<Nhanvien>();
            getfromdv();
        }
        public void getfromdv()
        {
            _lstnhanvien = _dbContext.Nhanviens.ToList();
        }
        public List<Nhanvien> Getlistnhanvien()
        {
            return _lstnhanvien;
        }
        public string Addnhanvien(Nhanvien da)
        {
            _lstnhanvien.Add(da);
            _dbContext.Add(da);
            return "Thêm thành công";
        }
        public string Updatenhanvien(Nhanvien da)
        {
            _dbContext.Update(da);
            return "Sửa thành công";
        }
        public string Deletenhanvien(Nhanvien da)
        {
            _lstnhanvien.Remove(da);
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
