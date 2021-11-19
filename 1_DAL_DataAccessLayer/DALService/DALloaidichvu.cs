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
    public class DALloaidichvu : IDALloaidichvu
    {
        List<Loaidichvu> _lstloaidichvu;
        DatabaseContext _dbContext;
        public DALloaidichvu()
        {
            _dbContext = new DatabaseContext();
            _lstloaidichvu = new List<Loaidichvu>();
            getfromdv();
        }
        public void getfromdv()
        {
            _lstloaidichvu = _dbContext.Loaidichvus.ToList();
        }
        public List<Loaidichvu> Getlistloaidichvu()
        {
            return _lstloaidichvu;
        }
        public string Addloaidichvu(Loaidichvu da)
        {
            _lstloaidichvu.Add(da);
            _dbContext.Add(da);
            return "Thêm thành công";
        }
        public string Updateloaidichvu(Loaidichvu da)
        {
            _dbContext.Update(da);
            return "Sửa thành công";
        }
        public string Deleteloaidichvu(Loaidichvu da)
        {
            _lstloaidichvu.Remove(da);
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
