using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.DALService;
using _1_DAL_DataAccessLayer.IDALService;

namespace _2_BUS_BusinessLayer.IBUSService
{
    public interface IBUSloaidichvu
    {
        public string SaveLoaidichvu();
        public List<Loaidichvu> getLoaidichvu();
        public List<Loaidichvu> TimKiemtenLoaidichvu(string ten);
        public bool XoaLoaidichvu(string temp);
        public bool SuaLoaidichvu(Loaidichvu nv);
        public bool ThemLoaidichvu(Loaidichvu nv);
    }
}
