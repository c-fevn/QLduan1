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
    public class DALhoadon : IDALhoadon
    {
        List<Hoadon> _lsthoadon;
        DatabaseContext _dbContext;
        public DALhoadon()
        {
            _dbContext = new DatabaseContext();
            _lsthoadon = new List<Hoadon>();
            getfromdv();
        }
        public void getfromdv()
        {
            _lsthoadon = _dbContext.Hoadons.ToList();
        }
        public List<Hoadon> Getlisthoadon()
        {
            return _lsthoadon;
        }
        public string Addhoadon(Hoadon da)
        {
            _lsthoadon.Add(da);
            _dbContext.Add(da);
            return "Thêm thành công";
        }
        public string Updatehoadon(Hoadon da)
        {
            _dbContext.Update(da);
            return "Sửa thành công";
        }
        public string Deletehoadon(Hoadon da)
        {
            _lsthoadon.Remove(da);
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
