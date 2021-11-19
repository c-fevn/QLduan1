using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDALloaisanpham
    {
        public List<Loaisanpham> Getlistloaisanpham();
        public string Addloaisanpham(Loaisanpham da);
        public string Updateloaisanpham(Loaisanpham da);
        public string Deleteloaisanpham(Loaisanpham id);
        public string Save();
    }
}
