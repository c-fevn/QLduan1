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
    public class BUSdichvu : IBUSdichvu
    {
        IDALdichvu _DALdichvu;
        List<Dichvu> _dichvus;
        public BUSdichvu()
        {
            _DALdichvu = new DALdichvu();
            _dichvus = new List<Dichvu>();
        }

        public List<Dichvu> getDichvu()
        {
            return _dichvus = _DALdichvu.Getlistdichvu();
        }

        public string SaveDichvu()
        {
            _DALdichvu.Save();
            return "luu thanh cong";
        }

        public bool SuaDichvu(Dichvu nv)
        {
            _DALdichvu.Updatedichvu(nv);
            return true;
        }

        public bool ThemDichvu(Dichvu nv)
        {
            _DALdichvu.Adddichvu(nv);
            return true;
        }

        public List<Dichvu> TimKiemtenDichvu(string ten)
        {
            return _dichvus.Where(c => c.Tendichvu.StartsWith(ten)).ToList();
        }

        public bool XoaDichvu(string temp)
        {
            var da = _DALdichvu.Getlistdichvu().Where(c => c.Madichvu == temp).FirstOrDefault();
            _DALdichvu.Deletedichvu(da);
            return true;
        }
    }
}
