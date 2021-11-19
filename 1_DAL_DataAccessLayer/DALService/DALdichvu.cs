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
    public class DALdichvu : IDALdichvu
    {
        List<Dichvu> _lstdichvu;
        DatabaseContext _dbContext;
        public DALdichvu()
        {
            _dbContext = new DatabaseContext();
            _lstdichvu = new List<Dichvu>();
            getfromdv();
        }
        public void getfromdv()
        {
            _lstdichvu = _dbContext.Dichvus.ToList();
        }
        public List<Dichvu> Getlistdichvu()
        {
            return _lstdichvu;
        }
        public string Adddichvu(Dichvu da)
        {
            _lstdichvu.Add(da);
            _dbContext.Add(da);
            return "Thêm thành công";
        }
        public string Updatedichvu(Dichvu da)
        {
            _dbContext.Update(da);
            return "Sửa thành công";
        }
        public string Deletedichvu(Dichvu da)
        {
            _lstdichvu.Remove(da);
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
