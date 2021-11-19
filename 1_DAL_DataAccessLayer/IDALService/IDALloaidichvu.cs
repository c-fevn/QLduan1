using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDALloaidichvu
    {
        public List<Loaidichvu> Getlistloaidichvu();
        public string Addloaidichvu(Loaidichvu da);
        public string Updateloaidichvu(Loaidichvu da);
        public string Deleteloaidichvu(Loaidichvu id);
        public string Save();
    }
}
