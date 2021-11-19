using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDALsanpham
    {
        public List<Sanpham> Getlistsanpham();
        public string Addsanpham(Sanpham da);
        public string Updatesanpham(Sanpham da);
        public string Deletesanpham(Sanpham id);
        public string Save();
    }
}
