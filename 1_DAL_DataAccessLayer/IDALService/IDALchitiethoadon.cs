using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALService
{
    
    public interface IDALchitiethoadon
    {
        public List<Chitiethoadon> Getlistchitiethoadon();
        public string Addchitiethoadon(Chitiethoadon da);
        public string Updatechitiethoadon(Chitiethoadon da);
        public string Deletechitiethoadon(Chitiethoadon id);
        public string Save();
    }
}
