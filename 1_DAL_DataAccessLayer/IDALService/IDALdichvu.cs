using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDALdichvu
    {
        public List<Dichvu> Getlistdichvu();
        public string Adddichvu(Dichvu da);
        public string Updatedichvu(Dichvu da);
        public string Deletedichvu(Dichvu id);
        public string Save();
    }
}
