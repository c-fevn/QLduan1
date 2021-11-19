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
    public class DALchitiethoadon : IDALchitiethoadon
    {
        List<Chitiethoadon> _lstchitiethoadon;
        DatabaseContext _dbContext;
        public DALchitiethoadon()
        {
            _dbContext = new DatabaseContext();
            _lstchitiethoadon = new List<Chitiethoadon>();
            getfromdv();
        }
        public void getfromdv()
        {
            _lstchitiethoadon = _dbContext.Chitiethoadons.ToList();
        }
        public List<Chitiethoadon> Getlistchitiethoadon()
        {
            return _lstchitiethoadon;
        }
        public string Addchitiethoadon(Chitiethoadon da)
        {
            _lstchitiethoadon.Add(da);
            _dbContext.Add(da);
            return "Thêm thành công";
        }
        public string Updatechitiethoadon(Chitiethoadon da)
        {
            _dbContext.Update(da);
            return "Sửa thành công";
        }
        public string Deletechitiethoadon(Chitiethoadon da)
        {
            _lstchitiethoadon.Remove(da);
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
