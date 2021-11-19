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
    public class DALthanhtoan : IDALthanhtoan
    {
        List<Thanhtoan> _lstthanhtoan;
        DatabaseContext _dbContext;
        public DALthanhtoan()
        {
            _dbContext = new DatabaseContext();
            _lstthanhtoan = new List<Thanhtoan>();
            getfromdv();
        }
        public void getfromdv()
        {
            _lstthanhtoan = _dbContext.Thanhtoans.ToList();
        }
        public List<Thanhtoan> Getlistthanhtoan()
        {
            return _lstthanhtoan;
        }
        public string Addthanhtoan(Thanhtoan da)
        {
            _lstthanhtoan.Add(da);
            _dbContext.Add(da);
            return "Thêm thành công";
        }
        public string Updatethanhtoan(Thanhtoan da)
        {
            _dbContext.Update(da);
            return "Sửa thành công";
        }
        public string Deletethanhtoan(Thanhtoan da)
        {
            _lstthanhtoan.Remove(da);
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
