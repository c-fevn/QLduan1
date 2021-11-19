using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALService
{
     public interface IDALdonvi
    {
        public List<Donvi> Getlistdonvi();
        public string Adddonvi(Donvi da);
        public string Updatedonvi(Donvi da);
        public string Deletedonvi(Donvi id);
        public string Save();
    }
}
