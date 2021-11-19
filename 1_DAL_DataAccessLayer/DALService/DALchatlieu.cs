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
    public class DALchatlieu : IDALchatlieu
    {
        List<Chatlieu> _lstchatlieu;
        DatabaseContext _dbContext;
        public DALchatlieu()
        {
            _dbContext = new DatabaseContext();
            _lstchatlieu = new List<Chatlieu>();
            getfromdv();
        }
        public void getfromdv()
        {
            _lstchatlieu = _dbContext.Chatlieus.ToList();
        }
        public List<Chatlieu> Getlistchatlieu()
        {
            return _lstchatlieu;
        }
        public string Addchatlieu(Chatlieu da)
        {
            _lstchatlieu.Add(da);
            _dbContext.Add(da);
            return "Thêm thành công";
        }
        public string Updatechatlieu(Chatlieu da)
        {
            _dbContext.Update(da);
            return "Sửa thành công";
        }
        public string Deletechatlieu(Chatlieu da)
        {
            _lstchatlieu.Remove(da);
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
