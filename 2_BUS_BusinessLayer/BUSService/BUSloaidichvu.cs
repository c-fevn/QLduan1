using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.DALService;
using _1_DAL_DataAccessLayer.IDALService;
using _2_BUS_BusinessLayer.IBUSService;

namespace _2_BUS_BusinessLayer.BUSService
{
    public class BUSloaidichvu : IBUSloaidichvu
    {

        IDALloaidichvu _DALloaidichvu;
        List<Loaidichvu> _loaidichvus;
        public BUSloaidichvu()
        {
            _DALloaidichvu = new DALloaidichvu();
            _loaidichvus = new List<Loaidichvu>();
        }
        public List<Loaidichvu> getLoaidichvu()
        {
            return _loaidichvus = _DALloaidichvu.Getlistloaidichvu();
        }

        public string SaveLoaidichvu()
        {
            _DALloaidichvu.Save();
            return "luu thanh cong";
        }

        public bool SuaLoaidichvu(Loaidichvu nv)
        {
            _DALloaidichvu.Updateloaidichvu(nv);
            return true;
        }

        public bool ThemLoaidichvu(Loaidichvu nv)
        {
            _DALloaidichvu.Addloaidichvu(nv);
            return true;
        }

        public List<Loaidichvu> TimKiemtenLoaidichvu(string ten)
        {
            return _loaidichvus.Where(c => c.Tenloaidichvu.StartsWith(ten)).ToList();
        }

        public bool XoaLoaidichvu(string temp)
        {
            var da = _DALloaidichvu.Getlistloaidichvu().Where(c => c.Maloaidichvu == temp).FirstOrDefault();
            _DALloaidichvu.Deleteloaidichvu(da);
            return true;
        }
    }
}
