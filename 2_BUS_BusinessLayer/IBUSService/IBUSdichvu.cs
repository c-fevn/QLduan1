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
    public interface IBUSdichvu
    {
        public string SaveDichvu();
        public List<Dichvu> getDichvu();
        public List<Dichvu> TimKiemtenDichvu(string ten);
        public bool XoaDichvu(string temp);
        public bool SuaDichvu(Dichvu nv);
        public bool ThemDichvu(Dichvu nv);
    }
}
