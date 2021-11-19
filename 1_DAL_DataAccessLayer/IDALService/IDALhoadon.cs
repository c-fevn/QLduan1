using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDALhoadon
    {
        public List<Hoadon> Getlisthoadon();
        public string Addhoadon(Hoadon da);
        public string Updatehoadon(Hoadon da);
        public string Deletehoadon(Hoadon id);
        public string Save();
    }
}
