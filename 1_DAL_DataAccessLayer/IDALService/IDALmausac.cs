using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDALmausac
    {
        public List<Mausac> Getlistmausac();
        public string Addmausac(Mausac da);
        public string Updatemausac(Mausac da);
        public string Deletemausac(Mausac id);
        public string Save();
    }

}
