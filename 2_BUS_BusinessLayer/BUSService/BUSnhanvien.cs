using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.IBUSService;
using _1_DAL_DataAccessLayer.DALService;
using _1_DAL_DataAccessLayer.IDALService;
using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.BUSService
{
    public class BUSnhanvien : IBUSnhanvien
    {
        IDALnhanvien _DALnhanvien;
        List<Nhanvien> _nhanviens;
        public BUSnhanvien()
        {
            _nhanviens = new List<Nhanvien>();
            _DALnhanvien = new DALnhanvien();
        }
        public List<Nhanvien> getnhanvien()
        {
            return _nhanviens = _DALnhanvien.Getlistnhanvien();
        }
        public string SaveNhanvien()
        {
            _DALnhanvien.Save();
            return "luu thanh cong";
        }
        public bool ThemNhanvien(Nhanvien nv)
        {

            _DALnhanvien.Addnhanvien(nv);
            return true;
        }
        public bool SuaNhanvien(Nhanvien nv)
        {
            _DALnhanvien.Updatenhanvien(nv);
            return true;
        }

        public bool XoaNhanvien(string temp)
        {

            var da = _DALnhanvien.Getlistnhanvien().Where(c => c.Manhanvien == temp).FirstOrDefault();
            _DALnhanvien.Deletenhanvien(da);

            return true;
        }

        public List<Nhanvien> TimKiemtenNhanvien(string ten)
        {
            return _nhanviens.Where(c => c.Tennhanvien.StartsWith(ten)).ToList();
        }
    }
}
