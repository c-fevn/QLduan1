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
    public interface IBUSnhanvien
    {
        public string SaveNhanvien();
        public List<Nhanvien> getnhanvien();
        public List<Nhanvien> TimKiemtenNhanvien(string ten);
        public bool XoaNhanvien(string temp);
        public bool SuaNhanvien(Nhanvien nv);
        public bool ThemNhanvien(Nhanvien nv);

    }
}
