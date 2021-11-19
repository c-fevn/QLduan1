using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDALctsanpham
    {
        public List<Ctsanpham> Getlistctsanpham();
        public string Addctsanpham(Ctsanpham da);
        public string Updatectsanpham(Ctsanpham da);
        public string Deletectsanpham(Ctsanpham id);
        public string Save();
    }
    
}
