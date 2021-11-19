using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDALnhanvien
    {
        public List<Nhanvien> Getlistnhanvien();
        public string Addnhanvien(Nhanvien da);
        public string Updatenhanvien(Nhanvien da);
        public string Deletenhanvien(Nhanvien id);
        public string Save();
    }
}
