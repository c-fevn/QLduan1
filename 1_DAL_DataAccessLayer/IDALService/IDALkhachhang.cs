using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDALkhachhang
    {
        public List<Khachhang> Getlistkhachhang();
        public string Addkhachhang(Khachhang da);
        public string Updatekhachhang(Khachhang da);
        public string Deletekhachhang(Khachhang id);
        public string Save();
    }
}
